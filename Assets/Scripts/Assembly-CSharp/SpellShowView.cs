using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class SpellShowView : UIPanelSingle
{
	public ButtonEx spell1Btn;

	public ButtonEx spell2Btn;

	public UISprite image1;

	public UISprite image2;

	public Transform imageSelectBg1;

	public Transform imageSelectBg2;

	public UIScrollView textScroll;

	public UILabel _name;

	public UILabel _spellText;

	public static SpellShowView current;

	private int RANK;

	private string Text1;

	private string Text2;

	private const int SPELL1 = 1;

	private const int SPELL2 = 2;

	private long spellID1
	{
		get
		{
			return 0L;
		}
	}

	private long spellID2
	{
		get
		{
			return 0L;
		}
	}

	public override void UpdatePanel()
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

	private void ShowSpellInfo(long spellID, int type)
	{
	}

	private void ClickSpell1()
	{
	}

	private void ClickSpell2()
	{
	}

	private void AddEvent()
	{
	}
}
