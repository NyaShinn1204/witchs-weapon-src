using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class Progress
	{
		public class SingleProgress
		{
			public class Level
			{
				private long _ID;

				private bool pass;

				private int stars;

				private int battleCount;

				private int resetCount;

				private int status;

				private bool canSweep;

				public long ID
				{
					get
					{
						return 0L;
					}
				}

				public bool Pass
				{
					get
					{
						return false;
					}
					set
					{
					}
				}

				public int Stars
				{
					get
					{
						return 0;
					}
				}

				public int BattleCount
				{
					get
					{
						return 0;
					}
					set
					{
					}
				}

				public int ResetCount
				{
					get
					{
						return 0;
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

				public bool CanSweep
				{
					get
					{
						return false;
					}
					set
					{
					}
				}

				public Level()
				{
				}

				public Level(Level clone)
				{
				}

				public Level(object[] arguments)
				{
				}

				public Level(long arg)
				{
				}
			}

			public class Chapter
			{
				private ulong _ID;

				private int chapterCount;

				public long ID
				{
					get
					{
						return 0L;
					}
				}

				public int ChapterCount
				{
					get
					{
						return 0;
					}
					set
					{
					}
				}

				public Chapter()
				{
				}

				public Chapter(Chapter clone)
				{
				}

				public Chapter(object[] arguments)
				{
				}

				public int Reset(object[] arguments)
				{
					return 0;
				}
			}

			private List<Level> levelData;

			private Chapter chapterData;

			public SingleProgress()
			{
			}

			public SingleProgress(SingleProgress clone)
			{
			}

			public SingleProgress(List<Level> cloneL, Chapter cloneC)
			{
			}

			public int Reset(List<Level> cloneL, Chapter cloneC)
			{
				return 0;
			}

			public int GetLength()
			{
				return 0;
			}

			public Chapter GetChapter()
			{
				return null;
			}

			public Level GetLevel(int i)
			{
				return null;
			}

			public Level GetLevelByID(long ID)
			{
				return null;
			}

			public List<Level> GetLevels()
			{
				return null;
			}
		}

		public Dictionary<int, long> viewHistoryLevelDict;

		private Dictionary<int, List<ObservableSingleChapter>> _hashObservable;

		private Dictionary<long, List<ObservableSingleChapter>> _hashObservableDaily;

		private Dictionary<long, ObservableSingleChapter> _hash;

		private P<long> newUnlockMainLevel;

		private P<int> setWeaoponTime;

		public long NewClearStoryLineInstance { get; set; }

		public long TargetWeapon { get; set; }

		public P<long> ObservableNewUnlockMainLevel
		{
			get
			{
				return null;
			}
		}

		public P<int> ObservableSetWeaoponTime
		{
			get
			{
				return null;
			}
		}

		public void UpdateProgress(List<SingleProgress> clone, int MaterialLootTimes)
		{
		}

		public void UpdateNewUnLockMainLevel()
		{
		}

		private long FindNewUnlockMainLevel(ObservableSingleChapter chapter)
		{
			return 0L;
		}

		public long GetNewClearStoryLineInstance()
		{
			return 0L;
		}

		public List<ObservableSingleChapter> GetObservableMainChapters()
		{
			return null;
		}

		public List<ObservableSingleChapter> GetObservableDailyChapters()
		{
			return null;
		}

		public List<ObservableSingleChapter> GetObservableWeaponDailyChapters()
		{
			return null;
		}

		public List<ObservableSingleChapter> GetObservableActivityProgressChapters()
		{
			return null;
		}

		public List<ObservableSingleChapter> GetObservableChaptersByType(int sType)
		{
			return null;
		}

		public ObservableSingleChapter GetProgressByChapterID(long id)
		{
			return null;
		}

		public ObservableSingleLevel GetLevelByID(long id)
		{
			return null;
		}

		private void InitProgress()
		{
		}

		public void ResetBattleCountAndResetCountAll()
		{
		}

		public void ResetBattleCountByID(long id)
		{
		}

		public void Dispose()
		{
		}
	}
}
