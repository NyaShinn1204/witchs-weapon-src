namespace Mono.Cecil
{
	public interface IMemberDefinition : ICustomAttributeProvider, IMetadataTokenProvider
	{
		string Name { get; }

		bool IsSpecialName { get; }

		TypeDefinition DeclaringType { get; set; }
	}
}
