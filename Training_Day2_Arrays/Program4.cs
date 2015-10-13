using System;
using System.Collections;

namespace Training_Day2_Arrays
{
	public class Program4
	{
		public Program4 ()
		{
			
			Console.WriteLine ("Fourth Program : ");
			Console.WriteLine ("-----------------");
			Console.WriteLine ();
		}

		public void Array4(){



			Person[] p = new Person[5];

			p [0] = new Person ("Sijo", "Varghese", 20);
			p [1] = new Person ("Abhi", "Kumar", 10);
			p [2] = new Person ("Abhi", "Bachhan", 50);
			p [3] = new Person ("John", "Cena", 17);
			p [4] = new Person ("Jimmy", "Anderson", 67);



			Array.Sort(p,Person.SortByName);

			for (int j = 0; j < p.Length; j++) {
				
				Console.WriteLine("FirstName :{0} \nLastName :{1}\nAge :{2}\n ",p[j].FirstName,p[j].LastName,p[j].Age);

			}
		


		}


	}
}

