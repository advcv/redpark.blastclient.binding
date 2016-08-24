using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace BlastClient
{
	// @protocol RedSocketManagerProtocol <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RedSocketManagerProtocol
	{
		// @required -(void)configureNetworkInterface:(NSString *)deviceIPAddress gateway:(NSString *)gateway netmask:(NSString *)netmask dns:(NSString *)dns;
		[Abstract]
		[Export("configureNetworkInterface:gateway:netmask:dns:")]
		void ConfigureNetworkInterface(string deviceIPAddress, string gateway, string netmask, string dns);

		// @required -(NSString *)ipAddress;
		[Abstract]
		[Export("ipAddress")]
		string IpAddress { get; }

		// @required -(NSString *)gatewayAddress;
		[Abstract]
		[Export("gatewayAddress")]
		string GatewayAddress { get; }

		// @required -(NSString *)netmask;
		[Abstract]
		[Export("netmask")]
		string Netmask { get; }

		// @required -(NSString *)dnsAddress;
		[Abstract]
		[Export("dnsAddress")]
		string DnsAddress { get; }

		// @required -(int)socket:(int)domain type:(int)type protocol:(int)protocol;
		[Abstract]
		[Export("socket:type:protocol:")]
		int Socket(int domain, int type, int protocol);

		// @required -(int)accept:(int)s addr:(struct sockaddr *)addr addrlen:(socklen_t *)addrlen;
		[Abstract]
		[Export("accept:addr:addrlen:")]
		unsafe int Accept(int s, sockaddr* addr, uint* addrlen);

		// @required -(void)acceptAsync:(int)listenSocket addr:(struct sockaddr *)addr addrlen:(socklen_t *)addrlen;
		[Abstract]
		[Export("acceptAsync:addr:addrlen:")]
		unsafe void AcceptAsync(int listenSocket, sockaddr* addr, uint* addrlen);

		// @required -(int)bind:(int)s name:(const struct sockaddr *)name namelen:(socklen_t)namelen;
		[Abstract]
		[Export("bind:name:namelen:")]
		unsafe int Bind(int s, sockaddr* name, uint namelen);

		// @required -(int)shutdown:(int)s how:(int)how;
		[Abstract]
		[Export("shutdown:how:")]
		int Shutdown(int s, int how);

		// @required -(int)getpeername:(int)s name:(struct sockaddr *)name namelen:(socklen_t *)namelen;
		[Abstract]
		[Export("getpeername:name:namelen:")]
		unsafe int Getpeername(int s, sockaddr* name, uint* namelen);

		// @required -(int)getsockname:(int)s name:(struct sockaddr *)name namelen:(socklen_t *)namelen;
		[Abstract]
		[Export("getsockname:name:namelen:")]
		unsafe int Getsockname(int s, sockaddr* name, uint* namelen);

		// @required -(int)getsockopt:(int)s level:(int)level optname:(int)optname optval:(void *)optval optlen:(socklen_t *)optlen;
		[Abstract]
		[Export("getsockopt:level:optname:optval:optlen:")]
		unsafe int Getsockopt(int s, int level, int optname, void* optval, uint* optlen);

		// @required -(int)setsockopt:(int)s level:(int)level optname:(int)optname optval:(const void *)optval optlen:(socklen_t)optlen;
		[Abstract]
		[Export("setsockopt:level:optname:optval:optlen:")]
		unsafe int Setsockopt(int s, int level, int optname, void* optval, uint optlen);

		// @required -(int)close:(int)s;
		[Abstract]
		[Export("close:")]
		int Close(int s);

		// @required -(int)connect:(int)s sockaddr:(const struct sockaddr *)name namelen:(socklen_t)namelen;
		[Abstract]
		[Export("connect:sockaddr:namelen:")]
		unsafe int Connect(int s, sockaddr* name, uint namelen);

		// @required -(int)listen:(int)s backlog:(int)backlog;
		[Abstract]
		[Export("listen:backlog:")]
		int Listen(int s, int backlog);

		// @required -(int)recv:(int)s mem:(void *)mem len:(size_t)len flags:(int)flags;
		[Abstract]
		[Export("recv:mem:len:flags:")]
		unsafe int Recv(int s, void* mem, nuint len, int flags);

		// @required -(int)read:(int)s mem:(void *)mem len:(size_t)len;
		[Abstract]
		[Export("read:mem:len:")]
		unsafe int Read(int s, void* mem, nuint len);

		// @required -(int)recvfrom:(int)s mem:(void *)mem len:(size_t)len flags:(int)flags from:(struct sockaddr *)from fromlen:(socklen_t *)fromlen;
		[Abstract]
		[Export("recvfrom:mem:len:flags:from:fromlen:")]
		unsafe int Recvfrom(int s, void* mem, nuint len, int flags, sockaddr* from, uint* fromlen);

		// @required -(void)recvAsync:(int)sock buffer:(void *)buffer length:(size_t)length;
		[Abstract]
		[Export("recvAsync:buffer:length:")]
		unsafe void RecvAsync(int sock, void* buffer, nuint length);

		// @required -(int)send:(int)s dataptr:(const void *)dataptr size:(size_t)size flags:(int)flags;
		[Abstract]
		[Export("send:dataptr:size:flags:")]
		unsafe int Send(int s, void* dataptr, nuint size, int flags);

		// @required -(int)sendto:(int)s dataptr:(const void *)dataptr size:(size_t)size flags:(int)flags to:(const struct sockaddr *)to tolen:(socklen_t)tolen;
		[Abstract]
		[Export("sendto:dataptr:size:flags:to:tolen:")]
		unsafe int Sendto(int s, void* dataptr, nuint size, int flags, sockaddr* to, uint tolen);

		// @required -(int)write:(int)s dataptr:(const void *)dataptr size:(size_t)size;
		[Abstract]
		[Export("write:dataptr:size:")]
		unsafe int Write(int s, void* dataptr, nuint size);

		// @required -(int)select:(int)maxfdp1 readset:(fd_set *)readset writeset:(fd_set *)writeset exceptset:(fd_set *)exceptset timeout:(struct timeval *)timeout;
		[Abstract]
		[Export("select:readset:writeset:exceptset:timeout:")]
		unsafe int Select(int maxfdp1, fd_set* readset, fd_set* writeset, fd_set* exceptset, timeval* timeout);

		// @required -(int)ioctl:(int)s cmd:(long)cmd argp:(void *)argp;
		[Abstract]
		[Export("ioctl:cmd:argp:")]
		unsafe int Ioctl(int s, nint cmd, void* argp);

		// @required -(int)fcntl:(int)s cmd:(int)cmd val:(int)val;
		[Abstract]
		[Export("fcntl:cmd:val:")]
		int Fcntl(int s, int cmd, int val);

		// @required -(int)abort_recv:(int)s;
		[Abstract]
		[Export("abort_recv:")]
		int Abort_recv(int s);

		// @required -(int)abort_all:(int)s;
		[Abstract]
		[Export("abort_all:")]
		int Abort_all(int s);

		// @required -(void)setDelegate:(id<RedSocketManagerDelegate>)delegate;
		[Abstract]
		[Export("setDelegate:")]
		void SetDelegate(RedSocketManagerDelegate @delegate);

		// @required -(BOOL)isCableConnected;
		[Abstract]
		[Export("isCableConnected")]
		bool IsCableConnected { get; }

		// @required -(NSString *)getAccessoryFirmwareVersion;
		[Abstract]
		[Export("getAccessoryFirmwareVersion")]
		string AccessoryFirmwareVersion { get; }

		// @required -(int)getRxCounter;
		[Abstract]
		[Export("getRxCounter")]
		int RxCounter { get; }

		// @required -(void)resetRxCounter;
		[Abstract]
		[Export("resetRxCounter")]
		void ResetRxCounter();

		// @required -(void)enableExternalLogging:(BOOL)enable;
		[Abstract]
		[Export("enableExternalLogging:")]
		void EnableExternalLogging(bool enable);

		// @required -(void)enableTxRxExternalLogging:(BOOL)enable;
		[Abstract]
		[Export("enableTxRxExternalLogging:")]
		void EnableTxRxExternalLogging(bool enable);

		// @required -(void)logEvent:(NSString *)text color:(NSString *)color;
		[Abstract]
		[Export("logEvent:color:")]
		void LogEvent(string text, string color);
	}

	// @protocol RedSocketManagerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RedSocketManagerDelegate
	{
		// @required -(void)cableConnected:(NSString *)protocol;
		[Abstract]
		[Export("cableConnected:")]
		void CableConnected(string protocol);

		// @required -(void)cableDisconnected;
		[Abstract]
		[Export("cableDisconnected")]
		void CableDisconnected();

		// @optional -(void)didAssignIpAddress:(NSString *)deviceAddress gateway:(NSString *)gateway netmask:(NSString *)netmask;
		[Export("didAssignIpAddress:gateway:netmask:")]
		void DidAssignIpAddress(string deviceAddress, string gateway, string netmask);

		// @optional -(void)didSocketRecv:(int)socket buffer:(void *)buffer bytesRead:(int)bytesRead;
		[Export("didSocketRecv:buffer:bytesRead:")]
		unsafe void DidSocketRecv(int socket, void* buffer, int bytesRead);

		// @optional -(void)didSocketAccept:(int)newSocket addr:(struct sockaddr *)addr addrlen:(socklen_t *)addrlen;
		[Export("didSocketAccept:addr:addrlen:")]
		unsafe void DidSocketAccept(int newSocket, sockaddr* addr, uint* addrlen);

		// @optional -(void)linkStatusChanged:(BOOL)linkIsUp;
		[Export("linkStatusChanged:")]
		void LinkStatusChanged(bool linkIsUp);
	}

	// @interface RedSocketManager : NSObject
	[BaseType(typeof(NSObject))]
	interface RedSocketManager
	{
		// +(id<RedSocketManagerProtocol>)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		RedSocketManagerProtocol SharedInstance { get; }
	}

	// @protocol BlastClientDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface BlastClientDelegate
	{
		// @required -(void)statusChanged:(NSString *)status;
		[Abstract]
		[Export("statusChanged:")]
		void StatusChanged(string status);

		// @required -(void)linkStatusChanged:(BOOL)linkIsUp;
		[Abstract]
		[Export("linkStatusChanged:")]
		void LinkStatusChanged(bool linkIsUp);
	}

	// @interface BlastClient : NSObject <RedSocketManagerDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface BlastClient : IRedSocketManagerDelegate
	{
		[Wrap("WeakDelegate")]
		BlastClientDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BlastClientDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)start:(NSString *)ipAddress;
		[Export("start:")]
		void Start(string ipAddress);

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(BOOL)isRunning;
		[Export("isRunning")]
		bool IsRunning { get; }
	}
}



