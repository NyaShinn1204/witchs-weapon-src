using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GuideScenePanel : UIPanelSingle
	{
		public GameObject newNameContainer;

		public UIInput newNameInput;

		public UIButton newNameConfirmBtn;

		private static GuideScenePanel current;

		private string nickName;

		protected override void Awake()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public static void ShowNewNamePanel()
		{
		}

		private void OnInputNamestring()
		{
		}

		private void OnClickNewRoleConfirmBtn()
		{
		}

		private void OnRenameFail(string err)
		{
		}

		private void SyncGuide()
		{
		}

		private void OnSyncSucc()
		{
		}
	}
}
