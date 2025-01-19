using System;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	[Serializable]
	public class MusicSetting
	{
		public string alias;

		public MasterAudio.AudioLocation audLocation;

		public AudioClip clip;

		public string songName;

		public string resourceFileName;

		public float volume;

		public float pitch;

		public bool isExpanded;

		public bool isLoop;

		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		public float customStartTime;

		public float customStartTimeMax;

		public int lastKnownTimePoint;

		public bool wasLastKnownTimePointSet;

		public int songIndex;

		public bool songStartedEventExpanded;

		public string songStartedCustomEvent;

		public bool songChangedEventExpanded;

		public string songChangedCustomEvent;

		public float SongStartTime
		{
			get
			{
				return 0f;
			}
		}

		public static MusicSetting Clone(MusicSetting mus)
		{
			return null;
		}
	}
}
