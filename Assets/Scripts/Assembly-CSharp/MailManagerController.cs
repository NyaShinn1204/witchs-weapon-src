using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;

public class MailManagerController : MailManagerControllerBase
{
	private List<LootList> currLootList2Add;

	private string currMailID2Del;

	private string normalMailID2Del;

	public override void InitializeMailManager(MailManagerViewModel mailManager)
	{
	}

	private void UpdateHaveNewMail(bool value)
	{
	}

	private void UpdateNewMailNum(int value)
	{
	}

	private void AddCommonMail(ObservableSingleMail item)
	{
	}

	private void RemoveCommonMail(ObservableSingleMail item)
	{
	}

	private void AddSpecialMail(ObservableSingleMail item)
	{
	}

	private void RemoveSpecialMail(ObservableSingleMail item)
	{
	}

	private void UpdateItem(PropertyChangeedObservable target)
	{
	}

	public override void UpdateCommonMailState(MailManagerViewModel mailManager, string arg)
	{
	}

	public override void UpdateSpecialMailState(MailManagerViewModel mailManager, string arg)
	{
	}

	public override void GetAttach(MailManagerViewModel mailManager, string mailID)
	{
	}

	public override void DeleteNormal(MailManagerViewModel mailManager, string arg)
	{
	}

	private void finishDeleteNormal()
	{
	}

	private void TryFetchLootAndClearMail()
	{
	}
}
