using System.Collections.Generic;
using UnityEngine;

public class BuffShaderHistory
{
	private Dictionary<GameObject, string> originDic;

	private Dictionary<GameObject, List<string>> history;

	public void SaveHistory(GameObject entity, string oldShader, string newShader)
	{
	}

	public void RestoreHistory(GameObject entity, string curShader)
	{
	}

	private void SetShader(Transform _obj, string shader)
	{
	}
}
