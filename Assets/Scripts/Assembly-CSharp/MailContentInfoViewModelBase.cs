public class MailContentInfoViewModelBase : ViewModel
{
	public P<MailInfo> _InfoProperty;

	public P<bool> _ReadedProperty;

	public P<bool> _IsSpecialMailProperty;

	public MailContentInfoViewModelBase(MailContentInfoControllerBase controller, bool initialize = true)
	{
	}

	public MailContentInfoViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
