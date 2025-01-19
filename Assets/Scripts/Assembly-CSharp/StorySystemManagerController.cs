using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class StorySystemManagerController : StorySystemManagerControllerBase
{
	private ModelCollection<DrawResultData> BuyLoots;

	private ModelCollection<DrawResultData> ExtraWeapon;

	private LootList storyLootlist;

	private long TargetStoryID;

	public override void InitializeStorySystemManager(StorySystemManagerViewModel storySystemManager)
	{
	}

	public override void BuyStory(StorySystemManagerViewModel storySystemManager, long arg)
	{
	}

	private void dealResult(int result, RepeatedField<LootObject> loots)
	{
	}

	private void AddAndShowLoot()
	{
	}

	private void AfterBuyStory()
	{
	}

	private void AfterBuyStoryByItem()
	{
	}

	public override void NoticeStoryCanUnlock(StorySystemManagerViewModel storySystemManager, long arg)
	{
	}

	public override void NoticeStoryGroupUnlock(StorySystemManagerViewModel storySystemManager, long arg)
	{
	}

	public override void NoticeStorynlock(StorySystemManagerViewModel storySystemManager, long arg)
	{
	}

	public override void BuyStoryByItem(StorySystemManagerViewModel storySystemManager, long arg)
	{
	}
}
