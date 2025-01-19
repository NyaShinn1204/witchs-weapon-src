namespace Mono.Cecil
{
	public class MetadataResolver : IMetadataResolver
	{
		private readonly IAssemblyResolver assembly_resolver;

		public MetadataResolver(IAssemblyResolver assemblyResolver)
		{
		}

		public virtual TypeDefinition Resolve(TypeReference type)
		{
			return null;
		}

		private static TypeDefinition GetType(ModuleDefinition module, TypeReference reference)
		{
			return null;
		}

		private static TypeDefinition GetTypeDefinition(ModuleDefinition module, TypeReference type)
		{
			return null;
		}
	}
}
