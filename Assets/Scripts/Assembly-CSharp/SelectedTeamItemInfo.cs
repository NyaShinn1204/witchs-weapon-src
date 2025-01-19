using UnityEngine;

public class SelectedTeamItemInfo : MonoBehaviour
{
	public Transform ExsitType;

	public Transform NullType;

	public ButtonEx btn;

	public UILabel level;

	public UISprite bg;

	public UISprite rank;

	public Transform star;

	public UITexture icon;

	public Transform myIconLock;

	public Transform mercenaryIconLock;

	public ServantWpIconInfo weapon;

	private SelectedServant servant;

	private void Awake()
	{
	}

	public void SetInfo(SelectedServant _sv)
	{
	}

	public void SetNull()
	{
	}

	private void SetMyInfoBase(SelectedServant _sv)
	{
	}

	private void SetMercenaryInfoBase(SelectedServant _sv)
	{
	}

	private void SetInfoBase(int _rank, int _star, int _level, long _sid)
	{
	}

	private void Click()
	{
	}
}
