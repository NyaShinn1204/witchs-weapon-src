using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class QuestSystemManagerController : QuestSystemManagerControllerBase
{
	private long targetJobId;

	public override void InitializeQuestSystemManager(QuestSystemManagerViewModel questSystemManager)
	{
	}

	private void UpdatepAchievement(PropertyChangeedObservable target)
	{
	}

	private void UpdateHaveNewNormalQuest(bool value)
	{
	}

	private void UpdateGuideQuestInProgress(bool value)
	{
	}

	private void UpdateHaveNewMainStoryQuest(bool value)
	{
	}

	private void UpdateHaveNewGuideQuest(bool value)
	{
	}

	private void UpdateHaveNewActivityQuest(bool value)
	{
	}

	private void UpdateHaveNewActivityDailyQuest(bool value)
	{
	}

	private void AddQuestJob(ObservableJob item)
	{
	}

	private void AddQuestMeta(ObservableMetaInfo item)
	{
	}

	private void UpdateQuestMeta(PropertyChangeedObservable target)
	{
	}

	private void RemoveQuestMeta(ObservableMetaInfo item)
	{
	}

	private void RemoveQuestJob(ObservableJob item)
	{
	}

	private void UpdateJob(PropertyChangeedObservable target)
	{
	}

	private void UpdateJobInfo(ModelCollection<QuestInfoViewModel> viewmodelList, ObservableJob current)
	{
	}

	public override void FinishiQuest(QuestSystemManagerViewModel questSystemManager, long arg)
	{
	}

	private void FinishReceiveAndGetAll()
	{
	}

	public void failReceiveQuest(string text)
	{
	}

	private void dealNormalQuestResult(int result, RepeatedField<LootObject> lootObjects)
	{
	}

	public override void OpenGuide(QuestSystemManagerViewModel questSystemManager, long arg)
	{
	}

	private void dealResult(int result, RepeatedField<LootObject> loots)
	{
	}

	private void SuccessfulOpenGuide()
	{
	}

	public override void ReceiveAllQuest(QuestSystemManagerViewModel questSystemManager, int arg)
	{
	}

	public void failReceiveAllQuest(string text)
	{
	}

	public void SuccessReceiveAllQuest()
	{
	}
}
