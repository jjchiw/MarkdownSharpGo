# MarkdownSharpGo

## Overview

Using the [MarkdownSharp][1]  and [Args][2] and after reading this 
[Blog][3]

I didn't want to install perl, so I searched for a Markdown for .NET and found [MarkdownSharp][1]

I coded a simple Markdown console, put it in the path and use it like [stimmelopolis][3]

## Usage

**NppExec Plugin (Notepad++)**
	cd $(CURRENT_DIRECTORY)
	markdownsharpgo.exe /f $(FILE_NAME) /o launch
	
**CMD**
	markdownsharpgo.exe /f $(FILE_NAME) /o launch
	
**Arguments**
	/f File to be parsed
	/o options: launch, console, file


[1]: http://code.google.com/p/markdownsharp/
[2]: https://github.com/littlebits/args
[3]: http://www.stimmelopolis.com/blog/2010/02/16/markdown-in-notepad-2/
	
## Copyright and License

Copyright (c) 2010 Juan J. Chiw

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.