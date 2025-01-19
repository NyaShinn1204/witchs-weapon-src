namespace LeanCloud.Realtime
{
	public class AVIMSignature
	{
		public string SignatureContent { get; set; }

		public long Timestamp { get; set; }

		public string Nonce { get; set; }

		public AVIMSignature(string s, long t, string n)
		{
		}
	}
}
