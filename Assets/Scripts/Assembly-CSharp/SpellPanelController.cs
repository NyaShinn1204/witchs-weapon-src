using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class SpellPanelController : UIPanelSingle
{
	public static SpellPanelController current;

	public ButtonEx spell1Btn;

	public ButtonEx spell2Btn;

	public UISprite image1;

	public UISprite image2;

	public Transform imageLock1;

	public Transform imageLock2;

	public Transform imageSelectBg1;

	public Transform imageSelectBg2;

	public UIScrollView textScroll;

	public UILabel _name;

	public UILabel _nameLock;

	public Transform _title;

	public Transform _titleLock;

	public UISprite _rank;

	public UILabel _spellText;

	private string LOCK;

	private int RANK;

	private string Text1;

	private string Text2;

	private long spell_id;

	public SingleServantSPellsView view;

	public UILabel SpellLockNeedRankText;

	public GameObject SpellLockNeedRankIcon;

	private SingleWeaponInfo weaponInfo;

	private SingleServantInfo servantInfo;

	private Spell _Spell1
	{
		get
		{
			return null;
		}
	}

	private Spell _Spell2
	{
		get
		{
			return null;
		}
	}

	private new void OnEnable()
	{
	}

	private new void OnDisable()
	{
	}

	public override void UpdatePanel()
	{
	}

	protected override void AddConfigItem()
	{
	}

	public void Init()
	{
	}

	private void ShowSpell1()
	{
	}

	private void ShowSpell2()
	{
	}

	private void ShowSpellInfo(Spell _info)
	{
	}

	private void ClickSpell1()
	{
	}

	private void ClickSpell2()
	{
	}

	private bool SpellIsLock(Spell _info)
	{
		return false;
	}

	private void AddEvent()
	{
	}
}
