using System.Collections.ObjectModel;
using Achievemod;

namespace WaterBell.ProjX.Data.Entity
{
	public class Quest
	{
		private ObservableCollection<ObservableJob> questJob;

		private ObservableCollection<ObservableMetaInfo> questMeta;

		private P<bool> haveNewDailyQuestReceive;

		private P<bool> haveNewMainStoryQuestReceive;

		private P<bool> haveNewFavQuestReceive;

		private P<bool> haveNewGuideQuestReceive;

		private P<bool> haveNewAPQuestReceive;

		private P<bool> haveNewApDailyQuestReceive;

		private P<bool> haveGuideQuestInProgressReceive;

		public P<bool> HaveNewDailyQuestReceive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public P<bool> HaveNewMainStoryQuestReceive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public P<bool> HaveNewFavQuestReceive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public P<bool> HaveNewGuideQuestReceive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public P<bool> HaveNewAPQuestReceive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public P<bool> HaveNewApDailyQuestReceive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public P<bool> HaveGuideQuestInProgressReceive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObservableCollection<ObservableJob> QuestJob
		{
			get
			{
				return null;
			}
		}

		public ObservableCollection<ObservableMetaInfo> QuestMeta
		{
			get
			{
				return null;
			}
		}

		public void UpdateQuest(Result quests)
		{
		}

		private void UpdateNewFavQuest()
		{
		}

		private void UpdateNewDailyQuest()
		{
		}

		private void UpdateNewMainStoryQuest()
		{
		}

		private void UpdateNewAPDailyQuest()
		{
		}

		private void UpdateNewAPQuest()
		{
		}

		private void UpdateNewGuideQuest()
		{
		}

		public ObservableJob GetJobByID(long ID)
		{
			return null;
		}

		public ObservableMetaInfo GetMetaByID(long ID)
		{
			return null;
		}

		public void ChangeQuest(Result quests)
		{
		}

		private void UpdateFinishQuest(Result quests)
		{
		}

		private void UpdateQuestInProgress(Result quests)
		{
		}

		public void Dispose()
		{
		}
	}
}
