namespace Mono.Cecil
{
	public interface IMetadataScope : IMetadataTokenProvider
	{
		MetadataScopeType MetadataScopeType { get; }
	}
}
