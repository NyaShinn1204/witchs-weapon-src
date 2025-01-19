namespace Mono.Cecil
{
	public abstract class EventReference : MemberReference
	{
		private TypeReference event_type;

		public override string FullName
		{
			get
			{
				return null;
			}
		}

		protected EventReference(string name, TypeReference eventType)
		{
		}
	}
}
