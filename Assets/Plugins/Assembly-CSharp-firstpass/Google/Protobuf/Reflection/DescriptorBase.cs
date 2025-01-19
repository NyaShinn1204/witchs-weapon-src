namespace Google.Protobuf.Reflection
{
	public abstract class DescriptorBase : IDescriptor
	{
		private readonly FileDescriptor file;

		private readonly string fullName;

		private readonly int index;

		public int Index
		{
			get
			{
				return 0;
			}
		}

		public abstract string Name { get; }

		public string FullName
		{
			get
			{
				return null;
			}
		}

		public FileDescriptor File
		{
			get
			{
				return null;
			}
		}

		internal DescriptorBase(FileDescriptor file, string fullName, int index)
		{
		}
	}
}
