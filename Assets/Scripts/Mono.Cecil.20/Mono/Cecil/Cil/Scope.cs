using Mono.Collections.Generic;

namespace Mono.Cecil.Cil
{
	public sealed class Scope : IVariableDefinitionProvider
	{
		private Instruction start;

		private Instruction end;

		private Collection<Scope> scopes;

		private Collection<VariableDefinition> variables;

		public Instruction Start
		{
			set
			{
			}
		}

		public Instruction End
		{
			set
			{
			}
		}

		public Collection<VariableDefinition> Variables
		{
			get
			{
				return null;
			}
		}
	}
}
