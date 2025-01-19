using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class MyServantsInfo : MonoBehaviour
	{
		public UILabel Level;

		public Transform star;

		public Transform rank;

		public UILabel Name;

		public UISprite SVIcon;

		public UISprite SVRankBg;

		public UISprite WPIcon;

		public UISprite WPRankBg;

		public UISprite WPType;

		public UISprite WPRare;

		public ButtonEx WeaponBtn;

		public ButtonEx Btn;

		public Transform selectIcon;

		private long servantID;

		private long weaponID;

		public static MyServantsInfo current;

		private SelectMercenarySvControl.SelectMercenary MyState;

		private long sID;

		private long rID;

		private long addTime;

		private bool canClick;

		private void Awake()
		{
		}

		private void WeaponClick()
		{
		}

		public void SaveIDS(long wp)
		{
		}

		public void SetInfo(GuildMercenarySv _servant, long wpID, SelectMercenarySvControl.SelectMercenary myState, bool isClick)
		{
		}

		private void SetInfoBase(long svID, long wpID, int level, int rank, int star, SelectMercenarySvControl.SelectMercenary myStat, bool isClick)
		{
		}

		private void ServantOnClick(SelectMercenarySvControl.SelectMercenary myStat)
		{
		}

		public void SelectedUI()
		{
		}

		public void unSelectedUI()
		{
		}

		private void SetRank(int level)
		{
		}

		private void SetStar(int level)
		{
		}
	}
}
