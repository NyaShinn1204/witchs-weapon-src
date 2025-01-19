using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class ServantPrefab : MonoBehaviour
{
	private const float PHOTO_SCALE_V = 0.7f;

	public GameObject servant;

	public UILabel _Level;

	public UITexture photo;

	public UITexture speicalPhoto;

	public UILabel _Name;

	public long id;

	public Transform energy;

	public Transform energyBg;

	public UISprite rank;

	public GameObject star;

	public Transform challageIcon;

	public Transform meracenaryIcon;

	public Transform nullIcon;

	private long wpID;

	private int serial;

	public Transform upImg;

	public Transform lockBg;

	public ButtonEx lockBtn;

	private void Start()
	{
	}

	public void SwitchView()
	{
	}

	public void SetNull()
	{
	}

	public void SetLock()
	{
	}

	public void SetInfo(ObservableSingleServant _servant)
	{
	}

	public void SetInfo(long svCardID, int lv, int rankLv, int starLv, long _wpID = 0L, int _serial = 1)
	{
	}

	public void SetExpeditionInfo(long _servantId, int _servantLv, int _servantRank, int _servantStar, int _energy, bool _isMercenary, int _serial = 1)
	{
	}

	public void SetActivityInfo(long _servantId, int _servantLv, int _servantRank, int _servantStar, int _energy, bool _isMercenary, int _serial = 1)
	{
	}

	private void SetServantEnergy(int _energy, Transform trans)
	{
	}

	private void SetPhoto(long id, int _fashion)
	{
	}

	private void SetUpImg(long _sid)
	{
	}
}
