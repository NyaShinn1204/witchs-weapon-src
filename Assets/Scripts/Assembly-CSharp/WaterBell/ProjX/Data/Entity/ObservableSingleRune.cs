using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableSingleRune : PropertyChangeedObservable
	{
		private long id;

		private long kindId;

		private int level;

		private long exp;

		private List<int> randomAttrTypes;

		private List<int> randomAttrValues;

		private int levelMax;

		private bool isLock;

		private int breakCount;

		private int promote;

		private long suit;

		private long svID;

		private int inSvSlotIndex;

		private List<int> innerAttrTypes;

		private List<int> innerAttrValues;

		public long SvID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int InSvSlotIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<int> RandomAttrTypes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<int> RandomAttrValues
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LevelMax
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

		public int BreakCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Promote
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long Exp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long RuneId
		{
			get
			{
				return 0L;
			}
		}

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long ID
		{
			get
			{
				return 0L;
			}
		}

		public long KindId
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public List<int> InnerAttrTypes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<int> InnerAttrValues
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
