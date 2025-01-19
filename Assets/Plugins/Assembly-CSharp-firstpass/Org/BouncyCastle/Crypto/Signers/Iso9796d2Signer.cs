using System;

namespace Org.BouncyCastle.Crypto.Signers
{
	public class Iso9796d2Signer : ISignerWithRecovery, ISigner
	{
		[Obsolete]
		public const int TrailerImplicit = 188;

		[Obsolete]
		public const int TrailerRipeMD160 = 12748;

		[Obsolete]
		public const int TrailerRipeMD128 = 13004;

		[Obsolete]
		public const int TrailerSha1 = 13260;

		[Obsolete]
		public const int TrailerSha256 = 13516;

		[Obsolete]
		public const int TrailerSha512 = 13772;

		[Obsolete]
		public const int TrailerSha384 = 14028;

		[Obsolete]
		public const int TrailerWhirlpool = 14284;

		private IDigest digest;

		private IAsymmetricBlockCipher cipher;

		private int trailer;

		private int keyBits;

		private byte[] block;

		private byte[] mBuf;

		private int messageLength;

		private bool fullMessage;

		private byte[] recoveredMessage;

		private byte[] preSig;

		private byte[] preBlock;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest, bool isImplicit)
		{
		}

		public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest)
		{
		}

		public byte[] GetRecoveredMessage()
		{
			return null;
		}

		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		private bool IsSameAs(byte[] a, byte[] b)
		{
			return false;
		}

		private void ClearBlock(byte[] block)
		{
		}

		public virtual void UpdateWithRecoveredMessage(byte[] signature)
		{
		}

		public virtual void Update(byte input)
		{
		}

		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		public virtual void Reset()
		{
		}

		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		public virtual bool VerifySignature(byte[] signature)
		{
			return false;
		}

		private bool ReturnFalse(byte[] block)
		{
			return false;
		}

		public virtual bool HasFullMessage()
		{
			return false;
		}
	}
}
