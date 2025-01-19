using System.Collections.Generic;
using Activitymod;
using Google.Protobuf.Collections;

namespace WaterBell.ProjX.Data.Entity
{
	public class Activity
	{
		private Dictionary<int, List<DrawActivityData>> _data;

		private Dictionary<long, DrawActivityData> _hash;

		private List<long> _ids;

		private const int CAPH_ACT = 7;

		public DrawActivityData4Person DrawPreson
		{
			get
			{
				return null;
			}
		}

		public List<long> ActIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<DrawActivityData> DrawActivityDatas
		{
			get
			{
				return null;
			}
		}

		public List<DrawActivityData> SpFree10GoldDrawActivityDatas
		{
			get
			{
				return null;
			}
		}

		public void Parse(RepeatedField<ActivityInstanceProto> sAcitiviList)
		{
		}

		public DrawActivityData GetDataByID(long sID)
		{
			return null;
		}

		public bool IsDrawActivityOpen(long actID)
		{
			return false;
		}

		public bool IsDrawActivityOpen()
		{
			return false;
		}

		public bool IsFreeGold10DrawActivityOpen(long actID)
		{
			return false;
		}

		public bool IsFreeGold10DrawActivityOpen()
		{
			return false;
		}

		public long GetDrawActReplaceGoldDraw()
		{
			return 0L;
		}

		public long GetDrawActFreeGoldTenDraw()
		{
			return 0L;
		}

		public long GetDrawActReplaceDiamondDraw()
		{
			return 0L;
		}

		public void Dispose()
		{
		}
	}
}
