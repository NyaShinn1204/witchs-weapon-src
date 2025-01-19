namespace Mono.Cecil
{
	public interface IMetadataResolver
	{
		TypeDefinition Resolve(TypeReference type);
	}
}
