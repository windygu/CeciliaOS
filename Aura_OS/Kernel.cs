﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Kernel
* PROGRAMMERS:      Valentin Charbonnier <valentinbreiz@gmail.com>
*                   Alexy DA CRUZ <dacruzalexy@gmail.com>
*/

#region using;

using System;
using Cosmos.System.FileSystem;
using Sys = Cosmos.System;
using Aura_OS.System;
using Aura_OS.System.Users;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.ExtendedASCII;
using Aura_OS.System.Shell.cmdIntr;

#endregion

namespace Aura_OS
{
    public class Kernel : Sys.Kernel
    {

        #region Global variables

        Setup setup = new Setup();
        public static bool running;
        public static bool debugMode = false;
        public static long OEMID = 0x4b;
        public static string version = "21.5.2.240";
        public static string version_wrapper = "21.5.2.242";
        public static string version_tag = "release";
        public static string version_mark = "Yoki"; // Yoki: OEM Test
        public static string oldCompName = ComputerName;
        public static string revision = VersionInfo.revision;
        public static string current_directory = @"0:\";
        public static string langSelected = "en_US";
        public static string userLogged;
        public static string userLevelLogged;
        public static bool Logged = false;
        public static string ComputerName = "cecilia-desktop";
        public static string UserDir = @"0:\Users\" + userLogged + "\\";
        public static bool SystemExists = false;
        public static bool JustInstalled = false;
        public static CosmosVFS vFS = new CosmosVFS();
		public static Dictionary<string, string> environmentvariables = new Dictionary<string, string>();
        public static string boottime = Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true);
        public static System.AConsole.Console AConsole;
        public static string Consolemode = "VGATextmode";
        public static string current_volume = @"0:\";

        public static Cosmos.Debug.Kernel.Debugger debugger = new Cosmos.Debug.Kernel.Debugger("Cecilia", "Kernel");

        #endregion

        #region Before Run

        public static bool ContainsVolumes()
        {
            if (vFS.GetVolumes().Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void BeforeRun()
        {
            try
            {

                #region Console Encoding Provider

                Encoding.RegisterProvider(CosmosEncodingProvider.Instance);
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                System.CustomConsole.WriteLineInfo("Cecilia Version:" + Kernel.version);
                System.CustomConsole.WriteLineWarning("This version of Cecilia is preview-ro version.");

                #endregion

                #region Commmand Manager Init

                CommandManager.RegisterAllCommands();

                #endregion

                System.CustomConsole.WriteLineInfo("Booting Cecilia Operating System...");

                #region Filesystem Init

                Sys.FileSystem.VFS.VFSManager.RegisterVFS(vFS);
                if (ContainsVolumes())
                {
                    System.CustomConsole.WriteLineOK("FileSystem Registration");
                }
                else
                {
                    System.CustomConsole.WriteLineError("FileSystem Registration");
                }

                #endregion

                System.CustomConsole.WriteLineOK("Cecilia successfully started!");

                #region Installation Init

                setup.InitSetup();

                /*if (SystemExists)
                {
                    if (!JustInstalled)
                    {

                        Settings config = new Settings(@"0:\System\settings.conf");
                        langSelected = config.GetValue("language");

                        #region Language

                        Lang.Keyboard.Init();

                        #endregion

                        Info.getComputerName();

                        System.Network.NetworkInterfaces.Init();

                        running = true;

                    }
                }
                else
                {
                    running = true;
                }*/

                running = true;

                #endregion

                boottime = Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true);
            }
            catch (Exception ex)
            {
                running = false;
                Crash.StopKernel(ex);
            }
        }

        #endregion

        #region Run

        protected override void Run()
        {
            try
            {
                Cosmos.System.PCSpeaker.Beep((uint)Cosmos.System.Notes.B5, 432);
                Cosmos.System.PCSpeaker.Beep((uint)Cosmos.System.Notes.G5, 432);
                Cosmos.System.PCSpeaker.Beep((uint)Cosmos.System.Notes.E5, 432);
                Cosmos.System.PCSpeaker.Beep((uint)Cosmos.System.Notes.D5, 432);
                Cosmos.System.PCSpeaker.Beep((uint)Cosmos.System.Notes.E5, 432);
                Cosmos.System.PCSpeaker.Beep((uint)Cosmos.System.Notes.G5, 432);
                Cosmos.System.PCSpeaker.Beep((uint)Cosmos.System.Notes.E5, 432);
                while (running)
                {
                    if (Logged) //If logged
                    {
                        BeforeCommand();

                        AConsole.writecommand = true;

                        var cmd = Console.ReadLine();

                        CommandManager._CommandManger(cmd);
                    }
                    else
                    {
                        Login.LoginForm();
                    }
                }
            }
            catch (Exception ex)
            {
                running = false;
                Crash.StopKernel(ex);
            }
        }

        #endregion

        #region BeforeCommand
        /// <summary>
        /// Display the line before the user input and set the console color.
        /// </summary>
        public static void BeforeCommand()
        {
            if (current_directory == Kernel.current_volume)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(UserLevel.TypeUser());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(userLogged);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("@");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(ComputerName);

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("> ");

                Console.ForegroundColor = ConsoleColor.White;
                
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(UserLevel.TypeUser());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(userLogged);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("@");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(ComputerName);

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("> ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(current_directory + "~ ");

                Console.ForegroundColor = ConsoleColor.White;

            }
        } 
        #endregion

    }
}
