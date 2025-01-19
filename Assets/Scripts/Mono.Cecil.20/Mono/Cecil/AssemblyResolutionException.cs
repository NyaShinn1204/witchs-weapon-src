using System.IO;

namespace Mono.Cecil
{
	public class AssemblyResolutionException : FileNotFoundException
	{
		private readonly AssemblyNameReference reference;

		public AssemblyResolutionException(AssemblyNameReference reference)
		{
		}
	}
}
