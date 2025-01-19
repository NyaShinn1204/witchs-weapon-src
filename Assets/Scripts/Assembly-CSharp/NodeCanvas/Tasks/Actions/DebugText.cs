using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class DebugText : GuideTask
	{
		public string debugInfo;

		public bool isPrintAsError;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}
	}
}
