using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	internal class TlsStream : Stream
	{
		private readonly TlsProtocol handler;

		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal TlsStream(TlsProtocol handler)
		{
		}

		public override void Close()
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buf, int off, int len)
		{
			return 0;
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buf, int off, int len)
		{
		}

		public override void WriteByte(byte b)
		{
		}
	}
}
