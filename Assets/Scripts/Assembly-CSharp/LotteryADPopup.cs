using System.Collections.Generic;
using UnityEngine;

public class LotteryADPopup : MonoBehaviour
{
	public enum ShowType
	{
		Servant = 0,
		WeaponSR = 1,
		WeaponSSR = 2
	}

	public static AssetsManager.AssetsType assetsType;

	private UILabel _Name;

	private GameObject _Close;

	private GameObject _Left;

	private GameObject _Right;

	private UITexture _Weapon_Container;

	private UITexture _Servant_Container;

	private Vector3 _Servant_Container_LeftPos;

	private Vector3 _Servant_Container_RightPos;

	private GameObject _Servant;

	private GameObject _Weapon;

	private GameObject _SliderMarkChild;

	private GameObject _SlideMarkParent;

	private UILabel _IndexLabel;

	private UILabel _Weapon_Name;

	private GameObject _Weapon_SSR;

	private GameObject _Weapon_SR;

	private UILabel _Weapon_Physics_Value;

	private UILabel _Weapon_Magic_Value;

	private UIScrollView _Weapon_DescScroll;

	private UILabel _Weapon_DescScroll_Desc;

	private UIScrollView _Servant_DescScroll;

	private UILabel _Servant_DescScroll_Desc;

	private UIScrollView _Servant_FuncDescScroll;

	private UILabel _Servant_FuncDescScroll_Desc;

	private GameObject _Weapon_Skill1_Select;

	private GameObject _Weapon_Skill2_Select;

	private UISprite _Weapon_Skill1;

	private UISprite _Weapon_Skill2;

	private List<long> _Data;

	private ShowType _ShowType;

	private string _FormatPathWeapon;

	private List<UISprite> _ListSliderMark;

	private int _CurIndex;

	private int _LastIndex;

	private static LotteryADPopup _Instance;

	public static LotteryADPopup Instance
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void ClickClose(GameObject obj)
	{
	}

	private void UpdateSkillInfo(string skillLabelName)
	{
	}

	private void ClickSkill(GameObject obj)
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateSelector()
	{
	}

	private void ClickSelector(GameObject obj)
	{
	}

	public void Show(ShowType showType, List<long> list)
	{
	}
}
