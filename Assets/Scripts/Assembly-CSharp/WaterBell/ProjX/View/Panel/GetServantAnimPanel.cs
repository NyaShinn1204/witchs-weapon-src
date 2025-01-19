using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GetServantAnimPanel : UIPanelSingle
	{
		public Material dissolveMat;

		public Material defaultSpriteMat;

		public Material fireBurnMat;

		public UIMixWidget photoDepthControl;

		public SpriteRenderer photo;

		public SpriteRenderer soul;

		public UITexture shadow;

		public UILabel nameLabel;

		public UILabel nameLabel2;

		public UILabel desc;

		public GameObject descContainer;

		public ButtonEx fullScreenButton;

		public ButtonEx closeButton;

		public Camera soulEffCamera;

		public PropertyRadar propertyRadar;

		public UILabel weaponName;

		public UISprite weaponRank;

		public UITexture weapon;

		public UILabel svAtkTypeLabel;

		public UISlider svAtkSlider;

		public UILabel debrisLabel;

		public UIPanelSingleContainer debrisContainer;

		private RenderTexture soulEffRT;

		private Action onCloseEvent;

		protected override void Awake()
		{
		}

		private void Update()
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

		public void AnimCallToPieces()
		{
		}

		public void AnimCallToNormal()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void PlayCV(long weaponID)
		{
		}

		public void AnimCallOpenDesc()
		{
		}

		public void AnimCallCloseDesc()
		{
		}

		public void AnimCallWaitingCloseDesc()
		{
		}
	}
}
