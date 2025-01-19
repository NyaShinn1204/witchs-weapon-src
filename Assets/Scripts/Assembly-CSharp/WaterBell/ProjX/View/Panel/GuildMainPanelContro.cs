using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GuildMainPanelContro : UIAnimationPanelBase
	{
		private GuildRequestPanel requestPanel;

		private GuildJoinedPanel joinedPanel;

		public static GuildMainPanelContro current;

		public ButtonEx returnBtn;

		private GameObject RequestPanel;

		private GameObject JoinedPanel;

		public ButtonEx helpBtn;

		private GuildStateEnum state
		{
			get
			{
				return default(GuildStateEnum);
			}
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void ClickBack()
		{
		}

		public void Init()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void Return()
		{
		}
	}
}
