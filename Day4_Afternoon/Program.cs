using System;

namespace Day3_Afternoon_Practice1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int[] num = new int[5];
			int i=0;



			while(true){


				try{
					Console.WriteLine ("\nEnter a Number :");
					num[i]=int.Parse(Console.ReadLine());
						
					Console.Write("The Array is :");

					for(int j=0;j<i;j++)
						Console.Write("{0},",num[j]);
					
					//i++;
					Console.WriteLine("{0}",num[i]);
					i++;
				}
				catch (FormatException fe){
					Console.WriteLine (fe.Message);
					break;

				}
				catch(IndexOutOfRangeException e){

					Console.WriteLine (e.Message);
					break;
				}
				catch(Exception e){
					Console.WriteLine (e.Message);
				}

			}



		
		}
	}
}
