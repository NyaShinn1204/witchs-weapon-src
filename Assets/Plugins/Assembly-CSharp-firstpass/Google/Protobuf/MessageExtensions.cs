using System.IO;

namespace Google.Protobuf
{
	public static class MessageExtensions
	{
		public static void MergeFrom(this IMessage message, byte[] data)
		{
		}

		public static void MergeFrom(this IMessage message, ByteString data)
		{
		}

		public static void MergeFrom(this IMessage message, Stream input)
		{
		}

		public static void MergeDelimitedFrom(this IMessage message, Stream input)
		{
		}

		public static byte[] ToByteArray(this IMessage message)
		{
			return null;
		}

		public static void WriteTo(this IMessage message, Stream output)
		{
		}

		public static void WriteDelimitedTo(this IMessage message, Stream output)
		{
		}

		public static ByteString ToByteString(this IMessage message)
		{
			return null;
		}
	}
}
