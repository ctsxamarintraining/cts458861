using System;

namespace GarbageCollectionExample
{
	

	class MainClass
	{
		public static void Main (string[] args)
		{

			for (int i = 0; i < 10000; i++) {
			
				Garbage[] garbage = new Garbage[10000];
				garbage[i]=new Garbage();

			
			}

			Console.WriteLine ("Memory used before collection       :"+GC.GetTotalMemory(false));

			//Garbage Collector
			GC.Collect();
			Console.WriteLine ("Memory used after garbage collection:"+GC.GetTotalMemory(false));




		}



	}


	class Garbage{

		public Garbage(){
			a [0] = 10;
			b [0] = 10;
			c [0] = 10;
			d [0] = 10;

		}

		int[] a = new int[10000];
		int[] b = new int[10000];
		int[] c = new int[10000];
		int[] d = new int[10000];
	

	}


}
