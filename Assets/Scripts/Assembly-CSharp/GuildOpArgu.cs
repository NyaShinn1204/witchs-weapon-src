using System.ComponentModel;

public class GuildOpArgu : INotifyPropertyChanged
{
	private GuildOperateEnum _OpType;

	private string _Argu;

	public virtual GuildOperateEnum OpType
	{
		get
		{
			return default(GuildOperateEnum);
		}
		set
		{
		}
	}

	public virtual string Argu
	{
		get
		{
			return null;
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
