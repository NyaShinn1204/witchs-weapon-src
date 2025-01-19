using NodeCanvas.Framework;
using WaterBell.ProjX.Battle.Unit;

namespace NodeCanvas.Tasks.Actions
{
	public class CompareNonValueNode : ConditionTask
	{
		public const int CHECK_TYPE_CONTROLL_STATUS = 1;

		public const int CHECK_TYPE_OTHER_STATUS = 2;

		public const int CHECK_TYPE_BUFF_BY_ID = 3;

		public const int CHECK_TYPE_BUFF_BY_TYPE = 4;

		public const int CHECK_TYPE_SKILL_CASTIRNG = 5;

		private Entity entity;

		public int targetType;

		public float targetArgu1;

		public float targetArgu2;

		public float targetArgu3;

		public float targetArgu4;

		public float targetArgu5;

		public int checkStautsType;

		public UnitStateControllerOOC.CLStateOOC controllStatus;

		public bool controllStatusExist;

		public int otherStatus;

		public bool otherStatusExist;

		public string buffID;

		public string skillID;

		public bool isPositiveBuff;

		protected override bool OnCheck()
		{
			return false;
		}

		private bool CheckControllStatus(UnitStateControllerOOC.CLStateOOC index, Target target)
		{
			return false;
		}

		private bool CheckOtherStatus(int index)
		{
			return false;
		}

		private bool CheckBuffExist(long buffId)
		{
			return false;
		}

		private bool CheckTargetBuffExist(bool isActive)
		{
			return false;
		}

		private bool CheckSKillCasting(long skillID)
		{
			return false;
		}
	}
}
