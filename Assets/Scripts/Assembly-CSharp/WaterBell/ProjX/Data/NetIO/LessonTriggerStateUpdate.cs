namespace WaterBell.ProjX.Data.NetIO
{
	public class LessonTriggerStateUpdate : NetMsgBase
	{
		private int[] recIDArr;

		private int[] recStateArr;

		public LessonTriggerStateUpdate(int[] idArr, int[] stateArr)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnInternalError(string detail)
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}
	}
}
