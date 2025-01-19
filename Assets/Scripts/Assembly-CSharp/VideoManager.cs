using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
	public enum MovieControlMode
	{
		None = 0,
		Full = 1,
		CancelOnInput = 2
	}

	public MediaPlayerCtrl scrMedia;

	private static VideoManager instance;

	private MovieControlMode mode;

	private bool Playing;

	public GameObject skip;

	private static bool isGuide;

	public Text textSubtitles;

	public Text textSkip;

	private Dictionary<int, string> dicSubtitles;

	private bool isLoadSubtitles;

	private int lastMoiveTime;

	private int curMovieTime;

	public static VideoManager GetInstance()
	{
		return null;
	}

	private void Start()
	{
	}

	private void _OnVideoError(MediaPlayerCtrl.MEDIAPLAYER_ERROR errorCode, MediaPlayerCtrl.MEDIAPLAYER_ERROR errorCodeExtra)
	{
	}

	private void LoadSubtitles(string fileName)
	{
	}

	public void Load(string str, MovieControlMode mode = MovieControlMode.CancelOnInput, bool guide = true, bool loop = false, int depth = 1)
	{
	}

	private void SoundControl()
	{
	}

	public void UnLoad()
	{
	}

	public void OnEnd()
	{
	}

	private void _OnEnd()
	{
	}

	private void Update()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public static void ClosePVToLoginFormal()
	{
	}

	public static string GetOPName()
	{
		return null;
	}
}
