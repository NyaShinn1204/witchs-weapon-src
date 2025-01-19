using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public abstract class MethodSpecification : MethodReference
	{
		private readonly MethodReference method;

		public MethodReference ElementMethod
		{
			get
			{
				return null;
			}
		}

		public override string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override MethodCallingConvention CallingConvention
		{
			set
			{
			}
		}

		public override bool HasThis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool ExplicitThis
		{
			set
			{
			}
		}

		public override MethodReturnType MethodReturnType
		{
			get
			{
				return null;
			}
		}

		public override TypeReference DeclaringType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override ModuleDefinition Module
		{
			get
			{
				return null;
			}
		}

		public override bool HasParameters
		{
			get
			{
				return false;
			}
		}

		public override Collection<ParameterDefinition> Parameters
		{
			get
			{
				return null;
			}
		}

		internal override bool ContainsGenericParameter
		{
			get
			{
				return false;
			}
		}

		internal MethodSpecification(MethodReference method)
		{
		}
	}
}
