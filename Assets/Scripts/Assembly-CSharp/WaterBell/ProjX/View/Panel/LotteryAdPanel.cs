using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LotteryAdPanel : UIPanelSingle
	{
		public GameObject content;

		public GameObject servantContent;

		public GameObject servantContentTop;

		public UITexture servantTex;

		public UITexture servantTexTop;

		public GameObject objSSR;

		public GameObject objSR;

		public UISprite loaderSSR;

		public UISprite loaderSR;

		public UITexture loaderIcon;

		public GameObject objIcon;

		private List<long> listServant;

		private List<long> listSSRID;

		private List<long> listSRID;

		private int indexIcon;

		private int indexSSRID;

		private int indexSRID;

		private float curTime;

		private float loopTime;

		private string path;

		private string pathIcon;

		private string tempStr;

		private AssetsManager.AssetsType assetsType;

		public override void UpdatePanel()
		{
		}

		private void Click(GameObject obj)
		{
		}

		private new void Start()
		{
		}

		public void OpenPanel(DrawInfo drawInfo)
		{
		}

		private Texture GetIconTexture(int index)
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
