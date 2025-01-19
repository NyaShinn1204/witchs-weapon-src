using System.ComponentModel;

public class ServantEquipment : INotifyPropertyChanged
{
	private string _EquipID;

	private string _EquipName;

	private int _EquipColor;

	private string _EquipDesc;

	private string _EquipIcon;

	private string _EquipFragmentID;

	private int _EquipFragmentNum;

	public virtual string EquipID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string EquipName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int EquipColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string EquipDesc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string EquipIcon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string EquipFragmentID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int EquipFragmentNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
