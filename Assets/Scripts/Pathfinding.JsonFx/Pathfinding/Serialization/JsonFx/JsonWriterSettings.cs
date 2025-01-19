using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonWriterSettings
	{
		private WriteDelegate<DateTime> dateTimeSerializer;

		private int maxDepth;

		private string newLine;

		private bool prettyPrint;

		private string tab;

		private string typeHintName;

		private bool useXmlSerializationAttributes;

		protected List<JsonConverter> converters;

		[CompilerGenerated]
		private bool _003CHandleCyclicReferences_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CDebugMode_003Ek__BackingField;

		public bool HandleCyclicReferences
		{
			[CompilerGenerated]
			get
			{
				return _003CHandleCyclicReferences_003Ek__BackingField;
			}
		}

		public virtual string TypeHintName
		{
			get
			{
				return null;
			}
		}

		public virtual bool PrettyPrint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string Tab
		{
			get
			{
				return null;
			}
		}

		public virtual string NewLine
		{
			get
			{
				return null;
			}
		}

		public virtual int MaxDepth
		{
			get
			{
				return 0;
			}
		}

		public virtual bool UseXmlSerializationAttributes
		{
			get
			{
				return false;
			}
		}

		public virtual WriteDelegate<DateTime> DateTimeSerializer
		{
			get
			{
				return null;
			}
		}

		public virtual bool DebugMode
		{
			[CompilerGenerated]
			get
			{
				return _003CDebugMode_003Ek__BackingField;
			}
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
