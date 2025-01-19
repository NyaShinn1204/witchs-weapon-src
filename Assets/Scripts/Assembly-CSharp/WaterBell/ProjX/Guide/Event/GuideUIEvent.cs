using WaterBell.Framework.Event;

namespace WaterBell.ProjX.Guide.Event
{
	public class GuideUIEvent : EventBase
	{
		protected UIEvtType evtType;

		protected string evtParam;

		public GuideUIEvent(UIEvtType type, string param = "")
		{
		}

		public string GetUIEventID()
		{
			return null;
		}

		public UIEvtType GetUIEventType()
		{
			return default(UIEvtType);
		}

		public string GetUIEventParam()
		{
			return null;
		}
	}
}
