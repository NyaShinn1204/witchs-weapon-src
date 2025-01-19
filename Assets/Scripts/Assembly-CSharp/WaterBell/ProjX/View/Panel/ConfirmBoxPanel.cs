using UnityEngine;
using UnityEngine.Events;

namespace WaterBell.ProjX.View.Panel
{
	public class ConfirmBoxPanel : UIPanelSingle
	{
		[Space]
		public UILabel titleLabel;

		public UILabel descriptionLabel;

		[Space]
		public UnityEvent OnConfirm;

		public UnityEvent OnCancel;

		public void OpenPanel(string title, string description)
		{
		}

		public void Confirm()
		{
		}

		public void Cancel()
		{
		}
	}
}
