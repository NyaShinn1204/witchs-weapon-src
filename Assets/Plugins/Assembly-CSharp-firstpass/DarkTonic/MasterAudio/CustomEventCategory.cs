using System;

namespace DarkTonic.MasterAudio
{
	[Serializable]
	public class CustomEventCategory
	{
		public string CatName;

		public bool IsExpanded;

		public bool IsEditing;

		public bool IsTemporary;

		public string ProspectiveName;
	}
}
