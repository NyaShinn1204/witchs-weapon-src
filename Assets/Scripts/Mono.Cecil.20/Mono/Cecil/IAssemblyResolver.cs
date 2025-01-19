namespace Mono.Cecil
{
	public interface IAssemblyResolver
	{
		AssemblyDefinition Resolve(AssemblyNameReference name);
	}
}
