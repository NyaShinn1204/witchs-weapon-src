using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class TypeRegistry
	{
		private class Builder
		{
			private readonly Dictionary<string, MessageDescriptor> types;

			private readonly HashSet<string> fileDescriptorNames;

			internal Builder()
			{
			}

			internal void AddFile(FileDescriptor fileDescriptor)
			{
			}

			private void AddMessage(MessageDescriptor messageDescriptor)
			{
			}

			internal TypeRegistry Build()
			{
				return null;
			}
		}

		public static readonly TypeRegistry Empty;

		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap;

		static TypeRegistry()
		{
		}

		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap)
		{
		}

		public MessageDescriptor Find(string fullName)
		{
			return null;
		}

		public static TypeRegistry FromFiles(params FileDescriptor[] fileDescriptors)
		{
			return null;
		}

		public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors)
		{
			return null;
		}

		public static TypeRegistry FromMessages(params MessageDescriptor[] messageDescriptors)
		{
			return null;
		}

		public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors)
		{
			return null;
		}
	}
}
