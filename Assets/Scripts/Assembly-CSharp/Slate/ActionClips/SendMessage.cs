namespace Slate.ActionClips
{
	public abstract class SendMessage<T> : SendMessage
	{
		public T value;

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
	public class SendMessage : ActorActionClip
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
