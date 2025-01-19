using Mono.Collections.Generic;

namespace Mono.Cecil
{
	internal sealed class ParameterDefinitionCollection : Collection<ParameterDefinition>
	{
		private readonly IMethodSignature method;

		internal ParameterDefinitionCollection(IMethodSignature method)
		{
		}

		internal ParameterDefinitionCollection(IMethodSignature method, int capacity)
		{
		}

		protected override void OnAdd(ParameterDefinition item, int index)
		{
		}

		protected override void OnInsert(ParameterDefinition item, int index)
		{
		}

		protected override void OnSet(ParameterDefinition item, int index)
		{
		}

		protected override void OnRemove(ParameterDefinition item, int index)
		{
		}
	}
}
