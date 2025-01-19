using Mono.Collections.Generic;

namespace Mono.Cecil.Cil
{
	public sealed class MethodBody : IVariableDefinitionProvider
	{
		internal readonly MethodDefinition method;

		internal ParameterDefinition this_parameter;

		internal int max_stack_size;

		internal int code_size;

		internal bool init_locals;

		internal MetadataToken local_var_token;

		internal Collection<Instruction> instructions;

		internal Collection<ExceptionHandler> exceptions;

		internal Collection<VariableDefinition> variables;

		private Scope scope;

		public MethodDefinition Method
		{
			get
			{
				return null;
			}
		}

		public int MaxStackSize
		{
			set
			{
			}
		}

		public Collection<Instruction> Instructions
		{
			get
			{
				return null;
			}
		}

		public bool HasExceptionHandlers
		{
			get
			{
				return false;
			}
		}

		public Collection<ExceptionHandler> ExceptionHandlers
		{
			get
			{
				return null;
			}
		}

		public bool HasVariables
		{
			get
			{
				return false;
			}
		}

		public Collection<VariableDefinition> Variables
		{
			get
			{
				return null;
			}
		}

		public Scope Scope
		{
			set
			{
			}
		}

		public ParameterDefinition ThisParameter
		{
			get
			{
				return null;
			}
		}

		private static ParameterDefinition ThisParameterFor(MethodDefinition method)
		{
			return null;
		}

		public MethodBody(MethodDefinition method)
		{
		}
	}
}
