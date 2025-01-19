using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public static class AudioSampler
	{
		private const string ROOT_NAME = "_AudioSources";

		private static GameObject root;

		private static Dictionary<object, AudioSource> sources;

		public static AudioSource GetSourceForID(object keyID)
		{
			return null;
		}

		public static void ReleaseSourceForID(object keyID)
		{
		}

		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, float volume, bool ignoreTimescale = false)
		{
		}

		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, float volume, bool ignoreTimescale = false)
		{
		}
	}
}
