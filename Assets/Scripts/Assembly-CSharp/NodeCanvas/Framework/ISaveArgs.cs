namespace NodeCanvas.Framework
{
	internal interface ISaveArgs
	{
		int I_sentenceIdx { get; set; }

		string I_wordStr { get; set; }

		bool I_enableSentenceMapping { get; set; }

		string I_GetRoleName();
	}
}
