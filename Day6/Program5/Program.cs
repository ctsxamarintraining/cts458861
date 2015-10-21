using System;
using System.Collections.Generic;

namespace Program5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Dictionary<Person,int> personList1 = new Dictionary<Person,int>(new MyEqualityComparer()){
				{new Person{id=1,name="Sijo"},1},
				{new Person{id=2,name="Subin"},2},
				{new Person{id=1,name="Srinivas"},3}
			};
			Console.WriteLine ("Using IEqualityComparer");
			foreach (Person p in personList1.Keys)
				Console.WriteLine (p.name);
			List<Person> myList = new List<Person> {
				new Person{ id = 1, name = "Sijo" },
				new Person{ id = 6, name = "Priya" },
				new Person{ id = 4, name = "Midhila" }
			};
			Console.WriteLine ("Using IComparer");
			myList.Sort (new MyComparer ());
			foreach(Person p in myList)
				Console.WriteLine (p.name);

            Console.Read();
		}
	}
	class Person{
		public string name;
		public int id;
	}
	class MyEqualityComparer : IEqualityComparer<Person>{
		
		public bool Equals (Person x, Person y)
		{
			return x.id==y.id;
		}
		public int GetHashCode (Person obj)
		{
			return obj.GetHashCode ();
		}
		
	}
	class MyComparer : IComparer<Person>{
		
		public int Compare (Person x, Person y)
		{
			return x.name.CompareTo (y.name);
		}
		
	}
}
