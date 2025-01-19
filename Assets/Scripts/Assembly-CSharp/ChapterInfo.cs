using System.ComponentModel;
using WaterBell.ProjX.Data.Entity;

public class ChapterInfo : INotifyPropertyChanged
{
	private string _ID;

	private int _chapterCount;

	public virtual string ID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int chapterCount
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

	public ChapterInfo()
	{
	}

	public ChapterInfo(Progress.SingleProgress.Chapter clone)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
