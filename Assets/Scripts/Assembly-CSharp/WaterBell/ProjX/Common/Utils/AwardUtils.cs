using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;
using LuaInterface;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

namespace WaterBell.ProjX.Common.Utils
{
	public class AwardUtils
	{
		private static AwardUtils instance;

		public AssetsManager.AssetsType tempAssetsType;

		private GameObject shopHelperObj;

		private long shopSetID;

		private long shopID;

		private long goodsID;

		private int payType;

		private long buySetID;

		private long buyShopID;

		private long GoodID;

		private int Num;

		private ModelCollection<DrawResultData> datas;

		private ModelCollection<DrawResultData> weapons;

		private LuaFunction luaFunc;

		private float duration;

		public static AwardUtils GetInstance()
		{
			return null;
		}

		private void Init()
		{
		}

		public UserInfo GetUserInfo()
		{
			return null;
		}

		public int GetUserInfoTestCode()
		{
			return 0;
		}

		public ObservablePlayer GetPlayer()
		{
			return null;
		}

		public long RoleID()
		{
			return 0L;
		}

		public int GetCurrentLevel()
		{
			return 0;
		}

		public void SetUITexture(UITexture texture, string name)
		{
		}

		public Transform LoadAwardSprite(long resID, string eID, int num, Transform tran, long value, float scale)
		{
			return null;
		}

		public Transform LoadAwardSpriteEx(long resID, GlobalEnum.ResType resType, int num, Transform tran, long value, float scale)
		{
			return null;
		}

		public static void LoadShopGoodsAwardSprite(long _setID, long _shopID, long _goodsID, Transform tran, float scale)
		{
		}

		public static List<UIRawResData> GetShopGoods(long _setID, long _shopID, long _goodsID)
		{
			return null;
		}

		public static List<LotteryLootData> GetLevelAward(long ID)
		{
			return null;
		}

		public void SegmentationLabel(UILabel label)
		{
		}

		public void DeleteObj(Transform parent)
		{
		}

		public void GoYunyingShop()
		{
		}

		public void ActivityRemind(bool tag)
		{
		}

		public void ActivityUnloadResource()
		{
		}

		public void ActivityUnloadResource(AssetsManager.AssetsType assetsType)
		{
		}

		public void BuyShop(GameObject shopHelperObj, long shopSetID, long shopID, long goodsID, int payType = 2)
		{
		}

		private void BuyAction()
		{
		}

		public void BuyGood(long SetID, long ShopID, long GoodID, int Num)
		{
		}

		private void FailhBuy(string text)
		{
		}

		private void DealResultBuy(string result, string order, RepeatedField<LootObject> lootObjects)
		{
		}

		public static bool GetLevelIsPassByID(long id)
		{
			return false;
		}

		public static bool GetAchievementFinishedByID(long id)
		{
			return false;
		}

		public static int GetAchievementStatusByID(long id)
		{
			return 0;
		}

		public static int GetTaskStatusByID(long id)
		{
			return 0;
		}

		public static int GetTaskProgressByID(long id)
		{
			return 0;
		}

		public static List<DrawInfo> GetDrawInfo()
		{
			return null;
		}

		public static long DateTime2Timestamp(DateTime time)
		{
			return 0L;
		}

		public static DateTime Timestamp2DateTime(long timestamp)
		{
			return default(DateTime);
		}

		public static void GoNoticeOnePage(int sTitle)
		{
		}

		public static bool IsGuideRuning()
		{
			return false;
		}

		public static void DoMove2AD(float timeR, float timeM, float rotateY, string func)
		{
		}

		public static void OpenWebURLNotie(string sUrl = null, bool sIsOpenIn = true, Function sCloseHD = null)
		{
		}

		public static void ChangePlayMode(long instID, long baseID, int Serial, int BattleCount, int BattleMaxCount, int mode, string extraargu)
		{
		}

		public static void OpenCafe(string RoleID)
		{
		}

		public void GetTaskRewardByID(long id, LuaFunction luaFunc)
		{
		}

		private void DealNormalQuestResult(int result, RepeatedField<LootObject> lootObjects)
		{
		}

		private void FinishReceiveAndGetAll()
		{
		}

		private void FailReceiveQuest(string str)
		{
		}

		public static bool CheckStoryUnlock(long groupID, long storyID)
		{
			return false;
		}

		public static void UnlockStory(long groupID, long storyID, long activityID, LuaFunction luaFunc)
		{
		}

		public static void OpenStory(long storyID)
		{
		}

		public static int GetTotalDrawNum(long rateID)
		{
			return 0;
		}

		public static string GetCurLanguageStr()
		{
			return null;
		}

		public void BezierMovie(GameObject BezierMovieObj, Vector3 from, Vector3 to, Vector3 offset, float duration, LuaFunction luaFunc)
		{
		}

		private void bezierMoveHD(GUtilListenerEvent sEvent)
		{
		}

		public static void JPAdjustLoginReward()
		{
		}

		public static void SetTrainingSceneID(long ID)
		{
		}

		public static void UpdateActivityData(byte[] data)
		{
		}

		public static Texture GetServantBigTextureByImageID(long servantImageID, AssetsManager.AssetsType assetsType)
		{
			return null;
		}

		public static Texture GetWeaponBigTextureByID(long weaponID, AssetsManager.AssetsType assetsType)
		{
			return null;
		}

		public static Texture GetWeaponAwakeBigTextureByID(long weaponID, AssetsManager.AssetsType assetsType)
		{
			return null;
		}

		public static void PlaySound(long soundID)
		{
		}
	}
}
