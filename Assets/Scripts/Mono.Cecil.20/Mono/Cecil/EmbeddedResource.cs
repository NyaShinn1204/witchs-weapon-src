namespace Mono.Cecil
{
	public sealed class EmbeddedResource : Resource
	{
		private readonly MetadataReader reader;

		private uint? offset;

		internal EmbeddedResource(string name, ManifestResourceAttributes attributes, uint offset, MetadataReader reader)
			: base(null, default(ManifestResourceAttributes))
		{
		}
	}
}
