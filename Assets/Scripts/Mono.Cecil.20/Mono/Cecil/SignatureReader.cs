using Mono.Cecil.Metadata;
using Mono.Cecil.PE;

namespace Mono.Cecil
{
	internal sealed class SignatureReader : ByteBuffer
	{
		private readonly MetadataReader reader;

		private readonly uint start;

		private readonly uint sig_length;

		private TypeSystem TypeSystem
		{
			get
			{
				return null;
			}
		}

		public SignatureReader(uint blob, MetadataReader reader)
			: base(null)
		{
		}

		private void MoveToBlob(uint blob)
		{
		}

		private MetadataToken ReadTypeTokenSignature()
		{
			return default(MetadataToken);
		}

		private GenericParameter GetGenericParameter(GenericParameterType type, uint var)
		{
			return null;
		}

		private GenericParameter GetUnboundGenericParameter(GenericParameterType type, int index)
		{
			return null;
		}

		private static void CheckGenericContext(IGenericParameterProvider owner, int index)
		{
		}

		public void ReadGenericInstanceSignature(IGenericParameterProvider provider, IGenericInstance instance)
		{
		}

		private ArrayType ReadArrayTypeSignature()
		{
			return null;
		}

		private TypeReference GetTypeDefOrRef(MetadataToken token)
		{
			return null;
		}

		public TypeReference ReadTypeSignature()
		{
			return null;
		}

		private TypeReference ReadTypeSignature(ElementType etype)
		{
			return null;
		}

		public void ReadMethodSignature(IMethodSignature method)
		{
		}

		public object ReadConstantSignature(ElementType type)
		{
			return null;
		}

		private object ReadPrimitiveValue(ElementType type)
		{
			return null;
		}

		private TypeReference GetPrimitiveType(ElementType etype)
		{
			return null;
		}

		public TypeReference ReadTypeReference()
		{
			return null;
		}

		public MarshalInfo ReadMarshalInfo()
		{
			return null;
		}

		private NativeType ReadNativeType()
		{
			return default(NativeType);
		}

		private VariantType ReadVariantType()
		{
			return default(VariantType);
		}

		private string ReadUTF8String()
		{
			return null;
		}

		public bool CanReadMore()
		{
			return false;
		}
	}
}
