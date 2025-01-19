using System.Xml;

public class DeclearPhase : VariablePhase
{
	public string id;

	public float value;

	public int type;

	public DeclearPhase()
	{
	}

	public DeclearPhase(NameSpace field)
	{
	}

	public DeclearPhase(string id, float value, int type, NameSpace fields)
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
