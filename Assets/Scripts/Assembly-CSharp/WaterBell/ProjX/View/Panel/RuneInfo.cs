using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class RuneInfo : MonoBehaviour
	{
		public ButtonEx advanceBtn;

		public ButtonEx changeBtn;

		public UILabel title;

		private long runeID;

		private RuneInfoDetail detail;

		public void ShowInfo(ServantRuneSlot _info)
		{
		}

		private void Awake()
		{
		}
	}
}
