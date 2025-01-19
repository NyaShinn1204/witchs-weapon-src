using System.Collections.Generic;
using System.Runtime.InteropServices;
using WaterBell.ProjX.Guide.DataModel;

public class RecPointPrepareInfo
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	private struct RecPair
	{
		public int id;

		public int state;
	}

	private Dictionary<int, RecPair> dict;

	public RecPointPrepareInfo(int currRecID, LessonTrigger trigger, RecPointInfo rpInfo)
	{
	}

	public RecPointPrepareInfo(int currRecID, LessonTrigger trigger, int recPointState)
	{
	}

	private void Init(int currRecID, LessonTrigger trigger, int recPointState)
	{
	}

	public void AddPair(int recID, int recState)
	{
	}

	public int[] GetRecIDArr()
	{
		return null;
	}

	public int[] GetRecStateArr()
	{
		return null;
	}

	public string[] GetRecIDStrArr()
	{
		return null;
	}

	public string[] GetRecStateStrArr()
	{
		return null;
	}
}
