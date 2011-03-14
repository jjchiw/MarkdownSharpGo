using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MarkdownSharpGo
{
    public enum Output
    {
        launch, console, file
    }

    public class CommandObject
    {
        public string File { get; set; }
        public Output Output { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var command = Args.Configuration.Configure<CommandObject>().CreateAndBind(args);

                var m = new MarkdownSharp.Markdown();
                var output = m.Transform(FileContents(command.File));

                switch (command.Output)
                {
                    case Output.console:
                        Console.WriteLine(output);
                        break;
                    case Output.file:
                        File.WriteAllText(Path.ChangeExtension(command.File, "html"), output);
                        break;
                    case Output.launch:
                        var tempfile = Path.ChangeExtension(Path.GetTempFileName(), "html");
                        File.WriteAllText(tempfile, output);
                        System.Diagnostics.Process.Start(tempfile);
                        break;
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        static string FileContents(string filename)
        {
            try
            {
                return File.ReadAllText(filename);
            }
            catch (FileNotFoundException e)
            {
                return "";
            }

        }
    }
}
