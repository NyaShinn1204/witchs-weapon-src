using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class SelectActivityAdvance : UIPanelBase
{
	public Transform buffIcons;

	public Transform lockIcons;

	public Transform mode3Servants;

	public ButtonEx closePanelBtn;

	public UILabel buffAdvanceText;

	public UISprite buffAdvanceNumber;

	public UILabel vipAdvanceText;

	public Transform vipIcon;

	public GameObject vipLock;

	public Transform ActivityPlayMode1;

	public Transform ActivityPlayMode3;

	public Transform mode1Servants;

	public Transform remind1;

	public Transform remind2;

	public UIScrollView scroll;

	public UIScrollBar bar;

	public Transform propertys;

	protected override void Awake()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void Init()
	{
	}

	private void SetProperty()
	{
	}

	private int[] GetDatas(int _level, int _type)
	{
		return null;
	}

	private void SetBuff()
	{
	}

	private void SetServant(Transform _parent)
	{
	}

	private void SetVip()
	{
	}

	private bool IsAction(long _sid, long _rid)
	{
		return false;
	}
}
