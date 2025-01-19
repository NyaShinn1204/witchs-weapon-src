using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google.Protobuf
{
	public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString>, IEnumerable
	{
		internal static class Unsafe
		{
			internal static ByteString FromBytes(byte[] bytes)
			{
				return null;
			}

			internal static byte[] GetBuffer(ByteString bytes)
			{
				return null;
			}
		}

		private static readonly ByteString empty;

		private readonly byte[] bytes;

		public static ByteString Empty
		{
			get
			{
				return null;
			}
		}

		public int Length
		{
			get
			{
				return 0;
			}
		}

		public bool IsEmpty
		{
			get
			{
				return false;
			}
		}

		public byte Item
		{
			get
			{
				return 0;
			}
		}

		private ByteString(byte[] bytes)
		{
		}

		internal static ByteString AttachBytes(byte[] bytes)
		{
			return null;
		}

		public byte[] ToByteArray()
		{
			return null;
		}

		public string ToBase64()
		{
			return null;
		}

		public static ByteString FromBase64(string bytes)
		{
			return null;
		}

		public static ByteString CopyFrom(params byte[] bytes)
		{
			return null;
		}

		public static ByteString CopyFrom(byte[] bytes, int offset, int count)
		{
			return null;
		}

		public static ByteString CopyFrom(string text, Encoding encoding)
		{
			return null;
		}

		public static ByteString CopyFromUtf8(string text)
		{
			return null;
		}

		public string ToString(Encoding encoding)
		{
			return null;
		}

		public string ToStringUtf8()
		{
			return null;
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public CodedInputStream CreateCodedInput()
		{
			return null;
		}

		public static bool operator ==(ByteString lhs, ByteString rhs)
		{
			return false;
		}

		public static bool operator !=(ByteString lhs, ByteString rhs)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(ByteString other)
		{
			return false;
		}

		internal void WriteRawBytesTo(CodedOutputStream outputStream)
		{
		}

		public void CopyTo(byte[] array, int position)
		{
		}

		public void WriteTo(Stream outputStream)
		{
		}
	}
}
