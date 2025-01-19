using WaterBell.ProjX.Data.Entity;

public class SelectedServant
{
	public long sID;

	public long rID;

	public long addTime;

	public ObservableSingleServant servant;

	public MercenaryServant mercenary;

	public bool isConfirm;

	public SelectedServant(long _sid, long _rid, long _time, ObservableSingleServant _sv, bool _isConfirm)
	{
	}

	public SelectedServant(long _sid, long _rid, long _time, MercenaryServant _sv, bool _isConfirm)
	{
	}
}
