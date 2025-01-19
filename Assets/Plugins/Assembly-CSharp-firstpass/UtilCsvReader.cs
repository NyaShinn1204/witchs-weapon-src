using System.Collections.Generic;
using System.IO;
using System.Reflection;

public class UtilCsvReader
{
	private static readonly string _sStrR;

	private static readonly string _sStrN;

	private char[] _sSplit;

	private string _text;

	public Dictionary<string, int> _key;

	private List<string[]> _keyValue;

	private Dictionary<string, List<Dictionary<string, string>>> _searchs;

	public bool isClearData;

	public string fieldNameEndStr;

	public UtilCsvReader(string sText)
	{
	}

	public UtilCsvReader(string sText, char[] sSplit)
	{
	}

	public UtilCsvReader(FileStream sStream)
	{
	}

	public UtilCsvReader(FileStream sStream, char[] sSplit)
	{
	}

	private void initText()
	{
	}

	public void InternValue()
	{
	}

	public List<Dictionary<string, string>> searchs(params object[] objs)
	{
		return null;
	}

	public Dictionary<string, string> search(params object[] objs)
	{
		return null;
	}

	public bool searchAndSet<T>(T val, params object[] objs)
	{
		return false;
	}

	public T searchAndNew<T>(params object[] objs) where T : new()
	{
		return default(T);
	}

	public List<T> searchsT<T>(params object[] objs) where T : new()
	{
		return null;
	}

	public T getAttribue<T>(string attribueName, string attribueValue) where T : new()
	{
		return default(T);
	}

	public List<Dictionary<string, string>> getTable()
	{
		return null;
	}

	public List<T> getTableAndNew<T>() where T : new()
	{
		return null;
	}

	private void setFieldValue(FieldInfo field, object obj, Dictionary<string, string> hash)
	{
	}

	public void destroy()
	{
	}
}
