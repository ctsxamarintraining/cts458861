using System;
using System.Security.Cryptography;
using System.IO;

namespace Afternoon_FileIO
{
	public class SymmetricKeyEncryption
	{
		public SymmetricKeyEncryption ()
		{
			Console.WriteLine ();
			Console.WriteLine ("Program of Symmetric key encryption");
			Console.WriteLine ("------------------------------------");
		}

		public void Program4()
		{
			try
			{
				Console.WriteLine("Enter text to encrypt:");
				string text = Console.ReadLine();
				DESCryptoServiceProvider key = new DESCryptoServiceProvider();//Encryption
				byte[] buffer = Encrypt(text, key);
				System.IO.File.WriteAllBytes("EncryptedFile.txt", buffer);//write encrypted text in file


				byte[] buferToDecrypt = File.ReadAllBytes("EncryptedFile.txt");//read encrypted tex from file 
				string str = Decrypt(buferToDecrypt, key); //Decryption
				Console.WriteLine("\nDecrypted text:{0}",str);
			}
			catch (Exception)
			{

				Console.WriteLine("Exception");
			}

		}
		public static byte[] Encrypt(string str, SymmetricAlgorithm key)
		{
			
			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);

			StreamWriter sw = new StreamWriter(cs);
					
			sw.WriteLine(str);
			sw.Close();
			cs.Close();
					
			byte[] buffer = ms.ToArray();
			ms.Close();

			return buffer;
		}
		public static string Decrypt(byte[] encryptText, SymmetricAlgorithm key)
		{
			
			MemoryStream ms = new MemoryStream(encryptText);
			CryptoStream cs = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);

			StreamReader sr = new StreamReader(cs);
		
			string val = sr.ReadLine();
			sr.Close();
			cs.Close();
			ms.Close();

			return val;
		}

	}
}

