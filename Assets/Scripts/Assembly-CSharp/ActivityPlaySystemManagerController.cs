using Actionmod;
using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class ActivityPlaySystemManagerController : ActivityPlaySystemManagerControllerBase
{
	private long TicketID;

	private long APCurrencyID;

	private long APCurrencyID2;

	private int resetCostBefore;

	private string tempAddAttrArgu;

	public override void InitializeActivityPlaySystemManager(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	private void AddItem(ObservableSingleItem item)
	{
	}

	private void UpdateItem(PropertyChangeedObservable target)
	{
	}

	private void RemoveItem(ObservableSingleItem item)
	{
	}

	private void UpdateActivityPlaySystem()
	{
	}

	private void UpdateStamina()
	{
	}

	private void UpdateAction(PropertyChangeedObservable target)
	{
	}

	private void UpdateStaminaAction(PropertyChangeedObservable target)
	{
	}

	public override void ReceiveDailyStamina(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	private void SuccessfulGetDailyStamina()
	{
	}

	public override void ReceiveInitStamina(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	private void SuccessfulGetInitStamina()
	{
	}

	public override void Reset(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	private void FinishResetAndGetData()
	{
	}

	public override void GetReward(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	private void dealGetRuleDataResult(int result, RepeatedField<LootObject> loots, ExtraInfo ExtraInfo, int mode, string difficult = "", bool isspecial = false)
	{
	}

	private void dealGetRule4ExtraBonusDataResult(int result, RepeatedField<LootObject> loots)
	{
	}

	private void FinishGetReward()
	{
	}

	private void FinishGetRule5Reward()
	{
	}

	public override void UnlockAPStory(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	public override void GetRank(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	private void FinishGetRank()
	{
	}

	public override void Sweep(ActivityPlaySystemManagerViewModel activityPlaySystemManager, SweepArgu arg)
	{
	}

	public void SuccessfulSweep()
	{
	}

	public void FailedSweep(string text)
	{
	}

	private void dealResult(long id, int count, RepeatedField<LootObject> lootObjects)
	{
	}

	public override void GoToNextFloorRule1(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	private void FinishNextFloor()
	{
	}

	public override void AttributeAdd(ActivityPlaySystemManagerViewModel activityPlaySystemManager, string arg)
	{
	}

	private void caculateConsumeItem()
	{
	}

	private void afterAPAttributeAdd()
	{
	}

	public override void AttributeReset(ActivityPlaySystemManagerViewModel activityPlaySystemManager)
	{
	}

	private void afterAPAttributeReset()
	{
	}

	public override void Rule5Getreward(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	public override void Rule5GiveUp(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	private void FinishGiveUp()
	{
	}

	public override void Rule5Reset(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	private void FinishResetRule5AndGetData()
	{
	}

	private int GetRroundTypeByR5Argu(Rule5Argu arg)
	{
		return 0;
	}

	public override void ChangeKey(ActivityPlaySystemManagerViewModel activityPlaySystemManager, ChangeKeyArg arg)
	{
	}

	private void AfterKeyItemExchange()
	{
	}

	public override void Rule5UnlockFinalRound(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	private void AfterRule5UnlockFinalRound()
	{
	}

	public override void R4ChooseMobLevel(ActivityPlaySystemManagerViewModel activityPlaySystemManager, int arg)
	{
	}

	private void FinishR4ChooseMobLevel()
	{
	}

	public override void R5ChooseMobLevel(ActivityPlaySystemManagerViewModel activityPlaySystemManager, Rule5Argu arg)
	{
	}

	private void FinishR5ChooseMobLevel()
	{
	}
}
