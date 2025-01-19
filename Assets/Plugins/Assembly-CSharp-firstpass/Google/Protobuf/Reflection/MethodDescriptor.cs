namespace Google.Protobuf.Reflection
{
	public sealed class MethodDescriptor : DescriptorBase
	{
		private readonly MethodDescriptorProto proto;

		private readonly ServiceDescriptor service;

		private MessageDescriptor inputType;

		private MessageDescriptor outputType;

		public ServiceDescriptor Service
		{
			get
			{
				return null;
			}
		}

		public MessageDescriptor InputType
		{
			get
			{
				return null;
			}
		}

		public MessageDescriptor OutputType
		{
			get
			{
				return null;
			}
		}

		public bool IsClientStreaming
		{
			get
			{
				return false;
			}
		}

		public bool IsServerStreaming
		{
			get
			{
				return false;
			}
		}

		internal MethodDescriptorProto Proto
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
		}

		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index)
			: base(null, null, 0)
		{
		}

		internal void CrossLink()
		{
		}
	}
}
