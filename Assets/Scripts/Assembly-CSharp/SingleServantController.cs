using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;

public class SingleServantController : SingleServantControllerBase
{
	private long LastUserGold;

	private List<EquipSlotInfo> equipSlotInfos;

	public override void InitializeSingleServant(SingleServantViewModel singleServant)
	{
	}

	private void AddQuestJob(ObservableJob item)
	{
	}

	private void UpdateJob(PropertyChangeedObservable target)
	{
	}

	private void UpdateJobInfo(ObservableJob current)
	{
	}

	private void RemoveQuestJob(ObservableJob item)
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

	private void UpdatePlayer(PropertyChangeedObservable target)
	{
	}

	private void UpdateEquipCanUseCanCom()
	{
	}

	private void AddItem(ObservableSingleItem item)
	{
	}

	private void RemoveItem(ObservableSingleItem item)
	{
	}

	private void CheckShowStarHint(long itemID)
	{
	}

	private void UpdateItem(PropertyChangeedObservable target)
	{
	}

	private void AddEquip(ObservableSingleItem item)
	{
	}

	private void RemoveEquip(ObservableSingleItem item)
	{
	}

	private void UpdateEquip(PropertyChangeedObservable target)
	{
	}

	private void ServantCardIDChange(long cardid)
	{
	}

	private void UpdateServant(long cardid, bool switchSV = false)
	{
	}

	private void AddServant(ObservableSingleServant sv)
	{
	}

	private void RemoveServant(ObservableSingleServant item)
	{
	}

	private void UpdateCurrentServant(PropertyChangeedObservable target)
	{
	}

	public override void GotoNextServant(SingleServantViewModel singleServant)
	{
	}

	public override void GotoPreServant(SingleServantViewModel singleServant)
	{
	}

	public override void AddRank(SingleServantViewModel singleServant)
	{
	}

	public override void EquipAll(SingleServantViewModel singleServant)
	{
	}

	public override void UseEuip(SingleServantViewModel singleServant, int arg)
	{
	}

	public override void AddExp(SingleServantViewModel singleServant, UseItemArgus arg)
	{
	}

	public override void AddSpellActiveLevel(SingleServantViewModel singleServant, int arg)
	{
	}

	public override void AddSpellPassiveLevel1(SingleServantViewModel singleServant, int arg)
	{
	}

	public override void AddSpellPassiveLevel2(SingleServantViewModel singleServant, int arg)
	{
	}

	public override void ComposeEquip(SingleServantViewModel singleServant, long arg)
	{
	}

	public override void ChangeImage(SingleServantViewModel singleServant, int arg)
	{
	}

	public override void ReceiveImageFav(SingleServantViewModel singleServant, int arg)
	{
	}

	public override void FinishFavQuest(SingleServantViewModel singleServant)
	{
	}
}
