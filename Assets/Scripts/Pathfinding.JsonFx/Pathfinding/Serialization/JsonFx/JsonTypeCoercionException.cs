using System;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonTypeCoercionException : ArgumentException
	{
		public JsonTypeCoercionException(string message)
		{
		}

		public JsonTypeCoercionException(string message, Exception innerException)
		{
		}
	}
}
