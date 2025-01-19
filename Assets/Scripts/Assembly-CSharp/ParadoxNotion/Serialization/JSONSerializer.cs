using System;
using System.Collections.Generic;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace ParadoxNotion.Serialization
{
	public static class JSONSerializer
	{
		private static Dictionary<string, fsData> cache;

		private static object serializerLock;

		private static fsSerializer serializer;

		private static bool init;

		public static bool applicationPlaying;

		public static string Serialize(Type type, object value, bool pretyJson = false, List<UnityEngine.Object> objectReferences = null)
		{
			return null;
		}

		public static T Deserialize<T>(string serializedState, List<UnityEngine.Object> objectReferences = null, T deserialized = default(T))
		{
			return default(T);
		}

		public static object Deserialize(Type type, string serializedState, List<UnityEngine.Object> objectReferences = null, object deserialized = null)
		{
			return null;
		}
	}
}
