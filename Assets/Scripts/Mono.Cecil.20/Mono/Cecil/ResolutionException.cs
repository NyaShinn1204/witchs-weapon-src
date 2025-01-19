using System;

namespace Mono.Cecil
{
	public class ResolutionException : Exception
	{
		private readonly MemberReference member;

		public ResolutionException(MemberReference member)
		{
		}
	}
}
