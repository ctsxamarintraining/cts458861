using System;
using System.IO;
using System.Collections.Generic;

namespace Afternoon_FileIO
{
	public class ProgramReverse
	{
		String filename1="file1.txt";
		String filename2 = "file2.txt";
		List<string> strArray=new List<string>();

		int count=0;

		public ProgramReverse(){
			Console.WriteLine ();
			Console.WriteLine ("Program to Reverse the file Content");
			Console.WriteLine ("------------------------------------");
		
		}

		public void ReverseFile(){

			FileStream fs1 = new FileStream (filename1, FileMode.Create); //creating File and adding Text
			using (StreamWriter sw = new StreamWriter (fs1)) {
				for (int i = 1; i <= 10; i++) 
					sw.WriteLine ("Line Number {0} in {1}", i, filename1);
				
			}

			Console.WriteLine ("File Content Before Reversing :");		//Displaying and adding content in List 
			Console.WriteLine ("------------------------------");
			using (StreamReader sr = new StreamReader (filename1)) {
				while(!sr.EndOfStream){					
					strArray.Add(sr.ReadLine());
					Console.WriteLine (strArray[count]);
					count++;				
				}
			}

			strArray.Reverse ();										// revering the List 


			FileStream fs2 = new FileStream (filename2, FileMode.Create);//copying content of file1 to file2
			using (StreamWriter sw = new StreamWriter (fs2)) {				
				foreach (String str in strArray)
					sw.WriteLine (str);				
			}


			Console.WriteLine ("\nFile Content After Reversing :");			//Dipaing New File Content
			Console.WriteLine ("------------------------------");
			using (StreamReader sr = new StreamReader (filename2)) {
				while(!sr.EndOfStream)
					Console.WriteLine (sr.ReadLine());
				
			}

		}


	}
}

