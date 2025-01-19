using Mono.Collections.Generic;

namespace Mono.Cecil.Cil
{
	internal class InstructionCollection : Collection<Instruction>
	{
		internal InstructionCollection()
		{
		}

		internal InstructionCollection(int capacity)
		{
		}

		protected override void OnAdd(Instruction item, int index)
		{
		}

		protected override void OnInsert(Instruction item, int index)
		{
		}

		protected override void OnSet(Instruction item, int index)
		{
		}

		protected override void OnRemove(Instruction item, int index)
		{
		}
	}
}
