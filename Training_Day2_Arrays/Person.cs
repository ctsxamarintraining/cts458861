using System;
using System.Collections;

namespace Training_Day2_Arrays
{
	public class Person : IComparable
	{
		public string FirstName{ get; set;}
		public string LastName{get;set;}
		public int Age{ get; set;}

		public Person(){
			
		}

		public Person( string fname,string lname, int age)
		{
			FirstName = fname;
			LastName=lname;
			Age = age;
		}

		public int CompareTo(object obj){

			if(obj is Person)
				return this.Age.CompareTo ((obj as Person).Age);
			else
				throw new ArgumentException("Object is not a Person");	

		}


		public static IComparer SortByName{
			get{
			return (IComparer)new SortPerson ();
			}
		}

			

	 class SortPerson:IComparer
	{
		public int Compare (object x, object y)
		{
			Person a = (Person)x;
			Person b = (Person)y;
			 int i=String.Compare (a.FirstName, b.FirstName);
			if (i == 0)
				return string.Compare (a.LastName, b.LastName);
			else
				return string.Compare (a.FirstName, b.FirstName);


		}


	}

	}
}



