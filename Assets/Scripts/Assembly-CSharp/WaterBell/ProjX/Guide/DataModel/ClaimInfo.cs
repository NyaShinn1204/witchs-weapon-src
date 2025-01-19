using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.Guide.DataModel
{
	[Serializable]
	public class ClaimInfo
	{
		public List<ConversationRole> role;

		public StageInfo stage;

		public string defaultBGM;
	}
}
