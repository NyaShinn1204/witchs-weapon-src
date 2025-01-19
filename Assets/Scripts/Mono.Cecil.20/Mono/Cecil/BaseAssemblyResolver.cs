using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public abstract class BaseAssemblyResolver : IAssemblyResolver
	{
		private static readonly bool on_mono;

		private readonly Collection<string> directories;

		[CompilerGenerated]
		private AssemblyResolveEventHandler ResolveFailure;

		private AssemblyDefinition GetAssembly(string file, ReaderParameters parameters)
		{
			return null;
		}

		public virtual AssemblyDefinition Resolve(AssemblyNameReference name)
		{
			return null;
		}

		public virtual AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
		{
			return null;
		}

		private AssemblyDefinition SearchDirectory(AssemblyNameReference name, IEnumerable<string> directories, ReaderParameters parameters)
		{
			return null;
		}
	}
}
