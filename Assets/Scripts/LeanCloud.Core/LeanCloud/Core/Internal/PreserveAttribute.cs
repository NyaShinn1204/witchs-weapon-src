using System;

namespace LeanCloud.Core.Internal
{
	internal class PreserveAttribute : Attribute
	{
		public bool AllMembers;

		public bool Conditional;
	}
}
