using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LoadUIPanelSingle : MonoBehaviour
	{
		public string path;

		private UIPanelSingle _uiPanelSingle;

		public UIPanelSingle uiPanelSingle
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		public UIPanelSingle GetUIPanelSingle(AssetsManager.AssetsType sType = AssetsManager.AssetsType.UIPrefab)
		{
			return null;
		}
	}
}
