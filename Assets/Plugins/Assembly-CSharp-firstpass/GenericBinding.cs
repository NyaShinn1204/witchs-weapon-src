using System;

public class GenericBinding : IBinding
{
	public bool IsComponent { get; set; }

	public string ModelMemberName { get; set; }

	public bool TwoWay { get; set; }

	public Action BindAction { get; set; }

	public Action UnbindAction { get; set; }

	public GenericBinding(Action bindAction, Action unbindAction)
	{
	}

	public void Bind()
	{
	}

	public void Unbind()
	{
	}
}
