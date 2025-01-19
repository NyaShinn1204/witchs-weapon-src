using System;
using WaterBell.ProjX.Data.Entity;

public class GuildUserManagerController : GuildUserManagerControllerBase
{
	public override void InitializeGuildUserManager(GuildUserManagerViewModel guildUserManager)
	{
	}

	private void UpdateGuild(PropertyChangeedObservable target)
	{
	}

	public override void SearchGuild(GuildUserManagerViewModel guildUserManager, string arg)
	{
	}

	public override void CreateGuild(GuildUserManagerViewModel guildUserManager, GuildCreateArgu arg)
	{
	}

	public override void RequestGuild(GuildUserManagerViewModel guildUserManager, string arg)
	{
	}

	public override void CancelRequest(GuildUserManagerViewModel guildUserManager, string arg)
	{
	}

	private void SuccessfulSearchGuild()
	{
	}

	public void FailedSearchGuild(string text)
	{
	}

	private void SuccessfulCreateGuild()
	{
	}

	public void FailedCreateGuild(string text)
	{
	}

	private void SuccessfulRequestGuild()
	{
	}

	public void FailedRequestGuild(string text)
	{
	}

	private void SuccessfulCancelRequest()
	{
	}

	public void FailedCancelRequest(string text)
	{
	}

	private void dealSearchGuildResult(object sender, EventArgs argu)
	{
	}

	private void dealGetAllResult(object sender, EventArgs argu)
	{
	}

	private void dealRequestGuildResult()
	{
	}

	private void dealCancelRequestGuildResult()
	{
	}

	private void dealCreateGuildResult(GuildCreateArgu arg)
	{
	}

	public override void Synchronize(GuildUserManagerViewModel guildUserManager)
	{
	}

	private void FinishSynchronizeSeq()
	{
	}

	public override void SearchGuildByCE(GuildUserManagerViewModel guildUserManager, int arg)
	{
	}

	public override void GetAllGuild(GuildUserManagerViewModel guildUserManager, int arg)
	{
	}

	public override void SearchGuildByMember(GuildUserManagerViewModel guildUserManager, int arg)
	{
	}
}
