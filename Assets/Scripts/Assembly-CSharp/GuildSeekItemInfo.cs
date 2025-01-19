using UnityEngine;

public class GuildSeekItemInfo : MonoBehaviour
{
	public UILabel Name;

	public Transform IconWidget;

	public UILabel FightingValue;

	public UILabel NumberValue;

	public Transform SelectIcon;

	public Transform LockIcon;

	public Transform requestIcon;

	public ButtonEx Btn;

	public UILabel timeValue;

	public Transform fighting;

	public Transform time;

	public Transform number;

	private GameObject go;

	private long requestTime;

	public static GuildSeekItemInfo current;

	private GuildSimple data;

	private string id;

	private bool isRequestItem;

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

	public void SetInfo(GuildSimple info, int _type)
	{
	}

	private void ShowRemainTime()
	{
	}

	private void OnDisable()
	{
	}
}
