using System.ComponentModel;

namespace LeanCloud
{
	public class PropertyUpdatedEventArgs : PropertyChangedEventArgs
	{
		public object OldValue { get; private set; }

		public object NewValue { get; private set; }

		public PropertyUpdatedEventArgs(string propertyName, object oldValue, object newValue)
			: base(null)
		{
		}
	}
}
