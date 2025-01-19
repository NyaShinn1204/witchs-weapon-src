namespace Google.Protobuf.Reflection
{
	public sealed class EnumValueDescriptor : DescriptorBase
	{
		private readonly EnumDescriptor enumDescriptor;

		private readonly EnumValueDescriptorProto proto;

		internal EnumValueDescriptorProto Proto
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

		public int Number
		{
			get
			{
				return 0;
			}
		}

		public EnumDescriptor EnumDescriptor
		{
			get
			{
				return null;
			}
		}

		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index)
			: base(null, null, 0)
		{
		}
	}
}
