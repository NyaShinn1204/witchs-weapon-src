using WaterBell.ProjX.Data.Entity;

public class GuildManagerController : GuildManagerControllerBase
{
	private GuildOperateEnum LastOP;

	public override void InitializeGuildManager(GuildManagerViewModel guildManager)
	{
	}

	private void UpdateGuildMember()
	{
	}

	private void UpdateRequestMember()
	{
	}

	private void UpdateGuild(PropertyChangeedObservable target)
	{
	}

	private void UpdateGuildContent()
	{
	}

	public override void OperateGuild(GuildManagerViewModel guildManager, GuildOpArgu arg)
	{
	}

	private void dealOperateGuildResult()
	{
	}

	private void SuccessfulOperateGuild()
	{
	}

	public void FailedOperateGuild(string text)
	{
	}

	public override void SyncAfterDismiss(GuildManagerViewModel guildManager)
	{
	}

	private void SuccessfuSyncAfterDismiss()
	{
	}

	public override void SyncMember(GuildManagerViewModel guildManager)
	{
	}

	public override void SyncRequest(GuildManagerViewModel guildManager)
	{
	}

	private void SuccessfulSyncMember()
	{
	}

	private void SuccessfulSyncRequest()
	{
	}
}
