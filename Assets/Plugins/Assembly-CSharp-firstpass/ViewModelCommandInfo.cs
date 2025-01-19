using System;

public class ViewModelCommandInfo
{
	public ICommand Command { get; set; }

	public string Name { get; set; }

	public Type ParameterType { get; set; }

	public ViewModelCommandInfo(string name, ICommand command)
	{
	}

	public ViewModelCommandInfo(Type parameterType, string name, ICommand command)
	{
	}
}
