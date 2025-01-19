using System.Collections;

namespace Common
{
	public sealed class JSONTokener
	{
		private string ins;

		public Hashtable nameValuePairs;

		private int pos;

		public JSONTokener(string ins)
		{
		}

		public object nextValue()
		{
			return null;
		}

		private int nextCleanInternal()
		{
			return 0;
		}

		private void skipToEndOfLine()
		{
		}

		public string nextString(char quote)
		{
			return null;
		}

		private char readEscapeCharacter()
		{
			return '\0';
		}

		private SFJSONObject readObject()
		{
			return null;
		}
	}
}
