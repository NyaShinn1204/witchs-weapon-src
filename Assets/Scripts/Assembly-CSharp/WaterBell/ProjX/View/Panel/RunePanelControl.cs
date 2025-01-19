using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class RunePanelControl : MonoBehaviour
	{
		public UILabel titleName;

		public ButtonEx[] runeBtn;

		private List<ServantRuneSlot> infos;

		public RuneInfo infoPanel;

		public ButtonEx mountBtn;

		public ButtonEx unloadBtn;

		public Transform runeBtns;

		public void InitUI(long _sid)
		{
		}

		private void Awake()
		{
		}

		private void SelectRuneBtn(int _index)
		{
		}

		private void Mount()
		{
		}

		private void Unload()
		{
		}
	}
}
