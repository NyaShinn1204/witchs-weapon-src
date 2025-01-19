using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GetWeaponAnimPanel : UIPanelSingle
	{
		public Material dissolveMat;

		public Material defaultSpriteMat;

		public UIMixWidget photoDepthControl;

		public GameObject photoContent;

		public SpriteRenderer photo;

		public SpriteRenderer soul;

		public ButtonEx closeButton;

		public ButtonEx directShowResultButton;

		public UILabel nameLabel;

		public UILabel descLabel;

		public Transform rareEffect;

		public Transform rareIconEffect;

		public GameObject rEffect1;

		public GameObject srEffect1;

		public GameObject srEffect2;

		public GameObject ssrEffect1;

		public GameObject ssrEffect2;

		public UILabel debrisLabel;

		public UIPanelSingleContainer debrisContainer;

		public Camera soulEffCamera;

		private TypeCsvServantWeapon weaponTabelData;

		private RenderTexture soulEffRT;

		private Action onCloseEvent;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		protected override void AddConfigItem()
		{
		}

		public void OpenPanel(LotteryLootData lootData, Action onCloseEvent)
		{
		}

		private void DirectShowResult()
		{
		}

		private void ShowSSR()
		{
		}

		private void ShowSR()
		{
		}

		private void PlayResult()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void PlayRareTextSound()
		{
		}

		public void AnimCallUpdatePhotoDepth()
		{
		}

		public void AnimCallToPieces()
		{
		}

		public void PlayRareImageSound()
		{
		}
	}
}
