using LuaInterface;
using UnityEngine;

public class LuaComponent : MonoBehaviour
{
	public enum MyType
	{
		Patch = 0,
		UI = 1
	}

	public MyType m_Type;

	public string m_luaPath;

	public LuaTable LuaModule;

	private void RunLuaFile(string luaPath)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void CallLuaFunction(string funcName, params object[] args)
	{
	}
}
