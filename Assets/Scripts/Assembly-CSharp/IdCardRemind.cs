using UnityEngine;

public class IdCardRemind : MonoBehaviour
{
	private enum UserType
	{
		UnBind = 0,
		Bind = 1
	}

	public UILabel remindText;

	public ButtonEx GoBindBtn;

	public ButtonEx CannelBtn;

	public ButtonEx ConfirmBtn;

	private UserType currentType;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void GoCheck()
	{
	}

	public void CheckSuccessfulCallBack()
	{
	}
}
