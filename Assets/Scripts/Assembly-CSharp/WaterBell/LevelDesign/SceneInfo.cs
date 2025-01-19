using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.LevelDesign
{
	public class SceneInfo
	{
		private static SceneInfo _instance;

		public string[] sceneNames;

		public int prevIndex;

		public int sceneNameIndex;

		public Texture2D currTexture;

		public readonly int imgWidth;

		public readonly int imgHeight;

		private Dictionary<string, Texture2D> sceneImgDict;

		public string currSceneName
		{
			get
			{
				return null;
			}
		}

		private SceneInfo()
		{
		}

		public static SceneInfo GetInstance()
		{
			return null;
		}

		public void LoadSceneInfo()
		{
		}

		private void SetImgTexture(int sceneIndex)
		{
		}

		private void SetCurrSceneImg(int sceneIndex)
		{
		}

		public void RefreshTextureImg()
		{
		}
	}
}
