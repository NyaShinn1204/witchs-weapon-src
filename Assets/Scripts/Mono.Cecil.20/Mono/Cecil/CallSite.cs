using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class CallSite : IMethodSignature, IMetadataTokenProvider
	{
		private readonly MethodReference signature;

		public bool HasThis
		{
			set
			{
			}
		}

		public bool ExplicitThis
		{
			set
			{
			}
		}

		public MethodCallingConvention CallingConvention
		{
			set
			{
			}
		}

		public bool HasParameters
		{
			get
			{
				return false;
			}
		}

		public Collection<ParameterDefinition> Parameters
		{
			get
			{
				return null;
			}
		}

		public TypeReference ReturnType
		{
			get
			{
				return null;
			}
		}

		public MethodReturnType MethodReturnType
		{
			get
			{
				return null;
			}
		}

		public MetadataToken MetadataToken
		{
			get
			{
				return default(MetadataToken);
			}
			set
			{
			}
		}

		public string FullName
		{
			get
			{
				return null;
			}
		}

		internal CallSite()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
