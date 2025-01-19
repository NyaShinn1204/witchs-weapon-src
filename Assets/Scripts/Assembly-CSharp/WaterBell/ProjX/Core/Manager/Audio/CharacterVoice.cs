using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Core.Manager.Audio
{
	public class CharacterVoice : AudioPlay.AudioPlayListener
	{
		public enum CVEventType
		{
			CV_TYPE_GAIN_WEAPON1 = 0,
			CV_TYPE_GAIN_WEAPON2 = 1,
			CV_TYPE_ULTIMATE_SKILL = 2,
			CV_TYPE_CHANGE_WEAPON1 = 3,
			CV_TYPE_CHANGE_WEAPON2 = 4,
			CV_TYPE_CHANGE_WEAPON3 = 5,
			CV_TYPE_CHANGE_WEAPON4 = 6,
			CV_TYPE_ENTER_BATTLE = 7,
			CV_TYPE_VICTORY = 8,
			CV_TYPE_APPEARANCE = 9,
			CV_TYPE_PROMOTE_STAR = 10,
			CV_TYPE_PROMOTE_RANK3 = 11,
			CV_TYPE_AWAKENING = 12,
			CV_TYPE_FAVORABILITY0 = 13,
			CV_TYPE_FAVORABILITY1 = 14,
			CV_TYPE_FAVORABILITY2 = 15,
			CV_TYPE_FAVORABILITY3 = 16,
			CV_TYPE_ENEMY_BORN = 17,
			CV_TYPE_ENEMY_DEAD = 18,
			CV_TYPE_ENEMY_ATTACK = 19,
			CV_TYPE_ENEMY_HURT = 20,
			CV_TYPE_FIGHT = 21
		}

		[StructLayout(LayoutKind.Sequential, Size = 16)]
		public struct Clause
		{
			public long SoundID;

			public long LineID;
		}

		public class Sentence
		{
			public Clause[] clauses;

			public int currentPlayIdx;

			public Sentence(string sentenceRawString)
			{
			}
		}

		public class CVStatus
		{
			public long ServantID;

			public CVEventType currentEvnetType;

			public int currentSentenceIndex;

			public int currentClauseIndex;

			public long currentPlayingSoundID;

			public bool isPlaying;

			public AudioPlay currentPlay;
		}

		public class CVPreviewItem
		{
			public long ServantId;

			public long SoundId;

			public long TextId;

			public bool Unlocked;

			public CVEventType EventType;

			public int sentenceIdx;

			public int clauseIdx;
		}

		public enum CVMainRoleEventType
		{
			MAIN_CV_LOGO = 0,
			MAIN_CV_LOGIN = 1,
			MAIN_CV_GACHA = 2,
			MAIN_CV_CREDIT_ENTER = 3,
			MAIN_CV_CREDIT_LEAVE = 4,
			MAIN_CV_CREDIT_SMALL = 5,
			MAIN_CV_CREDIT_LARGE = 6,
			MAIN_CV_LEVELUP = 7,
			MAIN_CV_NEW_FASHIONSUIT = 8,
			MAIN_CV_LEVEL_CLEAR = 9,
			MAIN_CV_STAMINA_LOW = 10,
			MAIN_CV_FASTPASS_ENTER = 11,
			MAIN_CV_FASTPASS_LIST = 12,
			MAIN_CV_STAMINA_GAIN = 13,
			MAIN_CV_BATTLE_AGAIN = 14,
			MAIN_CV_EMAIL_ENTER_UNREAD = 15,
			MAIN_CV_EXPEDITION_UNBOX = 16,
			MAIN_CV_BATTLE_WIN_END = 17,
			MAIN_CV_BATTLE_LOSE_END = 18,
			MAIN_CV_BATTLE_START = 19,
			MAIN_CV_ATTACK = 20,
			MAIN_CV_HIT = 21,
			MAIN_CV_BOSS = 22,
			MAIN_CV_HP_LOW = 23,
			MAIN_CV_HP_RESTORE = 24,
			MAIN_CV_CRIT = 25,
			MAIN_CV_SOLD = 26
		}

		public class MainRoleCVStatus
		{
			public CVMainRoleEventType currentEvnetType;

			public int currentSentenceIndex;

			public long currentPlayingSoundID;

			public bool isPlaying;

			public AudioPlay currentPlay;
		}

		private static CharacterVoice instance;

		private Dictionary<CVEventType, int> priorityMap;

		private Dictionary<long, CVStatus> statusMap;

		private Dictionary<string, List<Sentence>> sentencesCache;

		public CVEventType[] PrevEventTypes;

		private float PLAYER_CV_ATK_RND;

		private float PLAYER_CV_HIT_RND;

		private float PLAYER_CV_CRIT_RND;

		private MainRoleCVStatus mainRoleStatus;

		private Dictionary<string, List<Sentence>> mainRoleCVCache;

		private CharacterVoice()
		{
		}

		public static CharacterVoice GetInstance()
		{
			return null;
		}

		private void init()
		{
		}

		public void ForceStopCV(long servantID, bool useFadeOut = false)
		{
		}

		public void PlayCV(long servantID, CVEventType type, int sentenceIdx = -1, int clauseIdx = -1, bool supressOtherSound = false, bool ignorePriority = false)
		{
		}

		private void PlayCVInternal(CVStatus status, int sentenceIdx, int clauseIdx, bool SupressOtherSound, bool no_shuffle = false)
		{
		}

		public List<Sentence> GetCVSoundIDs(long servantID, CVEventType type, bool forNewList = false)
		{
			return null;
		}

		public void OnPlayStatusChanged(AudioPlay obj, AudioPlay.AudioStatus audio_status)
		{
		}

		public List<CVPreviewItem> GetCVPreview(long ServantId, int favLevel)
		{
			return null;
		}

		private CVPreviewItem GetPreviewItem(long ServantId, CVEventType eventType, Clause c, int sentenceIdx, int clauseIdx, List<string> favCVIDS)
		{
			return null;
		}

		private List<string> GetFavIds(long ServantId, int favLevel)
		{
			return null;
		}

		public void PlayCVPrevItem(CVPreviewItem item, bool SupressOtherSound = false)
		{
		}

		private void checkIfNeedBackToNormalSoundMode()
		{
		}

		public void PlayMainRoleCV(CVMainRoleEventType type, int sentenceIdx = -1, bool supressOtherSound = false, bool ignorePriority = false)
		{
		}

		public void ForceStopAllCV()
		{
		}

		private List<Sentence> GetMainRoleCVSoundIDs(CVMainRoleEventType type)
		{
			return null;
		}

		public void ForceStopMainRoleCV()
		{
		}
	}
}
