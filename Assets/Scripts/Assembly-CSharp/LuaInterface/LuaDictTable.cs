using System;
using System.Collections;
using System.Collections.Generic;

namespace LuaInterface
{
	public class LuaDictTable : IDisposable, IEnumerable<DictionaryEntry>, IEnumerable
	{
		private class Enumerator : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			private LuaState state;

			private DictionaryEntry current;

			private int top;

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			public DictionaryEntry Current
			{
				get
				{
					return default(DictionaryEntry);
				}
			}

			public Enumerator(LuaDictTable list)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private LuaTable table;

		private LuaState state;

		public object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LuaDictTable(LuaTable table)
		{
		}

		public void Dispose()
		{
		}

		public Hashtable ToHashtable()
		{
			return null;
		}

		public IEnumerator<DictionaryEntry> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
