using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AP5_ExchangePanel : UIPanelSingle
	{
		public const int NEED_COUNT = 2;

		public UIPanelSingleContainer src;

		public UIPanelSingleContainer dest;

		public ButtonEx confirmButton;

		public ButtonEx cancelButton;

		public GameObject step1;

		public GameObject step2;

		public UITable destTable;

		public UILabel Activity5Combination1;

		public UILabel Activity5Combination2;

		public UILabel Activity5Combination3;

		public UILabel Activity5Combination4;

		public UILabel Activity5Combination42;

		private AP5_ExchangeKey srcKeySelect;

		private AP5_ExchangeKey destKeySelect;

		private ApRule5View apRule5View;

		private Action onCloseEvent;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void OpenPanel(Action onClose, UIDataBase data = null)
		{
		}

		public void OnChangeFinished()
		{
		}

		private void GotoInitState()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void OnDestItemClick(AP5_ExchangeKey key)
		{
		}

		private void OnSrcItemClick(AP5_ExchangeKey key)
		{
		}

		private List<AP5_ExchangeKeyData> ConvertData(List<AP5_KeyData> sourceList)
		{
			return null;
		}
	}
}
