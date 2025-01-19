using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Audio;

namespace WaterBell.ProjX.Core.Manager.Audio
{
	public class AudioManager
	{
		public class AudioImportInfo
		{
			public long ID;

			public string res_path;

			public AudioPlay.AudioType type;

			public int priority;

			public bool pause;

			public bool loop;

			public long description;

			public string tag;
		}

		private class CSVModel
		{
			private static CSVModel instance;

			private string[] colName;

			private string[] dataType;

			private string[] annotation;

			private string[][] data;

			private int lineCount;

			private CSVModel()
			{
			}

			public static CSVModel GetInstance()
			{
				return null;
			}

			public void SetData(string[] lines)
			{
			}

			public int GetCollIdxByName(string name)
			{
				return 0;
			}

			public string GetData(int col, int row)
			{
				return null;
			}

			public int GetLineCount()
			{
				return 0;
			}
		}

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void BGMFadeFinished(AudioPlay fadeBGM, bool isFadeIn);

		public static float MAX_MUSIC_VOL;

		public static float MAX_SOUND_VOL;

		public static float MAX_CV_VOL;

		public const long RES_ID_S_GOLD = 99170100175L;

		public const long COMMON_CLICK_SOUNDEFF = 99120100255L;

		public const long COMMON_RETURN_SOUNDEFF = 99120100256L;

		public const long RELEASE_SKILL_SOUNDEFF = 99120100257L;

		public const long UI_SNDEFF_WINDOW = 99120100353L;

		public const long UI_SNDEFF_CANCEL = 99120100356L;

		public const long UI_SNDEFF_CLICK = 99120100359L;

		public const long UI_SNDEFF_CONFIRM = 99120100360L;

		public const long UI_SNDEFF_EQUIP = 99120100362L;

		public const long UI_SNDEFF_ERROR = 99120100363L;

		public const long UI_SNDEFF_EXP = 99120100364L;

		public const long UI_SNDEFF_GETNEW = 99120100365L;

		public const long UI_SNDEFF_MAIL = 99120100367L;

		public const long UI_SNDEFF_PAUSE = 99120100369L;

		public const long UI_SNDEFF_RESUME = 99120100371L;

		public const long UI_SNDEFF_SELL = 99120100374L;

		public const long UI_SNDEFF_ENTERMAP = 99120100375L;

		public const long UI_SNDEFF_SUMMON_CHAR = 99120100378L;

		public const long UI_SNDEFF_SUMMON_CHAR_PICTURE = 99120100379L;

		public const long UI_SNDEFF_SUMMON_GET = 99120100380L;

		public const long UI_SNDEFF_SUMMON_HIGH = 99120100381L;

		public const long UI_SNDEFF_SUMMON_LOW = 99120100382L;

		public const long UI_SNDEFF_TAG = 99120100383L;

		public const long UI_SNDEFF_DRAWCARD = 99120100386L;

		public const long UI_SNDEFF_LEVEL_PROMOTED = 99120100387L;

		public const long UI_SNDEFF_SEPHIROT_FUSION = 99120100388L;

		public const long UI_SNDEFF_WEAPON_REFINE_ATKUP = 99120100390L;

		public const long UI_SNDEFF_WEAPON_REFINE_UNLOCK = 99120100391L;

		public const long UI_SNDEFF_WEAPON_SWITCH = 99120100392L;

		public const long UI_SNDEFF_BATTLE_CLEAR = 99120100393L;

		public const long UI_SNDEFF_ITEMDLG_CLOSE = 99120100394L;

		public const long UI_SNDEFF_ITEMDLG_OPEN = 99120100395L;

		public const long UI_SNDEFF_WEAPON_AWAKEN_A = 99120100396L;

		public const long UI_SNDEFF_WEAPON_AWAKEN_B = 99120100397L;

		public const long UI_SNDEFF_WEAPON_AWAKEN_C = 99120100398L;

		public const long UI_SNDEFF_NEW_10DRAW = 99120100440L;

		public const long UI_SNDEFF_NEW_ITEMSCOUNT = 99120100441L;

		public const long UI_SNDEFF_NEW_ROTATECRYSTAL_BIG = 99120100442L;

		public const long UI_SNDEFF_NEW_ROTATECRYSTAL_SMALL = 99120100443L;

		public const long UI_SNDEFF_NEW_SINGLECOUNT = 99120100444L;

		public const long UI_SNDEFF_NEW_SINGLEDRAW = 99120100445L;

		public const long UI_SNDEFF_NEW_STARCLICK = 99120100446L;

		public const long UI_SNDEFF_NEW_ZOOMOUT = 99120100447L;

		public const long UI_SNDEFF_SCREEN_CLICK = 99120100647L;

		public const long UI_SNDEFF_EXP_ADD = 99120100648L;

		public const long UI_SNDEFF_GET_ITEM = 99120100649L;

		public const long UI_SNDEFF_NUMBER_ADD = 99120100650L;

		public const long UI_SNDEFF_WITCH_LVUP = 99120100651L;

		public const string MIXER_SNAPSHOT_NORMALUI = "UI";

		public const string MIXER_SNAPSHOT_DRAW = "UI_Draw";

		public const string MIXER_SNAPSHOT_CUTSCENE = "CutScene";

		public const string MIXER_SNAPSHOT_BATTLE = "Battle";

