public class BuffAttribute : BuffEntity
{
	public const int TYPE_ADD = 1;

	public const int TYPE_MULTY = 2;

	private int type;

	private int OAttrIndex;

	private int OBAttrIndex;

	private float AttrMP;

	private float AttrMV;

	private float MAttrMV;

	private int tag1;

	private int OAttrIndex2;

	private int OBAttrIndex2;

	private float AttrMP2;

	private float AttrMV2;

	private float MAttrMV2;

	private int tag2;

	private int OAttrIndex3;

	private int OBAttrIndex3;

	private float AttrMP3;

	private float AttrMV3;

	private float MAttrMV3;

	private int tag3;

	private float[] addonArr;

	private int[] indexArr;

	private int[] tagArr;

	public override void OnStart()
	{
	}

	protected override void AfterInit(int beforeLayerCount, int afterLayerCount)
	{
	}

	private void DoAddMethod(int OAttrIndex, int OBAttrIndex, float AttrMP, float AttrMV, float MAttrMV, int tag, int groupIndex, int beforeLayerCount, int afterLayerCount)
	{
	}

	private void SetValue(float FAttr, int groupIndex, int tag, int attrIndex)
	{
	}

	private void DoMutiplyMethod(int OAttrIndex, int OBAttrIndex, float AttrMP, float AttrMV, float MAttrMV, int tag, int groupIndex, int beforeLayerCount, int afterLayerCount)
	{
	}

	public override void OnDestory()
	{
	}

	private bool IsFloatEqual(float a, float b)
	{
		return false;
	}

	public float GetValue(int index, float value)
	{
		return 0f;
	}
}
