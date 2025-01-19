using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeanCloud.Realtime
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	internal delegate void OnMessagePatch(IEnumerable<IAVIMMessage> messages);
}
