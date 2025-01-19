using BestHTTP;

public interface IHTTPDetailResponse : IHTTPResponse
{
	void OnInternalError(string detail);

	void OnError(string detail);

	void OnTimeOut(HTTPRequestStates status);
}
