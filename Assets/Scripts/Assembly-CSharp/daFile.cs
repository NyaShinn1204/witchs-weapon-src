using System.Collections.Generic;

public class daFile
{
	private Dictionary<string, string> _serverHash;

	private Dictionary<string, string> _localHash;

	private string _localHashCache;

	private bool _needListUpdate;

	private int _needToFlush;

	private int _numFiles;

	private string _serverMasterHash;

	public bool needFileListUpdate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int serverBundleFiles
	{
		get
		{
			return 0;
		}
	}

	public bool checkServerHash(string hash)
	{
		return false;
	}

	public SHA1SUM checkSHA1(string path, string name, string srcSHA1)
	{
		return default(SHA1SUM);
	}

	public List<string> getNonExistFileList(Dictionary<string, string> filelist, List<string> ignorePath)
	{
		return null;
	}

	public bool isFileHashValid(string path, byte[] data)
	{
		return false;
	}

	public bool isLocalHashExpired(string path)
	{
		return false;
	}

	public bool isServerFileExists(string path, string name)
	{
		return false;
	}

	private void loadLocalHash()
	{
	}

	public void processServerBundleFileList(Dictionary<string, object> filelist, string hash)
	{
	}

	public void updateDataFilePath()
	{
	}

	public void updateHashData()
	{
	}
}
