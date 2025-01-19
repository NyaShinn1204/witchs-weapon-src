namespace System
{
	public static class Tuple
	{
		public static Tuple<T1, T2> Create<T1, T2>(T1 t1, T2 t2)
		{
			return null;
		}
	}
	public class Tuple<T1, T2>
	{
		public T1 Item1 { get; private set; }

		public T2 Item2 { get; private set; }

		public Tuple(T1 item1, T2 item2)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
