using UnityEngine;

namespace LuaFramework
{
	public class Util
	{
		public static string DataPath
		{
			get
			{
				return null;
			}
		}

		public static int Int(object o)
		{
			return 0;
		}

		public static float Float(object o)
		{
			return 0f;
		}

		public static long Long(object o)
		{
			return 0L;
		}

		public static int Random(int min, int max)
		{
			return 0;
		}

		public static float Random(float min, float max)
		{
			return 0f;
		}

		public static string Uid(string uid)
		{
			return null;
		}

		public static long GetTime()
		{
			return 0L;
		}

		public static T Get<T>(GameObject go, string subnode) where T : Component
		{
			return null;
		}

		public static T Get<T>(Transform go, string subnode) where T : Component
		{
			return null;
		}

		public static T Get<T>(Component go, string subnode) where T : Component
		{
			return null;
		}

		public static T Add<T>(GameObject go) where T : Component
		{
			return null;
		}

		public static T Add<T>(Transform go) where T : Component
		{
			return null;
		}

		public static GameObject Child(GameObject go, string subnode)
		{
			return null;
		}

		public static GameObject Child(Transform go, string subnode)
		{
			return null;
		}

		public static GameObject Peer(GameObject go, string subnode)
		{
			return null;
		}

		public static GameObject Peer(Transform go, string subnode)
		{
			return null;
		}

		public static string md5(string source)
		{
			return null;
		}

		public static string md5file(string file)
		{
			return null;
		}

		public static void ClearChild(Transform go)
		{
		}

		public static void ClearMemory()
		{
		}

		public static string ASPath()
		{
			return null;
		}

		public static string AppContentPath()
		{
			return null;
		}

		public static void AddClick(GameObject go, object luafuc)
		{
		}

		public static void Log(string str)
		{
		}

		public static void LogWarning(string str)
		{
		}

		public static void LogError(string str)
		{
		}

		public static Component AddComponent(GameObject go, string assembly, string classname)
		{
			return null;
		}

		public static GameObject LoadPrefab(string name)
		{
			return null;
		}

		public static object[] CallMethod(string module, string func, params object[] args)
		{
			return null;
		}

		private static int CheckRuntimeFile()
		{
			return 0;
		}

		public static bool CheckEnvironment()
		{
			return false;
		}

		public static byte[] GetSAPB(string name)
		{
			return null;
		}
	}
}
