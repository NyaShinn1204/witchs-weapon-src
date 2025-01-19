using System.Collections.Generic;

public class BuffAbsorbProperty : BuffEntity
{
	public int type;

	public List<Entity> collection;

	private int index;

	private bool isCOntainsAddon;

	private int condition;

	private float val;

	private int indexSelf;

	private int conditionSelf;

	private float rate;

	private int basic;

	private int grow;

	private int maxBasic;

	private int maxGrow;

	public override void OnStart()
	{
	}

	public override void OnDestory()
	{
	}
}
