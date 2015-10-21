using System;
using System.Collections;

namespace Day6
{
	class MyEnumerable : IEnumerable{
		public IEnumerator GetEnumerator (){
			return new MyEnumerator ();
		}
	}
}

