using System;

namespace LeanCloud.Storage.Internal
{
	internal class PreserveAttribute : Attribute
	{
		public bool AllMembers;

		public bool Conditional;
	}
}
