namespace ParadoxNotion
{
	public class EventData
	{
		public string name;

		public object value
		{
			get
			{
				return null;
			}
		}

		public EventData(string name)
		{
		}

		protected virtual object GetValue()
		{
			return null;
		}
	}
	public class EventData<T> : EventData
	{
		public new T value { get; private set; }

		public EventData(string name, T value)
			: base(null)
		{
		}

		protected override object GetValue()
		{
			return null;
		}
	}
}
