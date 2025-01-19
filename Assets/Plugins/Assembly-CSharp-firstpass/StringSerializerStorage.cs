public class StringSerializerStorage : ISerializerStorage
{
	public string Result { get; set; }

	public void Load(ISerializerStream stream)
	{
	}

	public void Save(ISerializerStream stream)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
