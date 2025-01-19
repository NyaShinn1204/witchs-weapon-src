using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class Achievement : PropertyChangeedObservable
	{
		private List<AchievementJob> achieveJob;

		private List<AchievementMeta> progressingAchieve;

		public List<AchievementJob> AchieveJob
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void UpdateAchievements(List<AchievementJob> finishAchieve, List<AchievementMeta> progressingAchieve)
		{
		}

		public int GetAchieveJobLength()
		{
			return 0;
		}

		public int GetProgressingAchieveLength()
		{
			return 0;
		}

		public AchievementJob GetAchieveJobByIndex(int i)
		{
			return null;
		}

		public AchievementJob GetAchieveJobByID(long ID)
		{
			return null;
		}

		public AchievementMeta GetProgressingAchieveByIndex(int i)
		{
			return null;
		}

		public AchievementMeta GetProgressingAchieveByID(long ID)
		{
			return null;
		}

		public void FinishAchievement(string id)
		{
		}

		public void ChangeAchievement(List<AchievementJob> AchieveJob, List<AchievementMeta> AchieveMeta)
		{
		}

		public bool IsAchievementUnFinished(long AchieveID)
		{
			return false;
		}

		public bool IsQuestFinished(long questID)
		{
			return false;
		}

		public bool IsAchievementFinished(long AchieveID)
		{
			return false;
		}

		public void Dispose()
		{
		}
	}
}
