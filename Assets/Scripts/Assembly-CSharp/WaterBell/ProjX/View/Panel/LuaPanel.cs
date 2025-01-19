using System;

namespace WaterBell.ProjX.View.Panel
{
	public class LuaPanel : UIPanelSingle
	{
		private LuaPanelUIData _LuaPanelUIData;

		public static LuaPanel Instance;

		public string CacheLuaModuleName;

		public string CacheArgs;

		protected override void Awake()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void Call(string sFuncName, string sArgs = "")
		{
		}
	}
}
