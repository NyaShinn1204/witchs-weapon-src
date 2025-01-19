using Actionmod;
using Apmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class R5BaseData
	{
		private R5RoundData commonRound;

		private R5RoundData finalRound;

		private bool finalUnlock;

		public R5RoundData CommonRound
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public R5RoundData FinalRound
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool FinalUnlock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public R5BaseData(Apmod.R5BaseData r5BaseData)
		{
		}

		public R5BaseData(R5BaseDataExtra r5BaseData)
		{
		}
	}
}
