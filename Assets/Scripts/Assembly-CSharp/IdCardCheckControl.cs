using System;
using UnityEngine;

public class IdCardCheckControl : MonoBehaviour
{
	private enum WindowType
	{
		GuestCheckRemind = 0,
		UserCheckRemind = 1,
		GuestBindRemind = 2,
		GuestCheckIdCard = 3,
		UserCheckIdCard = 4
	}

	private const string path = "UI/Prefab/UserSetting/IdCardCheckPanel";

	private static IdCardCheckControl instance;

	private IdCardRemind RemindPanel;

	private BindCheck BindCheckPanel;

	private UnBindCheck UnBindCheckPanel;

	public ModelCollection<DrawResultData> loot;

	public ModelCollection<DrawResultData> weapon;

	public Action action;

	public static IdCardCheckControl GetInstance()
	{
		return null;
	}

	private void Init()
	{
	}

	public void OpenIdCardRemindPanel(Action _action)
	{
	}

	public void OpenBindCheckPanel()
	{
	}

	public void OpenUnBindCheckPanel()
	{
	}

	public void CheckSuccessful()
	{
	}

	public void ClosePanel()
	{
	}
}
