using System;
using System.IO;

namespace Afternoon_FileIO
{
	public class CopyDirRecursive
	{

		public CopyDirRecursive()
		{
			Console.WriteLine ();
			Console.WriteLine ("Recursive function to copy from source folder to destination");
			Console.WriteLine ("-------------------------------------------------------------");
		}

		public void Program2(){

			string currentDir = System.IO.Directory.GetCurrentDirectory ();

			string srcFolder = Path.Combine(currentDir,"Source Folder");
			string desFolder = Path.Combine(currentDir,"Destination Folder");

			string path1 = Path.Combine(srcFolder, "Sub1");
			string path2 = Path.Combine(srcFolder, "Sub2");
			string path3 = Path.Combine(path1, "Sub1_1");
			string path4 = Path.Combine(path2, "Sub2_2");

		
			if(!Directory.Exists(path1))
			Directory.CreateDirectory(path1);

			if(!Directory.Exists(path2))
			Directory.CreateDirectory(path2);
			
			if(!Directory.Exists(path3))
			Directory.CreateDirectory(path3);
			
			if(!Directory.Exists(path4))
			Directory.CreateDirectory(path4);

			if(!File.Exists("file1.txt"))
			File.WriteAllText(Path.Combine(path1, "file1.txt"), "Contents of file1");
			
			if(!File.Exists("file2.txt"))
			File.WriteAllText(Path.Combine(path2, "file2.txt"), "Contents of file2");
			
			if(!File.Exists("sourcefile.txt"))
			File.WriteAllText(Path.Combine(srcFolder, "sourcefile.txt"), "Contents of sourcefile");
			
			if(!File.Exists("file3.txt"))
			File.WriteAllText(Path.Combine(path3, "file3.txt"), "Contents of file3");
			
			if(!File.Exists("file4.txt"))
			File.WriteAllText(Path.Combine(path4, "file4.txt"), "Contents of file4");


			System.Console.WriteLine("Source File Created");

			CopyWholeFolder(srcFolder,
				desFolder);

			System.Console.WriteLine("Source Files & Folders Copied to Destination Folder");
			System.Console.ReadLine();

		}

		static public void CopyWholeFolder(string srcFolder, string desFolder)
		{
			if (!Directory.Exists(desFolder))
				Directory.CreateDirectory(desFolder);

			string[] files = Directory.GetFiles(srcFolder);
			foreach (string file in files)
			{
				string name = Path.GetFileName(file);
				string dest = Path.Combine(desFolder, name);
				if(!File.Exists(file))
					File.Copy(file, dest);
			}
			string[] folders = Directory.GetDirectories(srcFolder);
			foreach (string folder in folders)
			{
				string name = Path.GetFileName(folder);
				string dest = Path.Combine(desFolder, name);
				CopyWholeFolder(folder, dest);
			}
		} 

	}
}

