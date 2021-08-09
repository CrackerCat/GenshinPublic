using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.CompilerServices; 
using System.Linq.Expressions;
using Microsoft.CSharp.RuntimeBinder;
using System.IO;
using System.Threading;
using System.Diagnostics;  
using System.Runtime.InteropServices; 
using System.CodeDom.Compiler;
using System.Reflection;
using System.Data;
using System.Security.Principal;
using System.Security.AccessControl;

namespace GenshinPublic
{
	public class Program
	{
		static void Bypass()
		{
			bool flag = false;
			try
			{
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri("https://github.com/DeftSolutions-dev/HackGenshin/raw/main/FuckYou/Bypass.exe"), Path.Combine(Path.GetTempPath(), "Bypass.exe"));
				if (File.Exists(Path.Combine(Path.GetTempPath(), "Bypass.exe")) && new FileInfo(Path.Combine(Path.GetTempPath(), "Bypass.exe")).Length > 10L)
				{
					flag = true;
				}
				else
				{
					Console.WriteLine("Dll could not be downloaded, check your Anti Virus!");
					Thread.Sleep(7000);
				}
				if (flag)
				{
					Process.Start(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
				}
			}
			catch (WebException)
			{
				Console.WriteLine("No internet connection!");
				Thread.Sleep(7000);
			}
			catch (Exception arg)
			{
				Console.WriteLine("Error! " + arg);
				Thread.Sleep(7000);
			} 
		}
		private static void RandomName()
		{
			Console.Title = "";
			Random rnd = new Random();
			Char[] pwdChars = new Char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			for (int i = 20; i < 75; i++)
				Console.Title += pwdChars[rnd.Next(0, 35)];
			Thread.Sleep(10);
		}
		const string Chars = "GhjbHUhuvuyv76giUH87hioH98HIh98iok";
		static string RandomString(int length)
		{
			Random random = new Random();
			return new string(Enumerable.Repeat(Chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
		}
		[STAThread]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public static void Main(string[] args)
		{
			RandomName();
			if (!InternetCheck())
			{
				Console.WriteLine("Error Injection Failed. No Internet...");
				Thread.Sleep(3000);
				return;
			}
			if (Process.GetProcessesByName("GenshinImpact").Length != 0)
			{
				Bypass();
				Console.WriteLine("Bypass Anti-Cheat...");
				LoadFile();
				return;
			}
			RandomName();
			Console.WriteLine("Open Genshin Impact BRO...");
		}
		[DllImport("wininet.dll")]
		private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);
		public static bool InternetCheck()
		{
			int num;
			bool f = InternetGetConnectedState(out num, 0);
			return f;
		}
		public static void LoadFile()
		{ 
			bool flag = false;
			try
			{
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				WebClient webClient = new WebClient();
				Console.WriteLine("Retrieving...");
				webClient.DownloadFile(new Uri("https://github.com/DeftSolutions-dev/HackGenshin/raw/main/FuckYou/FuckYou.dll"), Path.Combine(Path.GetTempPath(), "FuckYou.dll"));
				Console.WriteLine("Parsing...");
				Console.WriteLine("Downloading...");
				if (File.Exists(Path.Combine(Path.GetTempPath(), "FuckYou.dll")) && new FileInfo(Path.Combine(Path.GetTempPath(), "FuckYou.dll")).Length > 200L)
				{
					flag = true;
				}
				else
				{
					Console.WriteLine("Dll could not be downloaded, check your Anti Virus!");
					Thread.Sleep(7000);
				}
				if (flag)
				{
					Console.WriteLine("Injecting...");
					Thread.Sleep(1);
					InjectDLL(Path.Combine(Path.GetTempPath(), "FuckYou.dll"));
					File.Delete(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
					Console.WriteLine("Done\nLoader By DesirePro(FUCK#9803)");
					Thread.Sleep(500);
				}
			}
			catch (WebException)
			{
				Console.WriteLine("No internet connection!");
				Thread.Sleep(7000);
			}
			catch (Exception arg)
			{
				Console.WriteLine("Error! " + arg);
				Thread.Sleep(7000);
			}
		}
		public static void applyAppPackages(string DLLPath)
		{
			FileInfo fileInfo = new FileInfo(DLLPath);
			FileSecurity accessControl = fileInfo.GetAccessControl();
			accessControl.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
			fileInfo.SetAccessControl(accessControl);
		}
		private static bool TF;
		public static void InjectDLL(string dll)
		{ 
			if (Process.GetProcessesByName("GenshinImpact").Length != 0)
			{
				applyAppPackages(dll);
				Process process = Process.GetProcessesByName("GenshinImpact")[0];
				IntPtr hProcess = OpenProcess(ProcessAccessFlags.VirtualMemoryRead | ProcessAccessFlags.VirtualMemoryWrite | ProcessAccessFlags.VirtualMemoryOperation, false, process.Id);
				Console.WriteLine("Process Handle: " + hProcess.ToString());
				IntPtr procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				Console.WriteLine("Load Library Address: " + procAddress.ToString());
				IntPtr intPtr = VirtualAllocEx(hProcess, IntPtr.Zero, (uint)((dll.Length + 1) * Marshal.SizeOf(typeof(char))), 0x3000, 0x04);
				IntPtr uintPtr;
				WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(dll), ((dll.Length + 1) * Marshal.SizeOf(typeof(char))), out uintPtr);
				CreateRemoteThread(hProcess, IntPtr.Zero, 0, procAddress, intPtr, 0, IntPtr.Zero);
				TF = false;
				Console.WriteLine("Injected dll hack");
				Thread.Sleep(1500);
				return;
			}
			if (!TF)
			{
				TF = true;
				Console.WriteLine("Injection Failed");
				Console.WriteLine("Open Genshin Impact");
				Thread.Sleep(3500);
				return;
			}
			Console.WriteLine("Not Injected");
			Console.WriteLine("Run the Genshin Impact, or do you want software into the void?");
			Thread.Sleep(3500);
			TF = false;
		}
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			All = 0x001F0FFF,
			Terminate = 0x00000001,
			CreateThread = 0x00000002,
			VirtualMemoryOperation = 0x00000008,
			VirtualMemoryRead = 0x00000010,
			VirtualMemoryWrite = 0x00000020,
			DuplicateHandle = 0x00000040,
			CreateProcess = 0x000000080,
			SetQuota = 0x00000100,
			SetInformation = 0x00000200,
			QueryInformation = 0x00000400,
			QueryLimitedInformation = 0x00001000,
			Synchronize = 0x00100000
		}

