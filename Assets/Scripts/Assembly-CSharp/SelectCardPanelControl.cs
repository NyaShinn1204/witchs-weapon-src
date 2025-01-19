using UnityEngine;
using WaterBell.ProjX.Playmode;
using WaterBell.ProjX.View.Panel;

public class SelectCardPanelControl : UIPanelBase
{
	public ButtonEx ReturnBtn;

	public ButtonEx FightingBtn;

	public ButtonEx DisFightingBtn;

	public ButtonEx ClothBtn;

	public ButtonEx OpenPropertyBtn;

	public ButtonEx ClosePropertyBtn;

	public Transform[] servantBoxs;

	public Transform[] weaponBoxs;

	public UILabel titleLabel;

	public UILabel hpText;

	public UISprite slider;

	public UILabel fightingText;

	public static SelectCardPanelControl current;

	public IPlayMode currentMode;

	private GameObject servantPrefab;

	public LoadUIPanelSingle clothLoader;

	public Transform selectedView;

	public Transform selectingView;

	public SelectProperty property;

	public long[] selectSvs;

	public long[] selectWps;

	public long[] selectRids;

	public int[] selectEnergys;

	private int totalHp;

	private int totalFighting;

	private int limitHp;

	private int nowHp;

	protected override void Awake()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void AddEvent()
	{
	}

	private bool IsUsed(long servantID)
	{
		return false;
	}

	private void SetFightingBtnUI()
	{
	}

	private void DisFighting()
	{
	}
}
