namespace LeanCloud.Core.Internal
{
	public sealed class SHA1CryptoServiceProvider : SHA1
	{
		private SHA1Internal sha;

		~SHA1CryptoServiceProvider()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		protected override byte[] HashFinal()
		{
			return null;
		}

		public override void Initialize()
		{
		}
	}
}
