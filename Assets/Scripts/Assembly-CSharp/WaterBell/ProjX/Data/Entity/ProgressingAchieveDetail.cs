using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ProgressingAchieveDetail
	{
		private long headID;

		private long currentID;

		private int achieveType;

		private List<string> args;

		private int status;

		private string icon;

		private string name;

		private string achievementDescription;

		private string descriptionIcon;

		private string tips;

		private int limit1;

		private int limit2;

		private long limit3;

		private List<DrawResultData> rewards;

		public string Icon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AchievementDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Tips
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Status
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long CurrentID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long HeadID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int AchieveType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<string> Args
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ArgsToStr
		{
			get
			{
				return null;
			}
		}

		public List<DrawResultData> Rewards
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DescriptionIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Limit1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Limit2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Limit3
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public ProgressingAchieveDetail(AchievementMeta clone)
		{
		}

		public ProgressingAchieveDetail(long ID)
		{
		}

		public void SetCurrentID(long currentID)
		{
		}

		public object SetNulltoZero(object o)
		{
			return null;
		}
	}
}
