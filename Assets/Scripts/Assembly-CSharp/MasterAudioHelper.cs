using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DarkTonic.MasterAudio;
using UnityEngine;
using UnityEngine.Audio;

public class MasterAudioHelper
{
	public interface PlayFinishedCallback
	{
		void OnPlayFinished(long id);
	}

	public static MasterAudioHelper instance;

	public const int MAX_ALLOW_SOUND_IN_SAME_BUS_UI = 6;

	public const int MAX_ALLOW_SOUND_IN_SAME_BUS_BATTLE = 12;

	public const int MAX_ALLOW_SOUND_IN_SAME_TIME = 1;

	public const string BUS_NAME_UINormal = "Sounds_UINormal";

	public const string BUS_NAME_UIDraw = "Sounds_UIDraw";

	public const string BUS_NAME_UIResult = "Sounds_UIResult";

	public const string BUS_NAME_RoleCutScene = "Sounds_RoleCutScene";

	public const string BUS_NAME_RoleWeapon = "Sounds_RoleWeapon";

	public const string BUS_NAME_RoleSkill = "Sounds_RoleSkill";

	public const string BUS_NAME_RoleUltimate = "Sounds_RoleUltimate";

	public const string BUS_NAME_BattleGeneral = "Sounds_BattleGeneral";

	public const string BUS_NAME_EnemyBattle = "Sounds_EnemyBattle";

	public const string BUS_NAME_Env = "Sounds_Env";

	public const string BUS_NAME_Multi = "Sounds_UI_Multi";

	public const string BUS_NAME_CV = "Sounds_CharVoice";

	private MasterAudio ma;

	public PlaylistController ma_PlaylistController;

	private DynamicSoundGroupCreator ma_DynamicSoundGroupCreator;

	private MasterAudio.Playlist ma_playlist;

	public Dictionary<long, string> acNameDict;

	private GroupBus cvBus;

	public void InitMasterAudioIfNeed()
	{
	}

	private void CreateBuses()
	{
	}

	private GroupBus CreateBus(AudioMixer audioMixer, string name, int voiceLimit, MasterAudio maObj)
	{
		return null;
	}

	public void PrepareMADynamicSoundGroupObj(long ID, AudioClip clip, bool isLoop, int maxRepeatCountInSameTime)
	{
	}

	public void PlayMusic(AudioClip song, bool isLoop, float startAt = 0f)
	{
	}

	public void StopMusic()
	{
	}

	public void PauseMusic()
	{
	}

	public void ResumeMusic()
	{
	}

	public void StopSound(long ID)
	{
	}

	public void PauseSound(long ID)
	{
	}

	public void ResumeSound(long ID)
	{
	}

	public void PlaySound(long ID, string busName, PlayFinishedCallback callback = null)
	{
	}

	public MasterAudioGroup GetMasterAudioSoundGroup(long ID)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator PlaySoundInSync(long ID, string type, PlayFinishedCallback callback)
	{
		return null;
	}

	public void DeleteAllDynSndGrps()
	{
	}

	public void DeleteAllSoundGrps()
	{
	}

	public void DeleteSoundGroup(long ID)
	{
	}

	public void DeleteMusic(long ID)
	{
	}

	private Transform CreateGroup(AudioClip aClip, int count)
	{
		return null;
	}

	private void CreateVariation(Transform aGroup, AudioClip aClip)
	{
	}

	public void SetAllBusesSoundVol(float _soundVolume)
	{
	}

	public void SetCVBusSoundVol(float _cvVolume)
	{
	}

	internal void Dispose()
	{
	}
}
