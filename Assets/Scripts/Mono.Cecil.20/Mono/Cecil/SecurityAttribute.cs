using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class SecurityAttribute : ICustomAttribute
	{
		private TypeReference attribute_type;

		internal Collection<CustomAttributeNamedArgument> fields;

		internal Collection<CustomAttributeNamedArgument> properties;
	}
}
