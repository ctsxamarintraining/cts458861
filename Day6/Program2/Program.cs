using System;
using System.Collections.Generic;

namespace Program2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyList<int> myList = new MyList<int>();
			myList.Add (1);
			myList.Add (2);
			myList.Add (3);
			myList.Add (4);
			Console.WriteLine("my list has : "+myList.Count +" elements");
			Console.WriteLine("my list has 1 : "+myList.Contains (1));
			myList.Remove (1);
			Console.WriteLine("my list has 1 : "+myList.Contains (1));
			Console.WriteLine("my list has : "+myList.Count +" elements");
			myList.Clear();

			Console.WriteLine("my list has : "+myList.Count +" elements");

            Console.Read();
		}

	}
	class MyList<T> : IList<T>{
		public void Add (T item)
		{
            this._index++;
            Insert(this._index, item);
            Console.WriteLine(item + " is added to List");
        }

		public void Clear ()
		{
            this._index = -1;
            Console.WriteLine("List Deleted");
        }

		public bool Contains (T item)
		{
            if (IndexOf(item) > -1)
            {
                return true;
            }
            else
                return false;
        }

		public void CopyTo (T[] array, int arrayIndex)
		{
			throw new NotImplementedException ();
		}

		public bool Remove (T item)
		{
            if (IndexOf(item) > -1)
            {
                RemoveAt(IndexOf(item));
                Console.WriteLine("Element deleted is " + item);
                return true;
            }
            else
                Console.WriteLine("No element");
            return false;
        }

		public int Count {
			get {
				return _index+1;
			}
		}

		public bool IsReadOnly {
			get {
				throw new NotImplementedException ();
			}
		}

		public IEnumerator<T> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		T[] listArray= new T[10];
		int _index;
		T myValue;
		public T this [int index] {
			get { return myValue; }
			set { myValue = value; }
		}
		public MyList(){

			_index = -1;
		}
		
		public int IndexOf (T item){
			for (int i = 0; i < this._index; i++) {
				if (listArray [i].Equals(item))
					return i;
			}
			return -1;
		}

		public void Insert (int index, T item){
			if (index < listArray.Length) {
				listArray [index] = item;
			}
			else
				Console.WriteLine ("Exceeded array");
		}

		public void RemoveAt (int index){
			for (int i = index; i < this._index; i++) {
				listArray [i] = listArray [i + 1];

			}
			_index--;
		}
		
	}
}
