namespace Slate.ActionClips
{
	public abstract class SendGlobalMessage<T> : SendGlobalMessage
	{
		public T value;

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
	public class SendGlobalMessage : DirectorActionClip
	{
		[Required]
		public string message;

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override bool isValid
		{
			get
			{
				return false;
			}
		}

		protected override void OnEnter()
		{
		}
	}
}
