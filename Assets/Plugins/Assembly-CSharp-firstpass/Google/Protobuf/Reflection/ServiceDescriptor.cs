using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class ServiceDescriptor : DescriptorBase
	{
		private readonly ServiceDescriptorProto proto;

		private readonly IList<MethodDescriptor> methods;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		internal ServiceDescriptorProto Proto
		{
			get
			{
				return null;
			}
		}

		public IList<MethodDescriptor> Methods
		{
			get
			{
				return null;
			}
		}

		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index)
			: base(null, null, 0)
		{
		}

		public MethodDescriptor FindMethodByName(string name)
		{
			return null;
		}

		internal void CrossLink()
		{
		}
	}
}
