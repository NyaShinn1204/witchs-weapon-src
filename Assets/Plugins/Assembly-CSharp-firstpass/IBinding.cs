public interface IBinding
{
	bool IsComponent { get; set; }

	string ModelMemberName { get; set; }

	bool TwoWay { get; set; }

	void Bind();

	void Unbind();
}
