using UnityEngine;

public class GuildMemberItemInfo : MonoBehaviour
{
	public UILabel Name;

	public UILabel Lv;

	public Transform IconWidget;

	public ButtonEx Btn;

	public Transform SelectIcon;

	public Transform MemberType;

	public UILabel PrivilegeText;

	public UILabel LoginTime;

	public Transform DismisstIcon;

	public UILabel DismissTime;

	public Transform CanDismissIcon;

	public Transform RequestType;

	public UILabel FightingValue;

	public UILabel TimeValue;

	public static GuildMemberItemInfo current;

	public GuildMember memberData;

	private RequestMember requestData;

	private long id;

	private GameObject IconPrefab;

	private void Awake()
	{
	}

	public void ItemClick()
	{
	}

	private void Select()
	{
	}

	public void DisSelect()
	{
	}

	public void SetInfo(GuildMember info)
	{
	}

	public void SetInfo(RequestMember info)
	{
	}

	private void StartUpdateTime()
	{
	}

	private void GetRecalMemberTime()
	{
	}

	private void SetIcon(long _head, long headBox)
	{
	}
}
