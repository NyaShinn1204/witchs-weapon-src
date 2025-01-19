using UnityEngine;

public class PauseScreen : MonoBehaviour
{
	public UISprite soundIcon;

	public GameObject messageBoxPanel;

	public GameObject debugPanel;

	private bool isMute;

	public static PauseScreen pauseScreen;

	public GameObject[] anis;

	private float m_animaStep;

	private float state;

	private Vector3[] posList;

	private Vector3[] offsetList;

	private float animaStep
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Pause()
	{
	}

	private void Resume()
	{
	}

	public void PreRemove()
	{
	}

	private void OnClick()
	{
	}

	private void ResumeClick()
	{
	}

	public void ClickMusic()
	{
	}

	public void ClickReset()
	{
	}

	public void ClickExit()
	{
	}

	public void ClickPause()
	{
	}

	public void cancelMessageBox()
	{
	}

	public void reallyExit()
	{
	}

	public void OnRuntimeDebugSelectionChanged()
	{
	}
}
