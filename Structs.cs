using System;
using System.Runtime.InteropServices;

namespace BlastClient
{
	static class CFunctions
	{
		// extern struct hostent * redsocket_gethostbyname (const char *name);
		[DllImport ("__Internal")]
		static extern unsafe hostent* redsocket_gethostbyname (sbyte* name);

		// extern UInt32 RedEthernet_calcCRC32 (UInt32 *buffer, unsigned int numWords);
		[DllImport ("__Internal")]
		static extern unsafe uint RedEthernet_calcCRC32 (uint* buffer, uint numWords);
	}
}
