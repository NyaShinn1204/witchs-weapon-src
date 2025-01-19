using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonReaderSettings
	{
		internal readonly TypeCoercionUtility Coercion;

		private bool allowUnquotedObjectKeys;

		private string typeHintName;

		protected List<JsonConverter> converters;

		[CompilerGenerated]
		private bool _003CHandleCyclicReferences_003Ek__BackingField;

		public bool HandleCyclicReferences
		{
			[CompilerGenerated]
			get
			{
				return _003CHandleCyclicReferences_003Ek__BackingField;
			}
		}

		public bool AllowUnquotedObjectKeys
		{
			get
			{
				return false;
			}
		}

		internal bool IsTypeHintName(string name)
		{
			return false;
		}

		public virtual JsonConverter GetConverter(Type type)
		{
			return null;
		}

		public virtual void AddTypeConverter(JsonConverter converter)
		{
		}
	}
}
