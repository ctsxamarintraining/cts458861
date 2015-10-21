using System;
using System.Collections.Generic;

namespace Program4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> myList = new List<int>();
			myList.Add (1);
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.AddRange (new List<int> (){ 2, 3, 4 });
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Remove (2);
			Console.WriteLine ("Element deleted is 2");
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Insert (1, 10);
			Console.WriteLine ("Elements in list after inserting 10 are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Clear ();
			Console.WriteLine ("\nlist Deleted\n\n\nDictionary\n");



			Dictionary<int,string> myDictionary = new Dictionary<int, string> (){{1,"Sijo"},{2,"Subin"}};
			myDictionary.Add (3, "Priya");
			Console.WriteLine ("Keys :");
			foreach (int ele in myDictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values :");
			foreach (string ele in myDictionary.Values)
				Console.WriteLine (ele);
			myDictionary.ContainsValue ("Sijo");
			myDictionary.Remove (2);
			Console.WriteLine ("Keys :");
			foreach (int ele in myDictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values :");
			foreach (string ele in myDictionary.Values)
				Console.WriteLine (ele);
			myDictionary.Clear ();

            Console.Read();

		}
	}
}
