using System.Collections.Generic;
using Mono.Cecil.Metadata;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	internal sealed class TypeDefinitionCollection : Collection<TypeDefinition>
	{
		private readonly ModuleDefinition container;

		private readonly Dictionary<Row<string, string>, TypeDefinition> name_cache;

		internal TypeDefinitionCollection(ModuleDefinition container)
		{
		}

		internal TypeDefinitionCollection(ModuleDefinition container, int capacity)
		{
		}

		protected override void OnAdd(TypeDefinition item, int index)
		{
		}

		protected override void OnSet(TypeDefinition item, int index)
		{
		}

		protected override void OnInsert(TypeDefinition item, int index)
		{
		}

		protected override void OnRemove(TypeDefinition item, int index)
		{
		}

		protected override void OnClear()
		{
		}

		private void Attach(TypeDefinition type)
		{
		}

		private void Detach(TypeDefinition type)
		{
		}

		public TypeDefinition GetType(string fullname)
		{
			return null;
		}

		public TypeDefinition GetType(string @namespace, string name)
		{
			return null;
		}
	}
}
