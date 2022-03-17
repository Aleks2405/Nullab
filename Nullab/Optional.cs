using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullab
{
	//class Optional<T> : IReadOnlyList<T>
	//{
	//	private T[] values;
	//	public Optional(T value) /*=> values = new[] { value };*/
	//       {
	//		values = new[] { value };
	//		for (int i = 0; i < values.Length;i++)
	//               Console.WriteLine(values.Length + "nyn");
	//       }
	//	public Optional() => values = new T[0];
	//	public T this[int index] => values[index];
	//	//public int Count => values.Count;
	//}
	class Optional<T> : IReadOnlyList<T>
	{
		private T[] values;
		public Optional(T value) => values = new[] { value };
		public Optional() => values = new T[0];
		public T this[int index] => values[index];
		//public int Counе => values.Count;
	}

}


