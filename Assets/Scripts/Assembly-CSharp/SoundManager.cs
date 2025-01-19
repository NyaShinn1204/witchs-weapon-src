using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
	private static GameObject _gameObject;

	private static AudioSource _soundSource;

	private static AudioSource _mngrMusicSource;

	private static AudioSource _musicSource;

	private static string _currentMusicPath;

	private static string _fightBgmNumStr;

	private static Dictionary<string, AudioClip> _soundClips;

	private static AudioClip _currentMusicClip;

	private static float _listenerVolume;

	private static bool isGlobal;

	public static float soundVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float musicVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool isMuted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void Init()
	{
	}

	public static void PlaySound(string resourceName)
	{
	}

	public static void PlaySound(string resourceName, float volume)
	{
	}

	public static void PlayMainUIBgm()
	{
	}

	public static void PlayMainFightBgm(bool isRandomNewBgm)
	{
	}

	private static int GetRandSongNum()
	{
		return 0;
	}

	private static void PlayMusic(string resourceName, float volume, bool shouldRestartIfSameSongIsAlreadyPlaying)
	{
	}

	public static void PauseMusic()
	{
	}

	public static void ResumeMusic()
	{
	}

	public static void UnloadSound(string resourceName)
	{
	}

	public static void UnloadMusic()
	{
	}

	public static void UnloadAllSounds()
	{
	}

	public static void UnloadAllSoundAndMusic()
	{
	}
}
