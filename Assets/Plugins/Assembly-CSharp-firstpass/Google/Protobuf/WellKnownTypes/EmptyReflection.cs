using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public static class EmptyReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		static EmptyReflection()
		{
		}
	}
}
