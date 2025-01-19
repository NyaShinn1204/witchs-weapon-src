using System;
using System.Collections.Generic;
using Apmod;
using Cscmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class Expedition
	{
		protected List<RankData> rankDatas;

		private PropertyChangeedObservable indexChange;

		private PropertyChangeedObservable enterCountChange;

		private PropertyChangeedObservable isOpenChange;

		private PropertyChangeedObservable expeditionServantChange;

		private PropertyChangeedObservable expeditionInfoChange;

		private PropertyChangeedObservable HPChange;

		private bool isOpen;

		private int index;

		private int enterCount;

		private int hp;

		private List<ExpeditionServant> expeditionServantInfo;

		private List<ExpeditionNode> expeditionInfo;

		public int CurEnemyRoleLevel { get; set; }

		public List<long> ServantCardIDGroup { get; set; }

		public List<long> MercenaryCardIDGroup { get; set; }

		public List<long> FashionCardIDs { get; set; }

		public List<ExpeditionNode> ExpeditionInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Hp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int EnterCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<ExpeditionServant> ExpeditionServantInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<RankData> GetRankData()
		{
			return null;
		}

		public RankData GetRankDataByType(int type)
		{
			return null;
		}

		public void SetRankDatas(RankDatas rawData)
		{
		}

		public void MoveIndexToNext()
		{
		}

		public void UpdateExpeditionByProtoBuf(CscInstance cscInfo)
		{
		}

		public void UpdateExpedition(List<ExpeditionNode> ExpeditionInfo, List<ExpeditionServant> ExpeditionServantInfo, int Index, int EnterCount, int hp, List<long> ServantCardIDGroup, List<long> MercenaryCardIDGroup, List<long> fashions, int CurEnemyRoleLevel)
		{
		}

		public void UpdateExpeditionServantInfo(ExpeditionServant expeditionServant)
		{
		}

		public ExpeditionNode GetExpeditionNode(ulong ID)
		{
			return null;
		}

		public string GetCurrentLevelID()
		{
			return null;
		}

		public void Reset2InitWithoutNodes()
		{
		}

		public void SubscribeIndexChange(Action<PropertyChangeedObservable> action)
		{
		}

		public void SubscribeIsOpenChange(Action<PropertyChangeedObservable> action)
		{
		}

		public void SubscribeExpeditionServantChange(Action<PropertyChangeedObservable> action)
		{
		}

		public void SubscribeExpeditionInfoChange(Action<PropertyChangeedObservable> action)
		{
		}

		public void SubscribeEnterCountChange(Action<PropertyChangeedObservable> action)
		{
		}

		public void SubscribeHPChange(Action<PropertyChangeedObservable> action)
		{
		}

		public void Dispose()
		{
		}
	}
}
