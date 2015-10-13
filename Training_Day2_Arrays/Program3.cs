using System;

namespace Training_Day2_Arrays
{
	public class Program3
	{
		public Program3 ()
		{
			Console.WriteLine ();
			Console.WriteLine ("Third Program : ");
			Console.WriteLine ("-----------------");
			Console.WriteLine ();
		}

		public void Array3(){
			
			Person[] p = new Person[5];
			for (int i = 0; i < 5; i++) {
				p [i] = new Person ();
				p[i].FirstName="FName"+(i+1).ToString();
				p [i].LastName = "LName" + (i + 1).ToString();

			}

			p [0].Age = 20;
			p [1].Age = 10;
			p [2].Age = 50;
			p [3].Age = 17;
			p [4].Age = 67;

			Array.Sort (p);



			for (int j = 0; j < p.Length; j++) {
				Console.WriteLine("FirstName :{0} \nLastName :{1}\nAge :{2}\n ",p[j].FirstName,p[j].LastName,p[j].Age);
							

			}

		}


	}



}

