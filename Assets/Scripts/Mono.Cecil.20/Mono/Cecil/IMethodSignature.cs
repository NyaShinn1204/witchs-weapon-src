using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public interface IMethodSignature : IMetadataTokenProvider
	{
		bool HasThis { set; }

		bool ExplicitThis { set; }

		MethodCallingConvention CallingConvention { set; }

		bool HasParameters { get; }

		Collection<ParameterDefinition> Parameters { get; }

		MethodReturnType MethodReturnType { get; }
	}
}
