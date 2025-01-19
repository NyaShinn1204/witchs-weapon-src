using System.Collections.Generic;

namespace WaterBell.ProjX.Battle.Unit
{
	public class UnitStateControllerOOC
	{
		public enum CLStateOOC
		{
			stun = 1,
			imprisoned = 2,
			silence = 3,
			stoptime = 4,
			modfinypost = 5,
			tempt = 6
		}

		private List<CLStateOOC> _stateOOCArr;

		private CharacterBase _unit;

		public bool isOOC
		{
			get
			{
				return false;
			}
		}

		public List<CLStateOOC> stateOOC
		{
			get
			{
				return null;
			}
		}

		public UnitStateControllerOOC(CharacterBase sCharacterBase)
		{
		}

		public bool addState(CLStateOOC sState)
		{
			return false;
		}

		public void subState(CLStateOOC sState)
		{
		}

		private bool isCallAnimDone(CLStateOOC sState)
		{
			return false;
		}

		public void animDone()
		{
		}

		public void animDoneEnd(CLStateOOC sState)
		{
		}

		private int isCanAdd(CLStateOOC sState)
		{
			return 0;
		}

		public bool isHasOOC(CLStateOOC sState)
		{
			return false;
		}

		public int getCount(CLStateOOC sState)
		{
			return 0;
		}
	}
}
