using System;

namespace UniRx
{
	[Serializable]
	public class Unit : IEquatable<Unit>
	{
		private static readonly Unit @default;

		public static Unit Default
		{
			get
			{
				return null;
			}
		}

		public static bool operator ==(Unit first, Unit second)
		{
			return false;
		}

		public static bool operator !=(Unit first, Unit second)
		{
			return false;
		}

		public bool Equals(Unit other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
