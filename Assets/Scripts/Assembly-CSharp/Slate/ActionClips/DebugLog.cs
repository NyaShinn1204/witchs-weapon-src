namespace Slate.ActionClips
{
	public class DebugLog : DirectorActionClip
	{
		public string text;

		public override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}
	}
}