		public const string MIXER_SNAPSHOT_CV = "CV";

		private static AudioManager instance;

		private static AudioMixer mixer;

		public Dictionary<long, AudioImportInfo> InfoTable;

		public GameObject ManagerObject;

		private const int MAX_BGM_CACHING_CAPACY = 3;

		private AudioPlay currentBGM;

		private AudioPlay guideBGM;

		private AudioPlay lastBGM;

		private Dictionary<long, AudioPlay> SimpleSoundCache;

		private Dictionary<long, AudioPlay> BGMCache;

		public Dictionary<long, AudioPlay> ADVSoundCache;

		public const int INIT_SIMPLE_SOUND_SOURCE_COUNT = 10;

		public const int MAX_SIMPLE_SOUND_SOURCE_COUNT = 30;

		public static long RES_ID_MAIN_UI_BGM;

		public static long RES_ID_PLAYMODE_ABNORMAL_BGM;

		public static long RES_ID_PLAYMODE_NORMAL_BGM;

		public static long RES_ID_PLAYMODE_MAZE_BGM;

		public static long RES_ID_SHOP_BGM;

		public static long RES_ID_DRAW_BGM;

		public static long[] RES_ID_FIGHT_BGM;

		private static AudioMixerSnapshot lastSnapshot;

		private static AudioMixerSnapshot currentSnapshot;

		private static int rsn;

		private static int[][] mainStoryBGM;

		private static int[] expeditionBGM;

		private static int[] dailyBGM;

		private float _soundVolume;

		private float _musicVolume;

		private float _charVolume;

		private AudioPlay animatedBGM;

		private long NextBGMResID;

		private string _PREFS_SOUND
		{
			get
			{
				return null;
			}
		}

		private string _PREFS_MUSIC
		{
			get
			{
				return null;
			}
		}

		private string _PREFS_CV
		{
			get
			{
				return null;
			}
		}

		public float SoundVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MusicVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CharacterVoiceVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event BGMFadeFinished CurrentBGMFadeFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private AudioManager()
		{
		}

		public static AudioManager GetInstance()
		{
			return null;
		}

		public AudioPlay GetCurrentBGM()
		{
			return null;
		}

		public AudioPlay GetCache(AudioPlay.AudioType type, long ID)
		{
			return null;
		}

		private void init()
		{
		}

		internal void Dispose()
		{
		}

		private void loadInfoTable()
		{
		}

		public static void GoToSoundMode(string name)
		{
		}

		public static string GetCurrentMixxerSnapshotName()
		{
			return null;
		}

		public static void BackToLastSoundMode()
		{
		}

		public static void PlayUIBgm(long ResId)
		{
		}

		private void InitBGMFilter()
		{
		}

		public static void PlayMainFightBgm(bool isRandomNewBgm)
		{
		}

		private static void PlayFightBGM(int i)
		{
		}

		public static void ChangeFightBGM()
		{
		}

		public static void PauseCurrentBgm()
		{
		}

		public static void ResumeCurrentBgm()
		{
		}

		public static void StopSound(long ResId)
		{
		}

		public static AudioPlay PlaySound(long ResId)
		{
			return null;
		}

		public void LoadVolumeSettings()
		{
		}

		public void SaveVolumeSettings()
		{
		}

		public long GetCurrPlayingBgmID()
		{
			return 0L;
		}

		public AudioPlay PlaySnd(long ResId)
		{
			return null;
		}

		public void StopSnd(long ResId)
		{
		}

		public void PlayBGM(long ResID, bool shouldRestartIfSameSongIsAlreadyPlaying = false, float startPosition = 0f)
		{
		}

		public void StopBGM()
		{
		}

		public void PlayGuideBGM(long ResID, float startPosition = 0f)
		{
		}

		public void StopGuideBGM()
		{
		}

		private AudioPlay getBGM(long ResID)
		{
			return null;
		}

		public void ChangeBGMInFade(long BGMResID, float fadeInTimeInSec)
		{
		}

		public void onCurrentBGMFinished(AudioPlay fadeBGM, bool isFadeIn)
		{
		}

		public void ApplyMuteAndFadeInToCurrentBGM(float muteTimeInSec, float fadeInTimeInSec)
		{
		}

		public void ApplyFadeInToBGM(AudioPlay bgm, float fadeInTimeInSec = 1f)
		{
		}

		[DebuggerHidden]
		private IEnumerator AnimatingBGM_MuteNFadeIn(AudioPlay animatingAudio, float muteTimeInSec, float fadeInTimeInSec)
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator AnimatingBGM_Fade(AudioPlay animatingAudio, float fadeInTimeInSec = 1f, bool isFadeIn = false)
		{
			return null;
		}

		public AudioPlay NewAudioPlay(GameObject relativeGo, long ResID)
		{
			return null;
		}

		private AudioPlay NewAudioPlayInternal(GameObject relativeGO, AudioImportInfo info)
		{
			return null;
		}

		public AudioClip PrepareResource(long ResID)
		{
			return null;
		}

		private void UnloadAllAudioPlayByType(AudioPlay.AudioType type)
		{
		}

		public bool UnloadSingleAudioPlay(AudioPlay p)
		{
			return false;
		}

		public void UnloadAll()
		{
		}

		private void ReleaseData(long ResId)
		{
		}
	}
}
