namespace LuaInterface
{
	public class EventObject
	{
		[NoToLua]
		public EventOp op;

		[NoToLua]
		public LuaFunction func;

		[NoToLua]
		public string name;

		[NoToLua]
		public EventObject(string name)
		{
		}

		public static EventObject operator +(EventObject a, LuaFunction b)
		{
			return null;
		}

		public static EventObject operator -(EventObject a, LuaFunction b)
		{
			return null;
		}

		[NoToLua]
		public override string ToString()
		{
			return null;
		}
	}
}