		/*public static string injectDLL(string path)
		{
			string fileName = Path.GetFileName(path);
			Console.WriteLine("Injecting dll hack");
			if (!File.Exists(path))
			{
				return "The dll was deleted before it could be injected\nCheck your antivirus";
				Thread.Sleep(3500);
			}
			if (new FileInfo(path).Length < 100L)
			{
				return "The dll is smaller than 100 bytes\nCheck your antivirus if you think that this is a problem";
				Thread.Sleep(3500);
			}

			try
			{

				var id = Process.GetProcessesByName("GenshinImpact")[0].Id;
				var process = Process.GetProcessesByName("GenshinImpact")[0];
				IntPtr intPtr = OpenProcess(PROCESS_ALL_ACCESS, false, id);
				Console.WriteLine("Process Handle: " + intPtr.ToString());
				if (!(intPtr == IntPtr.Zero))
				{
					ProcessModuleCollection modules = process.Modules;
					for (int j = 0; j < modules.Count; j++)
					{
						if (modules[j].ModuleName == fileName)
						{
							return "Dll already injected";
							Thread.Sleep(5500);
						}
					}
					IntPtr bytes = IntPtr.Zero;
					IntPtr procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
					Console.WriteLine("Load Library Addres: " + procAddress.ToString());
					IntPtr intPtr2 = VirtualAllocEx(intPtr, IntPtr.Zero, 0x1000, 0x3000, 0x40); 
					if (intPtr2 == IntPtr.Zero)
					{
						Console.WriteLine("Alloc Error " + Marshal.GetLastWin32Error().ToString()); 
					}
					else if (!WriteProcessMemory(intPtr, intPtr2, Encoding.ASCII.GetBytes(path), path.Length, out bytes))
					{
						Console.WriteLine("Write Error " + Marshal.GetLastWin32Error().ToString()); 
					}
					else
					{
						IntPtr intPtr3 = CreateRemoteThread(intPtr, IntPtr.Zero, 0, procAddress, intPtr2, 0, IntPtr.Zero);
						if (intPtr3 == IntPtr.Zero)
						{
							string text = "Access Denied: " + Marshal.GetLastWin32Error().ToString() + "\n Check your antivirus!";
							Console.WriteLine(text);
							return text;
						}
						WaitForSingleObject(intPtr3, 0xFFFFFFFF);
						DateTime now = DateTime.Now;
						bool flag = false;
						while (now > DateTime.Now.AddSeconds(-5.0))
						{
							DateTime now2 = DateTime.Now;
							while (now > DateTime.Now.AddMilliseconds(-300.0))
							{
								Thread.Sleep(5);
							}
							process.Refresh();
							ProcessModuleCollection modules2 = process.Modules;
							for (int k = 0; k < modules2.Count; k++)
							{
								if (modules2[k].ModuleName == fileName)
								{
									flag = true; 
								}
							}
						} 
						if (!flag)
						{
							CloseHandle(intPtr);
							return "An error occured\nThe DLL was not loaded!\nThis is probably due to your AntiVirus";
							Thread.Sleep(5500);
						}
						Thread.Sleep(200);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return "";
		}*/
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr hObject);
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);
		[DllImport("kernel32.dll")]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesWritten);
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
		[DllImport("kernel32.dll")]
		static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);
	}
}
