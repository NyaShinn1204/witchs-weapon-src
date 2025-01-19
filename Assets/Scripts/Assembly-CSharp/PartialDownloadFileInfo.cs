public class PartialDownloadFileInfo
{
	private bool _needToDownload;

	public string dir;

	public string path;

	public PartialDownloadFileInfo(string dir, string path)
	{
	}

	public bool isMarked()
	{
		return false;
	}

	public void Mark()
	{
	}
}
