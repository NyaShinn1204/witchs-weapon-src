using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

namespace WaterBell.ProjX.View.UIFrame
{
	public class UIScene
	{
		private GameObject obj;

		private bool isPreloaded;

		protected bool isInit;

		private bool isShow;

		private UITopBarType uITopBarType;

		private UITopBarBackgroundType uITopBarBackgroundType;

		private UIBackButtonType uIBackButtonType;

		private UIHomeButtonType uIHomeButtonType;

		private UIWindowNavigationMode uIWindowNavigationMode;

		private UIShowPhoneMode uIShowPhoneMode;

		private UIShowBGMode uIShowBGMode;

		private UIShowType uIShowType;

		private UIBGMType uIBGMType;

		private UISceneID uISceneID;

		protected List<int> toPreloadUI;

		protected GameObject go;

		public virtual AssetsManager.AssetsType UnloadOnClose
		{
			get
			{
				return default(AssetsManager.AssetsType);
			}
		}

		public UITopBarType UITopBarType
		{
			get
			{
				return default(UITopBarType);
			}
			set
			{
			}
		}

		public UITopBarBackgroundType UITopBarBackgroundType
		{
			get
			{
				return default(UITopBarBackgroundType);
			}
			set
			{
			}
		}

		public UIBackButtonType UIBackButtonType
		{
			get
			{
				return default(UIBackButtonType);
			}
			set
			{
			}
		}

		public UIHomeButtonType UIHomeButtonType
		{
			get
			{
				return default(UIHomeButtonType);
			}
			set
			{
			}
		}

		public UIWindowNavigationMode UIWindowNavigationMode
		{
			get
			{
				return default(UIWindowNavigationMode);
			}
			set
			{
			}
		}

		public UIShowPhoneMode UIShowPhoneMode
		{
			get
			{
				return default(UIShowPhoneMode);
			}
			set
			{
			}
		}

		public UIShowBGMode UIShowBGMode
		{
			get
			{
				return default(UIShowBGMode);
			}
			set
			{
			}
		}

		public UIShowType UIShowType
		{
			get
			{
				return default(UIShowType);
			}
			set
			{
			}
		}

		public UIBGMType UIBGMType
		{
			get
			{
				return default(UIBGMType);
			}
			set
			{
			}
		}

		public UISceneID UISceneID
		{
			get
			{
				return default(UISceneID);
			}
			set
			{
			}
		}

		public void Reset()
		{
		}

		public bool IsShow()
		{
			return false;
		}

		public bool GetIsInited()
		{
			return false;
		}

		public virtual void InitConfig()
		{
		}

		public virtual void PreLoad()
		{
		}

		public virtual void Init()
		{
		}

		public virtual void Show(UIDataBase mData = null)
		{
		}

		public virtual float Hide()
		{
			return 0f;
		}

		public virtual void Unload(GUtilListenerEvent sEvent)
		{
		}
	}
}
