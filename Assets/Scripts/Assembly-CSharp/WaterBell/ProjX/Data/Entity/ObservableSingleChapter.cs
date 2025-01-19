using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableSingleChapter : PropertyChangeedObservable
	{
		private long _ID;

		private int count;

		private bool isLock;

		private List<ObservableSingleLevel> levels;

		public long ID
		{
			get
			{
				return 0L;
			}
		}

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsLock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<ObservableSingleLevel> Levels
		{
			get
			{
				return null;
			}
		}

		public ObservableSingleChapter()
		{
		}

		public ObservableSingleChapter(long id, int count, bool isLock, List<Progress.SingleProgress.Level> lvs)
		{
		}

		public void UpdateChapters(Progress.SingleProgress p)
		{
		}
	}
}
