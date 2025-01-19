using Mono.Cecil.PE;

namespace Mono.Cecil
{
	internal sealed class DeferredModuleReader : ModuleReader
	{
		public DeferredModuleReader(Image image)
			: base(null, default(ReadingMode))
		{
		}

		protected override void ReadModule()
		{
		}
	}
}
