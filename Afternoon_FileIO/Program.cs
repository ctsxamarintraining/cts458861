using System;

namespace Afternoon_FileIO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Program 1: Reverse the file Content

			ProgramReverse p1 = new ProgramReverse ();
			p1.ReverseFile ();


			// Program 2: Recursive function to copy from source to destination

			CopyDirRecursive p2 = new CopyDirRecursive ();
			p2.Program2();

			// Program 3: Program to Copy the file Content using byte array
			ByteArrayProgram p3 = new ByteArrayProgram ();
			p3.IOProgram3 ();

			// Program 4: Program of Symmetric key encryption
	     		
			SymmetricKeyEncryption p4 = new SymmetricKeyEncryption ();
			p4.Program4 ();
			
			
			//Program 5: Program for JSON serialization
			
			JSONSerialization p5 = new JSONSerialization ();
			p5.Program5 ();

		}
	}
}
