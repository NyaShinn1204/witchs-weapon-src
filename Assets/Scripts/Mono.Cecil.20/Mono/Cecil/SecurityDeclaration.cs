using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class SecurityDeclaration
	{
		internal readonly uint signature;

		private byte[] blob;

		private readonly ModuleDefinition module;

		internal bool resolved;

		private SecurityAction action;

		internal Collection<SecurityAttribute> security_attributes;

		internal SecurityDeclaration(SecurityAction action, uint signature, ModuleDefinition module)
		{
		}
	}
}
