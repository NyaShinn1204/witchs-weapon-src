using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class StarPanelController : UIPanelSingle
{
	public static StarPanelController current;

	public CurrentServantStarInfoView view;

	public GameObject StarUpButton;

	public GameObject NoStarUpButton;

	public GameObject goRecoveryButton;

	private string str;

	private int MaxStarPoint;

	private Transform starupPoint;

	public UILabel hp;

	public UILabel hpNext;

	public UILabel wg;

	public UILabel wgNext;

	public UILabel wf;

	public UILabel wfNext;

	public UILabel mg;

	public UILabel mgNext;

	public UILabel mf;

	public UILabel mfNext;

	public UISprite itemIcon;

	public UISprite itemFrame;

	public UISprite itemRank;

	public UILabel itemNum;

	public UILabel itemLimit;

	public UISlider slider;

	public UILabel gold;

	public ButtonEx confirm;

	public ButtonEx cannel;

	public Transform bottom;

	private float hpValue;

	private float wgValue;

	private float wfValue;

	private float mgValue;

	private float mfValue;

	public LoadUIPanelSingle starUpSuccPanelLoader;

	public LoadUIPanelSingle getSVPieceWayPanelLoader;

	public LoadUIPanelSingle confirmPanelLoader;

	private SingleWeaponInfo weaponInfo;

	private SingleServantInfo servantInfo;

	public UILabel playerGoldValue;

	public Transform stars;

	public ButtonEx closeBtn;

	public ButtonEx addBtn;

	public UILabel titleStarName;

	public UILabel servantName;

	private new void OnEnable()
	{
	}

	private new void OnDisable()
	{
	}

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	private void SetStarIcon()
	{
	}

	private void OpenGetSVPieceWayPanel(long pieceId)
	{
	}

	public override void UpdatePanel()
	{
	}

	public void OpenConfirmPanel()
	{
	}

	public void StarUp()
	{
	}

	public void NoStarUp()
	{
	}

	private void GoRecovery()
	{
	}

	public void SetStarButton()
	{
	}

	private void SetStarProertyInfo()
	{
	}

	private void SetItemInfo()
	{
	}

	private void SetItemNeed()
	{
	}

	private void SetNeedGold()
	{
	}
}
