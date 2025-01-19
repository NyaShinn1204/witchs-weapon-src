using System;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public sealed class fsDuplicateVersionNameException : Exception
	{
		public fsDuplicateVersionNameException(Type typeA, Type typeB, string version)
		{
		}
	}
}
