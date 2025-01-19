using System;

[Obsolete]
public class ModelCollectionChangeEvent
{
	private object[] _newItems;

	private object[] _oldItems;

	public ModelCollectionAction Action { get; set; }

	public object[] NewItems
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public object[] OldItems
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
