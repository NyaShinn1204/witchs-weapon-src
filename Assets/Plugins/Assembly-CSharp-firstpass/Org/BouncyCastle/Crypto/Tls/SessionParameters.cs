using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	public sealed class SessionParameters
	{
		public sealed class Builder
		{
			private int mCipherSuite;

			private short mCompressionAlgorithm;

			private byte[] mMasterSecret;

			private Certificate mPeerCertificate;

			private byte[] mPskIdentity;

			private byte[] mSrpIdentity;

			private byte[] mEncodedServerExtensions;

			public SessionParameters Build()
			{
				return null;
			}

			public Builder SetCipherSuite(int cipherSuite)
			{
				return null;
			}

			public Builder SetCompressionAlgorithm(byte compressionAlgorithm)
			{
				return null;
			}

			public Builder SetMasterSecret(byte[] masterSecret)
			{
				return null;
			}

			public Builder SetPeerCertificate(Certificate peerCertificate)
			{
				return null;
			}

			public Builder SetPskIdentity(byte[] pskIdentity)
			{
				return null;
			}

			public Builder SetSrpIdentity(byte[] srpIdentity)
			{
				return null;
			}

			public Builder SetServerExtensions(IDictionary serverExtensions)
			{
				return null;
			}

			private void Validate(bool condition, string parameter)
			{
			}
		}

		private int mCipherSuite;

		private byte mCompressionAlgorithm;

		private byte[] mMasterSecret;

		private Certificate mPeerCertificate;

		private byte[] mPskIdentity;

		private byte[] mSrpIdentity;

		private byte[] mEncodedServerExtensions;

		public int CipherSuite
		{
			get
			{
				return 0;
			}
		}

		public byte CompressionAlgorithm
		{
			get
			{
				return 0;
			}
		}

		public byte[] MasterSecret
		{
			get
			{
				return null;
			}
		}

		public Certificate PeerCertificate
		{
			get
			{
				return null;
			}
		}

		public byte[] PskIdentity
		{
			get
			{
				return null;
			}
		}

		public byte[] SrpIdentity
		{
			get
			{
				return null;
			}
		}

		private SessionParameters(int cipherSuite, byte compressionAlgorithm, byte[] masterSecret, Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions)
		{
		}

		public void Clear()
		{
		}

		public SessionParameters Copy()
		{
			return null;
		}

		public IDictionary ReadServerExtensions()
		{
			return null;
		}
	}
}
