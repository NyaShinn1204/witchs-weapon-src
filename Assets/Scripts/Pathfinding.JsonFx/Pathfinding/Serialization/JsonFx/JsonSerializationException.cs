using System;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonSerializationException : InvalidOperationException
	{
		public JsonSerializationException(string message)
		{
		}

		public JsonSerializationException(string message, Exception innerException)
		{
		}
	}
}
