using System.Collections.Generic;

public class AnimationFileModifyTest
{
	private const string Document = "%YAML 1.1\n%TAG !u! tag:unity3d.com,2011:\n--- !u!74 &7400000\nAnimationClip:\n  m_ObjectHideFlags: 0\n  m_PrefabParentObject: {fileID: 0}\n  m_PrefabInternal: {fileID: 0}\n  m_Name: 102_p_a_run\n  serializedVersion: 6\n  m_Legacy: 0\n  m_Compressed: 0\n  m_UseHighQualityCurve: 1\n  m_RotationCurves:\n  - curve:\n      serializedVersion: 2\n      m_Curve:\n      - time: 0\n        value: {x: .564759433, y: .56475991, z: .425496101, w: -.425495088}\n        inSlope: {x: 0, y: 0, z: 0, w: 0}\n        outSlope: {x: 0, y: 0, z: 0, w: 0}\n        tangentMode: 0\n      - time: .666666687\n        value: {x: .564759433, y: .56475991, z: .425496101, w: -.425495088}\n        inSlope: {x: 0, y: 0, z: 0, w: 0}\n        outSlope: {x: 0, y: 0, z: 0, w: 0}\n        tangentMode: 0\n      m_PreInfinity: 2\n      m_PostInfinity: 2\n    path: player_101/Bip001\n";

	private const string Document_changed = "%YAML 1.1\n%TAG !u! tag:unity3d.com,2011:\n--- !u!74 &7400000\nAnimationClip:\n  m_ObjectHideFlags: 0\n  m_PrefabParentObject: {fileID: 0}\n  m_PrefabInternal: {fileID: 0}\n  m_Name: 102_p_a_run\n  serializedVersion: 6\n  m_Legacy: 0\n  m_Compressed: 0\n  m_UseHighQualityCurve: 1\n  m_RotationCurves:\n  - curve:\n      serializedVersion: 2\n      m_Curve:\n      - time: 0\n        value: {x: .564759433, y: .56475991, z: .425496101, w: -.425495088}\n        inSlope: {x: 0, y: 0, z: 0, w: 0}\n        outSlope: {x: 0, y: 0, z: 0, w: 0}\n        tangentMode: 0\n      - time: .666666687\n        value: {x: .564759433, y: .56475991, z: .425496101, w: -.425495088}\n        inSlope: {x: 0, y: 0, z: 0, w: 0}\n        outSlope: {x: 0, y: 0, z: 0, w: 0}\n        tangentMode: 0\n      m_PreInfinity: 2\n      m_PostInfinity: 2\n    path: __root__/player_101/Bip001\n";

	public void TestAll()
	{
	}

	public void TestReadAndWrite()
	{
	}

	public void TestReadSpeed()
	{
	}

	public string ReadAllInOneTime(string path)
	{
		return null;
	}

	public void ReadAllByLine(string path)
	{
	}

	public List<string> ReadAllByLineToArray(string path)
	{
		return null;
	}

	public void WriteLines(string fileName, List<string> list)
	{
	}
}
