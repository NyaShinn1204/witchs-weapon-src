using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonWriter : IDisposable
	{
		private readonly TextWriter Writer;

		private JsonWriterSettings settings;

		private int depth;

		private Dictionary<object, int> previouslySerializedObjects;

		public TextWriter TextWriter
		{
			get
			{
				return null;
			}
		}

		public JsonWriterSettings Settings
		{
			get
			{
				return null;
			}
		}

		public JsonWriter(StringBuilder output, JsonWriterSettings settings)
		{
		}

		void IDisposable.Dispose()
		{
		}

		public void Write(object value)
		{
		}

		protected virtual void Write(object value, bool isProperty)
		{
		}

		public virtual void Write(DateTime value)
		{
		}

		public virtual void Write(Guid value)
		{
		}

		public virtual void Write(Enum value)
		{
		}

		public virtual void Write(string value)
		{
		}

		public virtual void Write(bool value)
		{
		}

		public virtual void Write(byte value)
		{
		}

		public virtual void Write(sbyte value)
		{
		}

		public virtual void Write(short value)
		{
		}

		public virtual void Write(ushort value)
		{
		}

		public virtual void Write(int value)
		{
		}

		public virtual void Write(uint value)
		{
		}

		public virtual void Write(long value)
		{
		}

		public virtual void Write(ulong value)
		{
		}

		public virtual void Write(float value)
		{
		}

		public virtual void Write(double value)
		{
		}

		public virtual void Write(decimal value)
		{
		}

		public virtual void Write(char value)
		{
		}

		public virtual void Write(TimeSpan value)
		{
		}

		public virtual void Write(Uri value)
		{
		}

		public virtual void Write(Version value)
		{
		}

		protected internal virtual void WriteArray(IEnumerable value)
		{
		}

		protected virtual void WriteArrayItem(object item)
		{
		}

		protected virtual void WriteObject(IDictionary value)
		{
		}

		protected virtual void WriteDictionary(IEnumerable value)
		{
		}

		private void WriteObjectProperty(string key, object value)
		{
		}

		protected virtual void WriteObjectPropertyName(string name)
		{
		}

		protected virtual void WriteObjectPropertyValue(object value)
		{
		}

		protected virtual void WriteObject(object value, Type type, bool serializePrivate)
		{
		}

		protected virtual void WriteArrayItemDelim()
		{
		}

		protected virtual void WriteObjectPropertyDelim()
		{
		}

		protected virtual void WriteLine()
		{
		}

		private bool IsIgnored(Type objType, MemberInfo member, object obj)
		{
			return false;
		}

		private bool IsDefaultValue(MemberInfo member, object value)
		{
			return false;
		}

		private static Enum[] GetFlagList(Type enumType, object value)
		{
			return null;
		}

		protected virtual bool InvalidIeee754(decimal value)
		{
			return false;
		}
	}
}
