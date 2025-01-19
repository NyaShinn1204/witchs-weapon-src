using System.Xml;

public class SetValuePhase : VariablePhase
{
	public string name;

	public float value;

	public SetValuePhase()
	{
	}

	public SetValuePhase(NameSpace field)
	{
	}

	public SetValuePhase(string name, float value, NameSpace fields)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
