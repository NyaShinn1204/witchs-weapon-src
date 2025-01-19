using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
	private Animator _animator;

	public float animMoveRate;

	public const string S_STATE = "state";

	private bool _isStart;

	private bool _isFirst;

	private bool _isDone;

	private int _frame;

	private float _time;

	private List<TypeCsvViewFI> _csvFI;

	private AniEvent _aniEvent;

	public string animLabel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetSpeedStandard(float rate)
	{
	}

	protected virtual void Awake()
	{
	}

	private void Start()
	{
	}

	public void FakeStart()
	{
	}

	public void FreePlay()
	{
	}

	public void ReplayAnima(string anima, bool immediately2play = false)
	{
	}

	public void SetAnimatorState(int anima)
	{
	}

	public void PlayAnima(string anima, float time = 0f)
	{
	}

	private void Update()
	{
	}

	private void eventFI(float sDelta)
	{
	}

	private void doneFI()
	{
	}

	private void ResetFI(string sName, float sTime)
	{
	}
}
