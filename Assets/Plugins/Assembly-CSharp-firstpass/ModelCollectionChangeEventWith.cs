using System;

[Obsolete]
public class ModelCollectionChangeEventWith<T> : ModelCollectionChangeEvent
{
	public T[] NewItemsOfT
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public T[] OldItemsOfT
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
