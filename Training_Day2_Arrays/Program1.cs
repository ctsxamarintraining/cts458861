using System;

namespace Training_Day2_Arrays
{
	public class Program1
	{
		public Program1(){
			
			Console.WriteLine ("First Program : ");
			Console.WriteLine ("----------------");
			Console.WriteLine ();
		}

		public void Array1 ()
		{
			// 4D Array Declaration and initialization
			String[,,,] str = new string[2, 2, 2, 2]{{{{"one","two"},{"three","four"}},{{"five","six"},
						{"seven","eight"}}},{{{"nine","ten"},{"11","12"}},{{"13","14"},{"15","16"}}}};


			//iterating and printing the elements
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++) {
					for (int k = 0; k < 2; k++) {
						for (int l = 0; l < 2; l++) {
							Console.WriteLine("String {0} ", str [i, j, k, l]);

						}

					}
				
				}

			}
		}
		
			
		}




	}


