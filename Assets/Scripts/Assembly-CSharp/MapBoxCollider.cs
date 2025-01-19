using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MapBoxCollider : MonoBehaviour
{
	public class MapBoxColliderData
	{
		public int mapSizeX;

		public int mapSizeY;

		public int uvCountX;

		public int uvCountY;

		public string material;

		public MapBoxColliderStruct[] uvData;
	}

	[StructLayout(LayoutKind.Sequential, Size = 24)]
	public struct MapBoxColliderStruct
	{
		public int[] allView;

		public bool isBlock;

		public int nowIndex;

		public int y;
	}

	public class MapObjectData
	{
		public MapObjectStruct[] objects;
	}

	[StructLayout(LayoutKind.Sequential, Size = 24)]
	public struct MapObjectStruct
	{
		public int index;

		public string assets;

		public string type;
	}

	private const string MOUSE_DOWN_LISTENER = "MapBoxCollider.MOUSE_DOWN_LISTENER";

	public MapBoxColliderData boxColliderData;

	public MapObjectData objectData;

	private Dictionary<int, GameObject> _objectViewDic;

	public bool isDraw;

	public string editorFile;

	public int editorIndex;

	private MeshFilter _meshFiler;

	private MeshRenderer _meshRenderer;

	private Mesh _mesh;

	public Texture texture
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void drawObject()
	{
	}

	private Vector3 GetPositionByIndex(int sIndex)
	{
		return default(Vector3);
	}

	private void OnMouseDown()
	{
	}

	private void drawBox()
	{
	}

	private void drawView()
	{
	}

	private void drawViewColorSelectHD(GUtilListenerEvent sEvent)
	{
	}
}
