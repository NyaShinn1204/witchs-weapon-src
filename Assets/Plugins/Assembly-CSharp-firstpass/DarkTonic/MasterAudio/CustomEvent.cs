using System;

namespace DarkTonic.MasterAudio
{
	[Serializable]
	public class CustomEvent
	{
		public string EventName;

		public string ProspectiveName;

		public bool IsEditing;

		public bool eventExpanded;

		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		public float distanceThreshold;

		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		public int filterModeQty;

		public int frameLastFired;

		public string categoryName;

		public CustomEvent(string eventName)
		{
		}
	}
}
