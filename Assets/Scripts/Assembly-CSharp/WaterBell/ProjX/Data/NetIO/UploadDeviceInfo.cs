namespace WaterBell.ProjX.Data.NetIO
{
	public class UploadDeviceInfo : NetMsgBase
	{
		private string deviceInfo;

		public UploadDeviceInfo(string deviceInfo)
		{
		}

		protected override void SetIsCommonAndContentName()
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void SendMsg()
		{
		}

		public override void OnData(string text, string URL, string type, string tag = null)
		{
		}
	}
}
