using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class GuideCmdAPI
	{
		private static Color ParseHexColor(string colStr)
		{
			return default(Color);
		}

		private static bool InsertPic(object[] cmdArgs, PicLayer.PicInsertLayer layer, bool isFirstTimeInsert = false)
		{
			return false;
		}

		private static bool RoleSpeak(Lesson lesson, object[] cmdArgs, bool isSpeakAtPos = false)
		{
			return false;
		}

		private static bool RoleOut(Lesson lesson, object[] cmdArgs)
		{
			return false;
		}

		public static bool ParseAndRunCmd(Lesson lesson, string cmdName, object[] cmdArgs)
		{
			return false;
		}
	}
}
