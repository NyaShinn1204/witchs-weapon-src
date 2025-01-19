using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GuildJoinedPanel : UIPanelBase
	{
		public UIPanelBase[] panels;

		public ButtonEx[] tabBtns;

		public GuildInfoView view;

		public static GuildJoinedPanel current;

		public Transform memberRemind;

		private Dictionary<int, string> paths;

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void OpenGuildPanel(int index)
		{
		}

		private void AddEvent()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void SetMemberRemind()
		{
		}
	}
}
