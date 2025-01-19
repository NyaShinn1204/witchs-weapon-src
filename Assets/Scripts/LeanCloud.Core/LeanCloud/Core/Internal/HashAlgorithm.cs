using System;
using System.IO;

namespace LeanCloud.Core.Internal
{
	public abstract class HashAlgorithm : IDisposable
	{
		protected int HashSizeValue;

		protected internal byte[] HashValue;

		protected int State;

		private bool m_bDisposed;

		public virtual int HashSize
		{
			get
			{
				return 0;
			}
		}

		public virtual int InputBlockSize
		{
			get
			{
				return 0;
			}
		}

		public virtual int OutputBlockSize
		{
			get
			{
				return 0;
			}
		}

		public virtual bool CanTransformMultipleBlocks
		{
			get
			{
				return false;
			}
		}

		public virtual bool CanReuseTransform
		{
			get
			{
				return false;
			}
		}

		public byte[] ComputeHash(Stream inputStream)
		{
			return null;
		}

		public byte[] ComputeHash(byte[] buffer)
		{
			return null;
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public abstract void Initialize();

		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		protected abstract byte[] HashFinal();
	}
}
