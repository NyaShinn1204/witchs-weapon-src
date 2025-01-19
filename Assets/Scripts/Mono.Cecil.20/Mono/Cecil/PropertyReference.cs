using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public abstract class PropertyReference : MemberReference
	{
		private TypeReference property_type;

		public TypeReference PropertyType
		{
			get
			{
				return null;
			}
		}

		public abstract Collection<ParameterDefinition> Parameters { get; }

		internal PropertyReference(string name, TypeReference propertyType)
		{
		}
	}
}
