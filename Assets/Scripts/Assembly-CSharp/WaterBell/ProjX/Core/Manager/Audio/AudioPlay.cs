using System.Collections;
using System.Diagnostics;
using DarkTonic.MasterAudio;
using UnityEngine;

namespace WaterBell.ProjX.Core.Manager.Audio
{
	public class AudioPlay : MasterAudioHelper.PlayFinishedCallback, IPausedComponent
	{
		public interface AudioPlayListener
		{
			void OnPlayStatusChanged(AudioPlay obj, AudioStatus status);
		}

		public enum AudioType
		{
			SIMPLE_SOUND = 0,
			BGM = 1,
			ADVANCE = 2
		}

		public enum AudioStatus
		{
			DEFAULT = 0,
			READY = 1,
			PLAYING = 2,
			PAUSED = 3,
			STOPED = 4,
			RECYCLED = 5
		}

		public long ID;

		public string NameKey;

		public string tag;

		public AudioType Type;

		public AudioPlayListener listener;

		public AudioStatus _status;

		public MasterAudioGroup sndGroup;

		public string SoundTag;

		public bool Loop;

		public float Vol;

		public float StartPosition;

		private bool InSkillPause;

		public AudioStatus Status
		{
			get
			{
				return default(AudioStatus);
			}
			set
			{
			}
		}

		public AudioClip audio { get; set; }

		private bool isSkillAudio
		{
			get
			{
				return false;
			}
		}

		private bool isCurrentCutSceneUsing
		{
			get
			{
				return false;
			}
		}

		internal AudioPlay()
		{
		}

		public void Play()
		{
		}

		public void OnPlayFinished(long id)
		{
		}

		public void Stop()
		{
		}

		public void FadeOutAndStop(float fadeTime)
		{
		}

		[DebuggerHidden]
		private IEnumerator FadeOutAndStopSound(float fadeInTimeInSec = 1f)
		{
			return null;
		}

		public void JustStop()
		{
		}

		public void PauseAudioPlay()
		{
		}

		public void ResumeAudioPlay()
		{
		}

		public void OnUnload()
		{
		}

		public void OnLoad(AudioManager.AudioImportInfo info)
		{
		}

		public static int CalculateMaxPlaybackCountInSameTime(AudioPlay audioPlay)
		{
			return 0;
		}

		public void reset()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public bool CheckAudioPlaySkillHandle()
		{
			return false;
		}
	}
}
