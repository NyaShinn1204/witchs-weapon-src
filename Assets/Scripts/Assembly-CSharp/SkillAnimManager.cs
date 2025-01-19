using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class SkillAnimManager : MonoBehaviour
{
	private static bool isPlayingAnim;

	private static string mob_serial;

	private static Animator cameraAnimator;

	public static TypeCsvServant currentServant;

	public static string CurrentMobSerial
	{
		get
		{
			return null;
		}
	}

	public static bool IsPlaying()
	{
		return false;
	}

	public static void SwitchToCallSkillCamera(string servantPrefabName)
	{
	}

	public static void SwitchBackMainCamera(bool withSkip = false)
	{
	}

	private static void LoadServantAnim(string servantPrefabName)
	{
	}

	public static TypeCsvServant FindOutServantFromPrefabName(string servantPrefabName)
	{
		return null;
	}

	public static void PlayUltimateCV(bool isNextCall, bool stopLastWithFade = false)
	{
	}

	[DebuggerHidden]
	private static IEnumerator PlayCVDelay(float delayTime)
	{
		return null;
	}

	private static void ForceStopLastCV(bool useFade)
	{
	}

	public static void BindCameraAnimation(string servantPrefabName)
	{
	}
}
