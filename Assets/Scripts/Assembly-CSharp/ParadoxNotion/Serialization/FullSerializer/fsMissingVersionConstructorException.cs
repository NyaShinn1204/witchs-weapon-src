using System;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public sealed class fsMissingVersionConstructorException : Exception
	{
		public fsMissingVersionConstructorException(Type versionedType, Type constructorType)
		{
		}
	}
}
