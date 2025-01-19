using NodeCanvas.Framework;

public class ValueParam
{
	public enum Type
	{
		TYPE_VALUE = 1,
		TYPE_BLACKBOARD = 2,
		TYPE_TARGET = 3,
		TYPE_TABLE = 4,
		TYPE_TARGET_FACTOR_VALUE = 5
	}

	private Type valueType;

	private float val;

	private BBParameter<float> blackBoardAtrr1;

	private ReleaseTargetParam pm;

	private int valueIndex;

	private string tableArgName;

	private Entity entity;

	public ValueParam(Type valueType, float val, BBParameter<float> blackBoardAtrr1, ReleaseTargetParam pm, int valueIndex, string tableArgName, Entity entity)
	{
	}

	public float GetValue(Type type)
	{
		return 0f;
	}
}
