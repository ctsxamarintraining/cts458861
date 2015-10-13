using System;

namespace Training_Day2_Arrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Question 1
			Program1 p1 = new Program1 ();
			p1.Array1 ();

			//Question 2
			String[,] str2DArray=new string[2,2]{{"Hello","World"},{"Welcome","User"}};
			String[,,,] str4DArray = new string[2, 2, 2, 2]{{{{"one","two"},{"three","four"}},{{"five","six"},
						{"seven","eight"}}},{{{"nine","ten"},{"11","12"}},{{"13","14"},{"15","16"}}}};

			Program2 p2=new Program2();
			Console.WriteLine ("2D Array :");
			Console.WriteLine ();
			p2.Array2 (str2DArray);
			Console.WriteLine ();
			Console.WriteLine ("4D Array :");
			Console.WriteLine ();
			p2.Array2 (str4DArray);

			//Question3
			Program3 p3 = new Program3 ();
			p3.Array3 ();

			//Question4
			Program4 p4 = new Program4 ();
			p4.Array4 ();

							
		}
	}
}
