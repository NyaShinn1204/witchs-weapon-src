using Google.Protobuf.Collections;
using Svmod;

namespace WaterBell.ProjX.Data.Entity
{
	public struct RankInfo
	{
		public int Ranking;

		public long RoldID;

		public int Level;

		public long HeadId;

		public long HeadBgId;

		public string Name;

		public int Title;

		public long Data;

		public RepeatedField<ServantInstanceProto> ServantInstanceProto;

		public RepeatedField<WeaponInstance> WeaponInstance;

		public RepeatedField<bool> IsMercenary;

		public float HP;

		public int BattleTime;

		public double CE;
	}
}
