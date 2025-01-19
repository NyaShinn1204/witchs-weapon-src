using System;
using System.Collections;

namespace UniRx
{
	public static class Tuple
	{
		public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			return null;
		}

		public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			return null;
		}

		public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			return null;
		}

		public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			return null;
		}

		public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			return null;
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return null;
		}

		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return null;
		}

		public static Tuple<T1> Create<T1>(T1 item1)
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		private T6 item6;

		private T7 item7;

		private TRest rest;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public T2 Item2
		{
			get
			{
				return default(T2);
			}
		}

		public T3 Item3
		{
			get
			{
				return default(T3);
			}
		}

		public T4 Item4
		{
			get
			{
				return default(T4);
			}
		}

		public T5 Item5
		{
			get
			{
				return default(T5);
			}
		}

		public T6 Item6
		{
			get
			{
				return default(T6);
			}
		}

		public T7 Item7
		{
			get
			{
				return default(T7);
			}
		}

		public TRest Rest
		{
			get
			{
				return default(TRest);
			}
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public Tuple(T1 item1)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		private T2 item2;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public T2 Item2
		{
			get
			{
				return default(T2);
			}
		}

		public Tuple(T1 item1, T2 item2)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public T2 Item2
		{
			get
			{
				return default(T2);
			}
		}

		public T3 Item3
		{
			get
			{
				return default(T3);
			}
		}

		public Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public T2 Item2
		{
			get
			{
				return default(T2);
			}
		}

		public T3 Item3
		{
			get
			{
				return default(T3);
			}
		}

		public T4 Item4
		{
			get
			{
				return default(T4);
			}
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public T2 Item2
		{
			get
			{
				return default(T2);
			}
		}

		public T3 Item3
		{
			get
			{
				return default(T3);
			}
		}

		public T4 Item4
		{
			get
			{
				return default(T4);
			}
		}

		public T5 Item5
		{
			get
			{
				return default(T5);
			}
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		private T6 item6;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public T2 Item2
		{
			get
			{
				return default(T2);
			}
		}

		public T3 Item3
		{
			get
			{
				return default(T3);
			}
		}

		public T4 Item4
		{
			get
			{
				return default(T4);
			}
		}

		public T5 Item5
		{
			get
			{
				return default(T5);
			}
		}

		public T6 Item6
		{
			get
			{
				return default(T6);
			}
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		private T6 item6;

		private T7 item7;

		public T1 Item1
		{
			get
			{
				return default(T1);
			}
		}

		public T2 Item2
		{
			get
			{
				return default(T2);
			}
		}

		public T3 Item3
		{
			get
			{
				return default(T3);
			}
		}

		public T4 Item4
		{
			get
			{
				return default(T4);
			}
		}

		public T5 Item5
		{
			get
			{
				return default(T5);
			}
		}

		public T6 Item6
		{
			get
			{
				return default(T6);
			}
		}

		public T7 Item7
		{
			get
			{
				return default(T7);
			}
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		string ITuple.ToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
