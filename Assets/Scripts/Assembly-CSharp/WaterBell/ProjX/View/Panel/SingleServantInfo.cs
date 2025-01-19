using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class SingleServantInfo : UIDataBase
	{
		public long selectWeaponID;

		public long exp;

		public long expLimt;

		public int level;

		public int levelMax;

		public long defaultWeapon;

		public List<SingleWeaponInfo> weaponInfos;

		public int star;

		public int rank;

		public bool canRankUp;

		public bool canLevelUp;

		public bool canStarUp;

		public long currentWeaponID;

		public long favLv;

		public long favExp;

		public int imageSerial;

		public void Bind(long servantID)
		{
		}

		public void Bind(SingleServantViewModel servantViewModel, CurrentServantWeaponInfoViewModel weaponViewModel)
		{
		}

		public SingleWeaponInfo GetWeapon(long weaponID)
		{
			return null;
		}
	}
}
