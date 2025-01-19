using System.Collections;
using System.Collections.Generic;

namespace WebSocketSharp
{
	internal class PayloadData : IEnumerable<byte>, IEnumerable
	{
		private ushort _code;

		private bool _codeSet;

		private byte[] _data;

		private long _extDataLength;

		private long _length;

		private string _reason;

		private bool _reasonSet;

		public static readonly PayloadData Empty;

		public static readonly ulong MaxLength;

		internal ushort Code
		{
			get
			{
				return 0;
			}
		}

		internal bool HasReservedCode
		{
			get
			{
				return false;
			}
		}

		internal string Reason
		{
			get
			{
				return null;
			}
		}

		public byte[] ApplicationData
		{
			get
			{
				return null;
			}
		}

		public ulong Length
		{
			get
			{
				return 0uL;
			}
		}

		static PayloadData()
		{
		}

		internal PayloadData()
		{
		}

		internal PayloadData(byte[] data)
		{
		}

		internal PayloadData(byte[] data, long length)
		{
		}

		internal PayloadData(ushort code, string reason)
		{
		}

		internal void Mask(byte[] key)
		{
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		public byte[] ToArray()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
