using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public interface IGenericInstance : IMetadataTokenProvider
	{
		Collection<TypeReference> GenericArguments { get; }
	}
}
