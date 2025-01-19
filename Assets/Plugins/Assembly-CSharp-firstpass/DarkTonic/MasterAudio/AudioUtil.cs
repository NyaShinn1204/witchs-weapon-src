using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public static class AudioUtil
	{
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		private const float SemitonePitchChangeAmt = 1.0594635f;

		public static float FixedDeltaTime
		{
			get
			{
				return 0f;
			}
		}

		public static float FrameTime
		{
			get
			{
				return 0f;
			}
		}

		public static float Time
		{
			get
			{
				return 0f;
			}
		}

		public static int FrameCount
		{
			get
			{
				return 0;
			}
		}

		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return 0f;
		}

		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return 0f;
		}

		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return 0f;
		}

		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return 0f;
		}

		public static float GetSemitonesFromPitch(float pitch)
		{
			return 0f;
		}

		public static float GetPitchFromSemitones(float semitones)
		{
			return 0f;
		}

		public static float GetDbFromFloatVolume(float vol)
		{
			return 0f;
		}

		public static float GetFloatVolumeFromDb(float db)
		{
			return 0f;
		}

		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return 0f;
		}

		public static bool IsAudioPaused(AudioSource source)
		{
			return false;
		}

		public static void UnloadNonPreloadedAudioData(AudioClip clip)
		{
		}

		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return false;
		}

		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return false;
		}
	}
}
