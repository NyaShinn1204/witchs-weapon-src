using Mono.Collections.Generic;

namespace Mono.Cecil
{
	internal class MemberDefinitionCollection<T> : Collection<T> where T : IMemberDefinition
	{
		private TypeDefinition container;

		internal MemberDefinitionCollection(TypeDefinition container)
		{
		}

		internal MemberDefinitionCollection(TypeDefinition container, int capacity)
		{
		}

		protected override void OnAdd(T item, int index)
		{
		}

		protected sealed override void OnSet(T item, int index)
		{
		}

		protected sealed override void OnInsert(T item, int index)
		{
		}

		protected sealed override void OnRemove(T item, int index)
		{
		}

		protected sealed override void OnClear()
		{
		}

		private void Attach(T element)
		{
		}

		private static void Detach(T element)
		{
		}
	}
}
