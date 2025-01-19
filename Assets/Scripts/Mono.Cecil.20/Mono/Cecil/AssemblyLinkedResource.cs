namespace Mono.Cecil
{
	public sealed class AssemblyLinkedResource : Resource
	{
		private AssemblyNameReference reference;

		public AssemblyNameReference Assembly
		{
			set
			{
			}
		}

		public AssemblyLinkedResource(string name, ManifestResourceAttributes flags)
			: base(null, default(ManifestResourceAttributes))
		{
		}
	}
}
