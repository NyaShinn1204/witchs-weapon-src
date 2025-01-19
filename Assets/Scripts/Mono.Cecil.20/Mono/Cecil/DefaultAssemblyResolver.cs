using System.Collections.Generic;

namespace Mono.Cecil
{
	public class DefaultAssemblyResolver : BaseAssemblyResolver
	{
		private readonly IDictionary<string, AssemblyDefinition> cache;

		public override AssemblyDefinition Resolve(AssemblyNameReference name)
		{
			return null;
		}
	}
}
