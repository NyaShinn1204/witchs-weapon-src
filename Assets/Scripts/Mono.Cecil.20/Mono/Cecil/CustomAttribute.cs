using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class CustomAttribute : ICustomAttribute
	{
		internal readonly uint signature;

		internal bool resolved;

		private MethodReference constructor;

		private byte[] blob;

		internal Collection<CustomAttributeArgument> arguments;

		internal Collection<CustomAttributeNamedArgument> fields;

		internal Collection<CustomAttributeNamedArgument> properties;

		internal CustomAttribute(uint signature, MethodReference constructor)
		{
		}
	}
}
