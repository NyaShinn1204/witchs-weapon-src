using System;

namespace Pathfinding.Serialization.JsonFx
{
	public sealed class JsonIgnoreAttribute : Attribute
	{
		public static bool IsJsonIgnore(object value)
		{
			return false;
		}

		public static bool IsXmlIgnore(object value)
		{
			return false;
		}
	}
}
