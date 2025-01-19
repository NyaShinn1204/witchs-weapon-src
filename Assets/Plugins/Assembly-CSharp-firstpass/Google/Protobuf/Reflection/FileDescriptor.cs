using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class FileDescriptor : IDescriptor
	{
		internal readonly FileDescriptorProto Proto;

		public readonly IList<MessageDescriptor> MessageTypes;

		public readonly IList<EnumDescriptor> EnumTypes;

		public readonly IList<ServiceDescriptor> Services;

		public readonly IList<FileDescriptor> Dependencies;

		public readonly IList<FileDescriptor> PublicDependencies;

		public readonly ByteString SerializedData;

		internal readonly DescriptorPool DescriptorPool;

		string IDescriptor.FullName
		{
			get
			{
				return null;
			}
		}

		FileDescriptor IDescriptor.File
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Package
		{
			get
			{
				return null;
			}
		}

		public static FileDescriptor DescriptorProtoFileDescriptor
		{
			get
			{
				return null;
			}
		}

		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
		}

		internal string ComputeFullName(MessageDescriptor parent, string name)
		{
			return null;
		}

		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies)
		{
			return null;
		}

		public T FindTypeByName<T>(string name) where T : class, IDescriptor
		{
			return null;
		}

		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		private void CrossLink()
		{
		}

		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
