using System.Collections.Specialized;

public class MailManagerViewModelBase : ViewModel
{
	public P<bool> _HaveNewProperty;

	public P<int> _NotReadNumProperty;

	public ModelCollection<MailContentInfoViewModel> _MailsProperty;

	protected CommandWithSenderAndArgument<MailManagerViewModel, string> _UpdateCommonMailState;

	protected CommandWithSenderAndArgument<MailManagerViewModel, string> _UpdateSpecialMailState;

	protected CommandWithSenderAndArgument<MailManagerViewModel, string> _GetAttach;

	protected CommandWithSenderAndArgument<MailManagerViewModel, string> _DeleteNormal;

	public MailManagerViewModelBase(MailManagerControllerBase controller, bool initialize = true)
	{
	}

	public MailManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void MailsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
