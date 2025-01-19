public interface IHTTPResponse
{
	void OnData(byte[] bytes, string URL, string type, string tag = null);
}
