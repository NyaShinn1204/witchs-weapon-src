using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class WGUStarUp : UIPanelSingle
	{
		private WGUStarUpData sData;

		[Space]
		public GameObject star;

		[Space]
		public UILabel SMCZ;

		public UILabel WGCZ;

		public UILabel WFCZ;

		public UILabel MGCZ;

		public UILabel MFCZ;

		public UILabel love;

		[Space]
		public UILabel hp;

		public UILabel wg;

		public UILabel wf;

		public UILabel mg;

		public UILabel mf;

		public override void UpdatePanel()
		{
		}
	}
}
