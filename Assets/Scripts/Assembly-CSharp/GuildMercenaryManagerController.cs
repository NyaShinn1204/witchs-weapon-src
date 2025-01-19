using System;

public class GuildMercenaryManagerController : GuildMercenaryManagerControllerBase
{
	private AddSvArgu addSv;

	private long removeSV;

	private long beforeGuildCurrency;

	private long beforeGold;

	private SelectSvGroup tempSelectSvGroup;

	private HireArgu tempHireArgu;

	public override void InitializeGuildMercenaryManager(GuildMercenaryManagerViewModel guildMercenaryManager)
	{
	}

	private void UpdateGuildMercenary()
	{
	}

	private void UpdatePublicMercenary()
	{
	}

	private void UpdateOwnMercenary()
	{
	}

	public override void AddSv(GuildMercenaryManagerViewModel guildMercenaryManager, AddSvArgu arg)
	{
	}

	private void FinishAddSv()
	{
	}

	public override void RemoveSv(GuildMercenaryManagerViewModel guildMercenaryManager, long arg)
	{
	}

	private void FinishRemoveSv()
	{
	}

	public override void FreshMercenariesList(GuildMercenaryManagerViewModel guildMercenaryManager)
	{
	}

	private void FinishGetAllMercenariesList()
	{
	}

	private void dealGetAllResult(object sender, EventArgs argu)
	{
	}

	public override void FreshCanHireList(GuildMercenaryManagerViewModel guildMercenaryManager)
	{
	}

	private void FinishFreshCanHireList()
	{
	}

	public override void SelectBattleGroup(GuildMercenaryManagerViewModel guildMercenaryManager, SelectSvGroup arg)
	{
	}

	private void FinishSelectBattleGroup()
	{
	}

	private void FailSelectBattleGroup(string text)
	{
	}

	public override void HireMercenary(GuildMercenaryManagerViewModel guildMercenaryManager, SelectSvGroup arg)
	{
	}

	private void FinishHireMercenary()
	{
	}

	private void FailHireMercenary(string text)
	{
	}
}
