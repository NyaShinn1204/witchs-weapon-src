using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class ResTipsData : TipsBaseData
	{
		protected static readonly Dictionary<GlobalEnum.ResType, string> pathDict;

		public UIRawResData uiRawResData;

		public ResTipsData(UIRawResData uiRawResData)
		{
		}

		public override string GetPrefabPath()
		{
			return null;
		}
	}
}
