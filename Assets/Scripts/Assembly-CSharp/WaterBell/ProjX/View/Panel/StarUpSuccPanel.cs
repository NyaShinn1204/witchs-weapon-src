using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class StarUpSuccPanel : UIPanelSingle
	{
		public GameObject[] prevStars;

		public GameObject[] currentStars;

		public ButtonEx closeButton;

		public UILabel hp_b;

		public UILabel hp_f;

		public UILabel wg_b;

		public UILabel wg_f;

		public UILabel wf_b;

		public UILabel wf_f;

		public UILabel mg_b;

		public UILabel mg_f;

		public UILabel mf_b;

		public UILabel mf_f;

		public GameObject effSource;

		private GameObject eff;

		private UIPanel panel;

		private Action OnClickEvent;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public void OpenPanel(long servantId, int level, float _hpBefore, float _hpAfter, float _wgBefore, float _wgAfter, float _wfBefore, float _wfAfter, float mgBefore, float mgAfter, float mfBefore, float mfAfter, Action OnClickEvent = null)
		{
		}

		public void OpenPanel(Action onCloseEvent = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
