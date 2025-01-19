using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ButtonEx : UIButton
{
	private const float LONG_PRESS_DURATION_LIMIT = 1f;

	private const int MOVE_DISTANCE_LIMIT = 10;

	public static bool isCurrGuidingBtnTrigger;

	private static Dictionary<string, List<ButtonEx>> groupDict;

	public UIBtnType btnType;

	public UIBtnSoundType sndType;

	public string btnTypeKey;

	public bool isBtnIn3DCamera;

	public string group;

	private string btnName;

	public bool IsClickSound;

	[SerializeField]
	protected State mStateTemp;

	protected Animator m_Animator;

	protected bool isRegister;

	private Vector2 pressBeginPos;

	public List<EventDelegate> onlongPress;

	private const string PRESSED_STATE_NORMAL = "Normal";

	private const string PRESSED_STATE_PRESSED = "Pressed";

	private const string BUTTON_BG = "Bg";

	private HashSet<string> pressedSuf;

	private static readonly HashSet<string> stateNameSet;

	public string btnTypeKeyChange
	{
		set
		{
		}
	}

	public string BtnName
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnDragOut()
	{
	}

	protected override void OnHover(bool isOver)
	{
	}

	protected override void OnDragOver()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnPress(bool isPressed)
	{
	}

	private string GetPressed(string bg, bool isPressed)
	{
		return null;
	}

	private void SetPressedState(bool isPressed)
	{
	}

	private void OnLongPress()
	{
	}

	public void InvokeOnClickEvent()
	{
	}

	protected void Register()
	{
	}

	public override void SetState(State state, bool immediate)
	{
	}

	private void PlayAnimation(string animation)
	{
	}

	[DebuggerHidden]
	private IEnumerator WaitingAnimInit(string animation)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	protected override void OnClick()
	{
	}

	public void PlaySoundEff(UIBtnSoundType sType)
	{
	}

	protected void PlaySoundEff()
	{
	}
}
