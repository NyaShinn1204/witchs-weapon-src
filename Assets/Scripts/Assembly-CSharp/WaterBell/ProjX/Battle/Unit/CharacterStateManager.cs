namespace WaterBell.ProjX.Battle.Unit
{
	public class CharacterStateManager
	{
		private static readonly int StateMainNum_Base;

		private static readonly int StateSubNum_Base;

		private static readonly int SkipAction_Flag;

		private static readonly int OOCAction_Flag;

		private static readonly int FreeMoveAction_Flag;

		private static readonly int StandByAction_Flag;

		private static readonly int Dead_Flag;

		private static readonly int Attacking_Flag;

		public UnitStateControllerOOC stateMngrOOC;

		private CLState state;

		private int stateMainNum;

		private int stateSubNum;

		private bool isPaused;

		private bool _isSkipped;

		private bool isInCallBackEventTimeSlot;

		public bool isBuffRelife;

		public bool isSkipped
		{
			get
			{
				return false;
			}
		}

		public void ResetDefaultState4Player()
		{
		}

		public CLState GetCurrLogicState()
		{
			return default(CLState);
		}

		public void OpenCallBackEventTimeSlot()
		{
		}

		public void CloseCallBackEventTimeSlot()
		{
		}

		public void SetCurrLogicState(CLState newState)
		{
		}

		public void SetPauseState(bool pauseState)
		{
		}

		public bool IsPaused()
		{
			return false;
		}

		public bool IsDead()
		{
			return false;
		}

		public bool IsRelife()
		{
			return false;
		}

		public bool IsStuned()
		{
			return false;
		}

		public bool IsSilenced()
		{
			return false;
		}

		public bool IsImprisoned()
		{
			return false;
		}

		private bool IsStopTime()
		{
			return false;
		}

		private bool IsModfinyPost()
		{
			return false;
		}

		private bool IsBeCatch()
		{
			return false;
		}

		private bool IsPostPull()
		{
			return false;
		}

		public bool IsFlying()
		{
			return false;
		}

		public bool IsInIgnoreOtherAction()
		{
			return false;
		}

		public bool IsActing()
		{
			return false;
		}

		public bool IsInMove()
		{
			return false;
		}

		public bool IsAllow2TakePlayerCMDNow()
		{
			return false;
		}

		public bool IsAllow2TakeAnyActionNow()
		{
			return false;
		}

		public bool IsInFreeTime()
		{
			return false;
		}

		public bool IsInFreeMove()
		{
			return false;
		}

		public bool IsInOOC()
		{
			return false;
		}

		public bool IsInSkillTimeWithOutMoveing()
		{
			return false;
		}

		public bool IsInSkillTime()
		{
			return false;
		}

		public bool IsForbidSwapWeapon()
		{
			return false;
		}

		public int GetStunedCounter()
		{
			return 0;
		}
	}
}
