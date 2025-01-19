using Mono.Collections.Generic;

namespace Mono.Cecil
{
	internal sealed class GenericParameterCollection : Collection<GenericParameter>
	{
		private readonly IGenericParameterProvider owner;

		internal GenericParameterCollection(IGenericParameterProvider owner)
		{
		}

		internal GenericParameterCollection(IGenericParameterProvider owner, int capacity)
		{
		}

		protected override void OnAdd(GenericParameter item, int index)
		{
		}

		protected override void OnInsert(GenericParameter item, int index)
		{
		}

		protected override void OnSet(GenericParameter item, int index)
		{
		}

		private void UpdateGenericParameter(GenericParameter item, int index)
		{
		}

		protected override void OnRemove(GenericParameter item, int index)
		{
		}
	}
}
