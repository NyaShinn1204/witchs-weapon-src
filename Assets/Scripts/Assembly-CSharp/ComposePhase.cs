using System.Collections.Generic;

public class ComposePhase : Phase
{
	public List<Phase> subPhases;

	public ComposePhase()
	{
	}

	public ComposePhase(string name, Dictionary<string, string> paramList, List<Phase> phases)
	{
	}

	public void AddSubPhase(Phase phase)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	public void RunSubPhaseList(List<Phase> list, NameSpace field)
	{
	}
}
