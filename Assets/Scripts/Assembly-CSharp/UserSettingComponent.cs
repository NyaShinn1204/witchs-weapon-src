using UnityEngine;

public class UserSettingComponent : MonoBehaviour
{
	public SettingType type;

	public TweenScale anim;

	public bool isOpen;

	public static UserSettingComponent current;

	public ButtonEx btn;

	public UILabel text;

	public Transform icon;

	public UISprite idCardRemind;

	private bool UnLockBtn
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ReSet(UserSettingComponent _current = null)
	{
	}

	public UserSettingComponent GetStartCurrent()
	{
		return null;
	}

	public void Init(SettingTypeSelect _current)
	{
	}

	private void SetComponentUI()
	{
	}

	private void ClickBtn()
	{
	}

	private void AnimForward()
	{
	}

	private void AnimReverse()
	{
	}
}
