using System.Runtime.InteropServices;

namespace Mono.Cecil.Cil
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct OpCode
	{
		private readonly byte op1;

		private readonly byte op2;

		private readonly byte code;

		private readonly byte flow_control;

		private readonly byte opcode_type;

		private readonly byte operand_type;

		private readonly byte stack_behavior_pop;

		private readonly byte stack_behavior_push;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public short Value
		{
			get
			{
				return 0;
			}
		}

		public Code Code
		{
			get
			{
				return default(Code);
			}
		}

		public OperandType OperandType
		{
			get
			{
				return default(OperandType);
			}
		}

		internal OpCode(int x, int y)
		{
			op1 = 0;
			op2 = 0;
			code = 0;
			flow_control = 0;
			opcode_type = 0;
			operand_type = 0;
			stack_behavior_pop = 0;
			stack_behavior_push = 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(OpCode one, OpCode other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
