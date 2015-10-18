using System;

namespace Day5_Morning
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.WriteLine("Enter any string : ");
			string str = Console.ReadLine();

			Console.WriteLine ("\n\nTotal words are : {0} \nTotal characters are : {1}" ,str.totalWords() ,str.totalLetters());

		}
	}


	public static class ExtensionClass
	{

		public static int totalWords(this string s){
			string[] strArray = s.Split(new char[]{ ' ', '.' ,';',','});
			return strArray.Length;
		}
		public static int totalLetters(this string s){
			char[] charArray = s.ToCharArray ();
			int count = 0;
			foreach (char c in charArray) {
				if (!char.IsWhiteSpace (c))
					count++;
			}
			return count;
		}
	}

}
