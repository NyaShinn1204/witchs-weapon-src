using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class SeetlementWatchmenUI : UIPanelSingle
	{
		public BarBase expBar;

		public UILabel nameLabel;

		public UISprite photo;

		public UISprite rankIcon;

		public UISprite rare;

		public GameObject[] starArray;

		public Transform levelUpAnim;

		public UILabel expAddLabel;

		public GameObject hired;

		public GameObject normal;

		private SeetlementWatchmenUIData headData;

		protected override void Start()
		{
		}

		public void Init(SeetlementWatchmenUIData data)
		{
		}

		public void PlayExpAnim()
		{
		}

		private void ValueChange(BarBase bar)
		{
		}

		private void LevelUp(BarBase bar)
		{
		}
	}
}
