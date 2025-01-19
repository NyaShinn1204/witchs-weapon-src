using System.Collections.Generic;

namespace WaterBell.ProjX.Guide.DataModel
{
	public class RoundInfo
	{
		public int parentIdx;

		public RecPointInfo recPoint;

		public string triggerID;

		public int allowTriggerDelay;

		public string evtType;

		public List<GuideCMD> b4cmdList;

		public List<GuideCMD> a4cmdList;

		public ActionEvent GetEventName()
		{
			return default(ActionEvent);
		}
	}
}
