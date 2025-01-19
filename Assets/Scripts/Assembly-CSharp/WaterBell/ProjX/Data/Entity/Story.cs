using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;
using LuaInterface;
using Storymod;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Data.Entity
{
	public class Story
	{
		private Dictionary<long, StoryGroup> _group_hash;

		private LuaFunction luaFunc;

		private long actStoryID;

		private RepeatedField<LootObject> _loots;

		public Dictionary<long, StoryGroup> StoryGroups
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Parse(Storymod.Story sServerData)
		{
		}

		public StoryGroup GetStoryGroupById(long ID)
		{
			return null;
		}

		public void WhenApOpenCheckAllApStory()
		{
		}

		public BuyStory CheckAndUnlockActivityStory(long groupID, long storyID, long activityID, LuaFunction luaFunc)
		{
			return null;
		}

		private void DealResult(int result, RepeatedField<LootObject> loots)
		{
		}

		private void AfterBuyStory()
		{
		}

		private void AddAndShowLoot()
		{
		}

		public void CheckAndUnlockStory(long groupID, long storyID, bool isBuy, long activityID = 0L)
		{
		}

		public void InitStoryByLocalJson()
		{
		}

		public void Dispose()
		{
		}
	}
}
