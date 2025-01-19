using System.Collections.Generic;

public class BuffSharpAttribute : BuffEntity
{
	private BuildPowerAndSharp stateInfo;

	private Dictionary<long, SharpData> ChangeData;

	private float sharpMaxRate;

	private float sharpMaxValue;

	private float recoveryRate;

	private float recoveryValue;

	private float reduceRate;

	private float reduceValue;

	private float attackReduceRate;

	private float attackReduceValue;

	private float hitReduceRate;

	private float hitReduceValue;

	private float _sharpMax;

	private float _recovery;

	private float _reduce;

	private float _attackReduce;

	private float _hitReduce;

	public override void OnStart()
	{
	}

	protected override void AfterInit(int beforeLayerCount, int afterLayerCount)
	{
	}

	public override void OnDestory()
	{
	}
}
