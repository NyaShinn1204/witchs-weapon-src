using System.Collections.Generic;

namespace WaterBell.ProjX.Guide.DataModel
{
	public class LessonSettingData
	{
		private Dictionary<string, ConversationRole> roleDict;

		public ClaimInfo ClaimInfo { get; set; }

		public List<RoundInfo> rounds { get; set; }

		public void BuildRoleDict()
		{
		}

		public ConversationRole GetRole(string roleSN)
		{
			return null;
		}
	}
}
