using System;
using System.IO;
using Newtonsoft.Json;

namespace Afternoon_FileIO
{
	public class JSONSerialization
	{
		public JSONSerialization ()
		{

			Console.WriteLine ();
			Console.WriteLine ("Program for JSON serialization");
			Console.WriteLine ("-------------------------------");
		}

		public void Program5()
        {
            Person[] p = new Person[3];
            p[0].Name = "Sijo";p[0]. Id = 5;
            p[1].Name = "Rohit";p[1].Id = 2;
            p[2].Name = "Arpit";p[2].Id = 3;




            FileStream fs = new FileStream("JsonFile.json", FileMode.Create); //creating File and adding Text
            using (StreamWriter sw = new StreamWriter(fs))
            {

                JsonSerializer jSerializer = new JsonSerializer();
                jSerializer.Serialize(sw, p);
            }

        }
    }



	public class Person
	{
		public string Name { get; set; }
		public int Id { get; set; }
	}
}


