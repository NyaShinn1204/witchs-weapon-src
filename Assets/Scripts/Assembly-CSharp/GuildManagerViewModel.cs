using System.Collections.Generic;

public class GuildManagerViewModel : GuildManagerViewModelBase
{
	public virtual P<string> IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string ID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<long> PresidentProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long President
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<string> NameProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<string> SloganProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string Slogan
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<string> NoticeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string Notice
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<int> LivenessProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Liveness
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<string> IsSilentProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string IsSilent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<long> RecallTimeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long RecallTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> RecallMemberProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long RecallMember
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<string> EmblemProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string Emblem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<int> PrivilegeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Privilege
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<GuildOpArgu> OperationArguProperty
	{
		get
		{
			return null;
		}
	}

	public virtual GuildOpArgu OperationArgu
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<int> OperationResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int OperationResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> VitalitiesProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Vitalities
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> DonateTimeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int DonateTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<string> EmblemBorderProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string EmblemBorder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<string> EmblemBackgroundProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string EmblemBackground
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<int> TotalVitalityProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int TotalVitality
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> DailyVitalityProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int DailyVitality
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> emblemColorProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int emblemColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> emblemborderColorProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int emblemborderColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> emblembackgroundColorProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int emblembackgroundColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<long> CombatEffectivenessProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long CombatEffectiveness
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> RequestUserNumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int RequestUserNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<RequestMember> RequestUsers
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<GuildMember> GuildMember
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<long> Admins
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<GuildManagerViewModel, GuildOpArgu> OperateGuild
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> FinishOperation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> RefreshGuildInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> SyncAfterDismiss
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> FinishSyncAfterDismiss
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> SyncMember
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> AfterSyncMember
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> SyncRequest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<GuildManagerViewModel> AfterSyncRequest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GuildManagerViewModel(GuildManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public GuildManagerViewModel()
		: base(null, false)
	{
	}

	protected override void WireCommands(Controller controller)
	{
	}

	public override void Write(ISerializerStream stream)
	{
	}

	public override void Read(ISerializerStream stream)
	{
	}

	public override void Unbind()
	{
	}

	protected override void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected override void FillCommands(List<ViewModelCommandInfo> list)
	{
	}
}
