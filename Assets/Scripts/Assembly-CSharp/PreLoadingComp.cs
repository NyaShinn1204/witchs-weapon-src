using UnityEngine;

public class PreLoadingComp : MonoBehaviour
{
	private enum LoadMode
	{
		Uninited = 0,
		LoadingFromUI = 1,
		LoadingFromBattle = 2
	}

	private static PreLoadingComp _instance;

	private static LoadMode mode;

	public static bool AllowUnload;

	private const float minProgressAdvancedAmountPerSec = 0.1f;

	private const float maxProgressAdvancedAmountPerSec = 0.5f;

	private const float minProgress = 0.05f;

	private const float maxProgress = 0.96f;

	private const float progressDis = 0.90999997f;

	private float currProgress;

	public GameObject preloadingFromUIContainer;

	public GameObject preloadingFromBattleContainer;

	public UILabel loadTip;

	public UITexture bg;

	public UITexture progressBar;

	public UITexture progressBarHeader;

	private IPreLoadingData data;

	private int _LateUpdateCount;

	private int wait_unload;

	private float xposIncMax;

	private float xposInitial;

	private float headerX;

	public int LateUpdateCount
	{
		get
		{
			return 0;
		}
	}

	public static void LoadScene()
	{
	}

	public static void LoadBackScene()
	{
	}

	public static PreLoadingComp GetInstance()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private void InitLoadingFromUI()
	{
	}

	private void InitViewForLvAndWeight()
	{
	}

	private void InitLoadingFromBattle()
	{
	}

	public void BindData(IPreLoadingData preloadingData)
	{
	}

	private void Update()
	{
	}

	private void updateProgressBarHeader()
	{
	}

	public void Unload()
	{
	}
}
