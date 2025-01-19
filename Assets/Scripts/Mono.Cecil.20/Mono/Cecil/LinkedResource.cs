namespace Mono.Cecil
{
	public sealed class LinkedResource : Resource
	{
		internal byte[] hash;

		private string file;

		public string File
		{
			set
			{
			}
		}

		public LinkedResource(string name, ManifestResourceAttributes flags)
			: base(null, default(ManifestResourceAttributes))
		{
		}
	}
}
