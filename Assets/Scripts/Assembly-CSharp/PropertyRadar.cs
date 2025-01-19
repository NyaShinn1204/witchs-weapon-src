using UnityEngine;

public class PropertyRadar : MonoBehaviour
{
	private int VERTICES_COUNT;

	public Vector3[] vertices;

	private int[] triangles;

	public float scale;

	public MeshFilter meshFilter;

	private Mesh mesh;

	private float pi;

	private Vector3 single;

	private Vector3 heal;

	private Vector3 support;

	private Vector3 aoe;

	private Vector3 control;

	private Vector3 defense;

	public UISprite singleIcon;

	public UISprite healIcon;

	public UISprite supportIcon;

	public UISprite aoeIcon;

	public UISprite controlIcon;

	public UISprite defenseIcon;

	private void Awake()
	{
	}

	private void CreateMesh()
	{
	}

	private void SetVertices()
	{
	}

	private float GetRadians(float angle)
	{
		return 0f;
	}

	private void Apply()
	{
	}

	public void Draw(int _single, int _aoe, int _defense, int _heal, int _control, int _support)
	{
	}

	private string GetEnumSprite(int _type)
	{
		return null;
	}
}
