using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ShaderWeaver
{
	[Serializable]
	[ExecuteInEditMode]
	public class SWPreview : MonoBehaviour
	{
		[SerializeField]
		public Canvas canvas;

		[SerializeField]
		public Camera cam;

		[SerializeField]
		public List<GameObject> objs;

		[SerializeField]
		public MeshRenderer rNormal;

		[SerializeField]
		public SpriteRenderer rSprite;

		[SerializeField]
		public Image uiImage;

		[SerializeField]
		public Text uiText;

		public void Init(Vector3 pos)
		{
		}

		public void SetMaterial(Material mat, SWData data, Sprite sp, float mulX, float mulY)
		{
		}

		public void Destory()
		{
		}

		public void Update()
		{
		}
	}
}
