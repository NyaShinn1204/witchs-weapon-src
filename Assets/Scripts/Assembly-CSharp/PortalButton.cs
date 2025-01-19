using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class PortalButton : MonoBehaviour
{
	public enum ProgressTypes
	{
		Lock = 0,
		Unlock = 1,
		Clear = 2
	}

	public GameObject model;

	public PositionSync positionSync;

	[SerializeField]
	private ProgressTypes m_ProgressType;

	[SerializeField]
	private long instanceId;

	private Coroutine selfAnim;

	public long ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual ProgressTypes ProgressType
	{
		get
		{
			return default(ProgressTypes);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnClick()
	{
	}

	private void ChangeProtalModel(GameObject protalObj, ProgressTypes t)
	{
	}
}
