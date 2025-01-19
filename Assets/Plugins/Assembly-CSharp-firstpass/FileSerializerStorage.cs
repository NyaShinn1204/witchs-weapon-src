public class FileSerializerStorage : ISerializerStorage
{
	public string Filename { get; set; }

	public FileSerializerStorage(string filename)
	{
	}

	public void Load(ISerializerStream stream)
	{
	}

	public void Save(ISerializerStream stream)
	{
	}
}
