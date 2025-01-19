using System.Collections.Generic;
using UnityEngine;

public class HeroInteraction : MonoBehaviour
{
	private const string HERO_INTERACTION_CFG_PATH = "UI/Data/RoleInteraction/Hero";

	private const int MULT_THRESHOLD_COUNT = 3;

	private const int IDLE_STATE_COUNT = 3;

	private const int PLAY_STATE_COUNT = 2;

	private List<HeroInteractionTriggerCFG> triggerCfgList;

	public UILabel debugText;

	[SerializeField]
	private HeroInteractionTriggerCFG.GestureSequenceTypes prevGestureSequenceType;

	[SerializeField]
	private List<GestureResult> gestureList;

	private Collider[] m_Colls;

	private Animator m_Anim;

	private bool m_MouseEnabled;

	public bool MouseEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private Animator Anim
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void GotoPlayState()
	{
	}

	public void GotoIdleState()
	{
	}

	public void Init()
	{
	}

	private void PlayIdleAnim()
	{
	}

	private void PlayPlayStateAnim()
	{
	}

	private void ShowDebug(string text, GestureResult result)
	{
	}

	private bool TryPlay(GestureResult result, HeroInteractionTriggerCFG.GestureSequenceTypes gestureSequenceType)
	{
		return false;
	}

	private void OnEnded(GestureResult result)
	{
	}

	private void OnBegan(Vector2 pos)
	{
	}

	private void OnGetGesture(GestureResult result)
	{
	}
}
