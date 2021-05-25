using Aura_OS.Apps.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aura_OS.System.Shell.cmdIntr.Tools
{
    class CommandAppletman : ICommand
    {
        public List<string> RegisteredApplications;
        public List<string> RegisteredApplicationPath;
        private List<string> globalArgs;
        bool isInstall = false;
        public CommandAppletman(string[] commandvalues) : base(commandvalues)
        {
            Description = "run or install an application.";
        }
        public override ReturnInfo Execute(List<string> args)
        {
            if (args[0] == "install") isInstall = true;
            
            return new ReturnInfo(this, ReturnCode.OK);
        }
        private void OverrideAException()
        {

        }
        private void RunApplication(string applicationCallName,List<string> args)
        {
            for (int i = 0; i <= RegisteredApplications.Count; i++)
            {
                if (applicationCallName != RegisteredApplications[i]) //isnt have;
                {
                    i++;
                }
                else
                {
                    string path = RegisteredApplicationPath[i];
                    string name = RegisteredApplications[i];
                    if (string.IsNullOrEmpty(path))
                    {
                        Crash.StopKernel("FileNotfoundError", "File not found in any disk.", "0x000042EA9000", "00002000");
                    }
                    else
                    {
                        switch (name)
                        {
                            case "cil":
                                {
                                    string targetPath = args[1];
                                    string targetDirectory = args[2];
                                    Editor e = new Editor();
                                    e.Start(targetPath, targetDirectory);
                                    break;
                                }
                            default:
                                {
                                    Crash.StopKernel("CommandNotfoundError", "command cannot catched in any cases.", "0x000", "00000");
                                    break;
                                }
                        }
                    }
                }
            }
        }
    }
}
