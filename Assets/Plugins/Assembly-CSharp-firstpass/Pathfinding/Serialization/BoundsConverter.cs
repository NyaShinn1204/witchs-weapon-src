using System;
using System.Collections.Generic;
using Pathfinding.Serialization.JsonFx;

namespace Pathfinding.Serialization
{
	public class BoundsConverter : JsonConverter
	{
		public override bool CanConvert(Type type)
		{
			return false;
		}

		public override object ReadJson(Type objectType, Dictionary<string, object> values)
		{
			return null;
		}

		public override Dictionary<string, object> WriteJson(Type type, object value)
		{
			return null;
		}
	}
}
