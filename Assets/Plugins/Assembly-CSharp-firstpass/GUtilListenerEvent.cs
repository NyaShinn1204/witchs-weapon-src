public class GUtilListenerEvent
{
	public string eventName;

	public object eventArgs;

	public object eventTarget;

	public FunctionListenerEvent eventListener;

	public GUtilListenerEvent clone()
	{
		return null;
	}

	public T GetEventArgs<T>()
	{
		return default(T);
	}

	public T GetEventTarget<T>()
	{
		return default(T);
	}
}
