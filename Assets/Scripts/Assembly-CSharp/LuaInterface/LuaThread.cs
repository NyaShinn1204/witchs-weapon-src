namespace LuaInterface
{
	public class LuaThread : LuaBaseRef
	{
		private object[] objs;

		public LuaThread(int reference, LuaState state)
		{
		}

		public int Resume(params object[] args)
		{
			return 0;
		}

		public object[] GetResult()
		{
			return null;
		}
	}
}
