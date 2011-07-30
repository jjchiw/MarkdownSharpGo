using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MarkdownSharpGo
{
    public enum Output
    {
        console, launch, file
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
				
				if(command.File != null)
				{
					var m = new MarkdownSharp.Markdown();
	                var output = m.Transform(FileContents(command.File));
	
	                switch (command.Output)
	                {
	                    case Output.file:
	                        File.WriteAllText(Path.ChangeExtension(command.File, "html"), output);
	                        break;
	                    case Output.launch:
	                        var tempfile = Path.ChangeExtension(Path.GetTempFileName(), "html");
	                        File.WriteAllText(tempfile, output);
	                        System.Diagnostics.Process.Start(tempfile);
	                        break;
						case Output.console:
							Console.WriteLine(output);
							break;
	                }
				}
				else
				{
					Console.WriteLine("Usage Example:");
					Console.WriteLine("mono MarkdownSharpGo.exe /f <filename> [optional] /o launch | /o file");
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
				Console.WriteLine (e);
                return "";
            }

        }
    }
}
