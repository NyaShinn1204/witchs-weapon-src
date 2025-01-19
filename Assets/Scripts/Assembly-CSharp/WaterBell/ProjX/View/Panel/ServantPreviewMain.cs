using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantPreviewMain : UIPanelSingle
	{
		public UILabel nameLabel;

		public UIPanelSingleContainer imageContainer;

		public LoadUIPanelSingle spellLoader;

		public LoadUIPanelSingle propLoader;

		public PropertyServantView propView;

		public WeaponButtonItem2 weaponItem;

		private List<WeaponButtonItem2> weaponList;

		public UIGrid weaponGrid;

		public ButtonEx propButton;

		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public ButtonEx imageButton;

		public GameObject spell1;

		public GameObject spell2;

		public UIWitchSpellTipController spellTip;

		public UtilAnchorAnim anchorAnim;

		public ButtonEx buttonToMain;

		private UIPanelSingle currentOpen;

		private string currentTag;

		private List<ButtonEx> tagButtonList;

		private List<LoadUIPanelSingle> loaderList;

		[SerializeField]
		private SingleWeaponInfo weaponInfo;

		[SerializeField]
		private SingleServantInfo servantInfo;

		public static ServantPreviewMain current;

		private long Spell1ID
		{
			get
			{
				return 0L;
			}
		}

		private long Spell2ID
		{
			get
			{
				return 0L;
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void OnButtonClick(GameObject go)
		{
		}

		public void OpenChild(string child)
		{
		}

		protected override void BindData()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void OpenWeaponPanel(long weaponID)
		{
		}
	}
}
