using System;
using System.IO;

namespace Day4_AfterNoon_Practice2
{
	public class Program2
	{
		public void ReadFile(){

		
			Console.WriteLine ("Enter File Name with full Path");
			string filename  = Console.ReadLine ();

			try{

				Console.WriteLine("Contents  \n"+File.ReadAllText(filename));


			}catch(FileNotFoundException){
				Console.WriteLine ("file not found");
			
			}catch(Exception) {
				Console.WriteLine ("Exception");
			}
		
		}


	}
}

