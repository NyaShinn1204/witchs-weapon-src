using Mono.Cecil.PE;

namespace Mono.Cecil
{
	internal abstract class ModuleReader
	{
		protected readonly Image image;

		protected readonly ModuleDefinition module;

		protected ModuleReader(Image image, ReadingMode mode)
		{
		}

		protected abstract void ReadModule();

		protected void ReadModuleManifest(MetadataReader reader)
		{
		}

		private void ReadAssembly(MetadataReader reader)
		{
		}

		public static ModuleDefinition CreateModuleFrom(Image image, ReaderParameters parameters)
		{
			return null;
		}

		private static void ReadSymbols(ModuleDefinition module, ReaderParameters parameters)
		{
		}

		private static ModuleDefinition ReadModule(Image image, ReaderParameters parameters)
		{
			return null;
		}

		private static ModuleReader CreateModuleReader(Image image, ReadingMode mode)
		{
			return null;
		}
	}
}
