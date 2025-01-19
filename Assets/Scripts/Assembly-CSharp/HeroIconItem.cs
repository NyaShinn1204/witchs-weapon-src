using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class HeroIconItem : MonoBehaviour
{
	public static HeroIconItem current;

	public ButtonEx btn;

	public UISprite frame;

	public UISprite icon;

	public Transform selectBg;

	public Transform lockSprite;

	public long Id;

	public string Name;

	public string Desc;

	private string Resource;

	private bool Unlock;

	private bool iconUnlock;

	private bool frameUnlock;

	private ChangeHeadIcon.TabState myState;

	private void Awake()
	{
	}

	public void Change()
	{
	}

	public void SetInfo(HeadIcon _info, long _mainID)
	{
	}

	public void SetInfo(HeadIconBox _info, long _mainID)
	{
	}

	private void SetData(long _id, string _name, bool _unlock, string _resource, long _mainID)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void SetSelectItem()
	{
	}
}
