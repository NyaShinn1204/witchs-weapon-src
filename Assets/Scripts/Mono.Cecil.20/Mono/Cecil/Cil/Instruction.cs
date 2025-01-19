using System.Text;

namespace Mono.Cecil.Cil
{
	public sealed class Instruction
	{
		internal int offset;

		internal OpCode opcode;

		internal object operand;

		internal Instruction previous;

		internal Instruction next;

		private SequencePoint sequence_point;

		public int Offset
		{
			get
			{
				return 0;
			}
		}

		public OpCode OpCode
		{
			get
			{
				return default(OpCode);
			}
		}

		public object Operand
		{
			get
			{
				return null;
			}
		}

		public Instruction Previous
		{
			get
			{
				return null;
			}
		}

		public SequencePoint SequencePoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Instruction(int offset, OpCode opCode)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static void AppendLabel(StringBuilder builder, Instruction instruction)
		{
		}
	}
}
