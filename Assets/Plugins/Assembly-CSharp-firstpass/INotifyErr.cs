public interface INotifyErr
{
	void notifyError(int param = 0);

	void notifyTimeout();

	void notifyAbort();
}
