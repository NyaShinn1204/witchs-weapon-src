using LitJson;

namespace WaterBell.ProjX.Guide
{
	public class GuideLessonLocalManager
	{
		private struct LoginCachedJson
		{
			public JsonData bagInfoJson;

			public JsonData equipInfoJson;

			public JsonData svListJson;

			public JsonData progressJson;

			public JsonData achieveJson;

			public JsonData capJson;

			public JsonData mailJson;

			public JsonData roleInfoJson;
		}

		private static GuideLessonLocalManager _instance;

		private LocalLessonProgressStep localProgressStep;

		private LoginCachedJson cachedJson;

		public static GuideLessonLocalManager GetInstance()
		{
			return null;
		}

		public void SetLocalProgress(LocalLessonProgressStep step)
		{
		}

		public bool IsLocalGuideActive()
		{
			return false;
		}

		public void OnLoadIntoBattle()
		{
		}

		public void OnFightPassReturnUI()
		{
		}

		public void OnClickLotteryBtn(bool isLeft)
		{
		}

		public void OnClickStoryFight(string levelID)
		{
		}

		public void OnLootServant()
		{
		}

		public void OnClickGetAchievementReward()
		{
		}

		private void LoadBattleConstInfoSeq()
		{
		}

		private void LoadBattleInfoSeq(int battleNO)
		{
		}

		private void PreloadBattleLoot(int battleNO, string levelID)
		{
		}

		private void LoadBattleServantLoot()
		{
		}

		public void CacheNetMsg(NetMsgType type, JsonData json)
		{
		}

		private JsonData ReadLocalJsonFile(string fileName)
		{
			return null;
		}

		private string ReadLocalJsonFileAsString(string fileName)
		{
			return null;
		}
	}
}
