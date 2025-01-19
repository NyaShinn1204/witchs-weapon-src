using System.Runtime.InteropServices;

namespace Mono.Cecil.Cil
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate Instruction InstructionMapper(int offset);
}
