
using System;
using System.IO;

namespace Afternoon_FileIO
{
	public class ByteArrayProgram
	{
		public ByteArrayProgram ()
		{
			Console.WriteLine ();
			Console.WriteLine ("Program to Copy the file Content using byte array");
			Console.WriteLine ("------------------------------------");
			
		}


		public void IOProgram3(){

			TextReader input = new StreamReader ("Sample.txt");
			TextWriter output = new StreamWriter ("Sample1.txt");
			char[] buffer = new char[500];
			int read;
			while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
			{
				output.Write (buffer, 0, read);
			}
			input.Close ();
			output.Close ();



		}

	}
}

