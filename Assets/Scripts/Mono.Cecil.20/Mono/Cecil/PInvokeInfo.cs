namespace Mono.Cecil
{
	public sealed class PInvokeInfo
	{
		private ushort attributes;

		private string entry_point;

		private ModuleReference module;

		public PInvokeInfo(PInvokeAttributes attributes, string entryPoint, ModuleReference module)
		{
		}
	}
}
