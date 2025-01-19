public class Condition
{
	public const string TYPE_EQUALS = "==";

	public const string TYPE_MORE_THAN = ">";

	public const string TYPE_MORE_AND_EQUALS_THAN = ">=";

	public const string TYPE_LESS_THAN = "<";

	public const string TYPE_LESS_AND_EQUALS_THAN = "<=";

	public const string TYPE_NOR = "<>";

	private float value1;

	private float value2;

	private string type;

	public Condition(string type, float value1, float value2)
	{
	}

	public bool CheckValid()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
