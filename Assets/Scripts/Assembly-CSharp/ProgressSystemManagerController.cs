using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class ProgressSystemManagerController : ProgressSystemManagerControllerBase
{
	public override void InitializeProgressSystemManager(ProgressSystemManagerViewModel progressSystemManager)
	{
	}

	private void UpdateFavNewUnlockMainLevel(long value)
	{
	}

	private void UpdateObservableSetWeaoponTime(int value)
	{
	}

	private void InitMainChapters()
	{
	}

	private void InitDailyChapters()
	{
	}

	private void InitWeaponDailyChapters()
	{
	}

	private void AddItem(ObservableSingleChapter item)
	{
	}

	private void RemoveItem(ObservableSingleChapter item)
	{
	}

	private void UpdateItem(PropertyChangeedObservable target)
	{
	}

	private void AddDailyItem(ObservableSingleChapter item)
	{
	}

	private void AddWeaponDailyItem(ObservableSingleChapter item)
	{
	}

	private void RemoveDailyItem(ObservableSingleChapter item)
	{
	}

	private void UpdateDailyItem(PropertyChangeedObservable target)
	{
	}

	private void UpdateWeaponDailyItem(PropertyChangeedObservable target)
	{
	}

	public override void SelectlLevelByID(ProgressSystemManagerViewModel progressSystemManager, long arg)
	{
	}

	public override void ResetBattleCount(ProgressSystemManagerViewModel progressSystemManager)
	{
	}

	public override void ResetBattleCountByID(ProgressSystemManagerViewModel progressSystemManager, long arg)
	{
	}

	public override void Sweep(ProgressSystemManagerViewModel progressSystemManager, SweepArgu arg)
	{
	}

	public void SuccessfulSweep()
	{
	}

	private void AfterGetQuest()
	{
	}

	public void FailedSweep(string text)
	{
	}

	public override void SetTargetWeapon(ProgressSystemManagerViewModel progressSystemManager, long arg)
	{
	}

	private void dealResult(long id, int time, int exp, int stamina, RepeatedField<Lootmod.LootResult> lootResults)
	{
	}
}
