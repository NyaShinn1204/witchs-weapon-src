using Mono.Cecil.PE;
using Mono.Collections.Generic;

namespace Mono.Cecil.Cil
{
	internal sealed class CodeReader : ByteBuffer
	{
		internal readonly MetadataReader reader;

		private int start;

		private Section code_section;

		private MethodDefinition method;

		private MethodBody body;

		private int Offset
		{
			get
			{
				return 0;
			}
		}

		public CodeReader(Section section, MetadataReader reader)
			: base(null)
		{
		}

		public MethodBody ReadMethodBody(MethodDefinition method)
		{
			return null;
		}

		public void MoveTo(int rva)
		{
		}

		private bool IsInSection(int rva)
		{
			return false;
		}

		private void ReadMethodBody()
		{
		}

		private void ReadFatMethod()
		{
		}

		public VariableDefinitionCollection ReadVariables(MetadataToken local_var_token)
		{
			return null;
		}

		private void ReadCode()
		{
		}

		private OpCode ReadOpCode()
		{
			return default(OpCode);
		}

		private object ReadOperand(Instruction instruction)
		{
			return null;
		}

		public string GetString(MetadataToken token)
		{
			return null;
		}

		public ParameterDefinition GetParameter(int index)
		{
			return null;
		}

		public VariableDefinition GetVariable(int index)
		{
			return null;
		}

		public CallSite GetCallSite(MetadataToken token)
		{
			return null;
		}

		private void ResolveBranches(Collection<Instruction> instructions)
		{
		}

		private Instruction GetInstruction(int offset)
		{
			return null;
		}

		private static Instruction GetInstruction(Collection<Instruction> instructions, int offset)
		{
			return null;
		}

		private void ReadSection()
		{
		}

		private void ReadSmallSection()
		{
		}

		private void ReadFatSection()
		{
		}

		private void ReadExceptionHandlers(int count, Func<int> read_entry, Func<int> read_length)
		{
		}

		private void ReadExceptionHandlerSpecific(ExceptionHandler handler)
		{
		}

		private void Align(int align)
		{
		}

		public MetadataToken ReadToken()
		{
			return default(MetadataToken);
		}
	}
}
