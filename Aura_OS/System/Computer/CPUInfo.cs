/*
* PROJECT:          Aura Operating System Development
* CONTENT:          CPU Informations
* PROGRAMMERS:      Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using Aura_OS.System.Shell.cmdIntr;
using Cosmos.System.PCInfo;
using System.Collections.Generic;
using System;

namespace Aura_OS.System.Computer
{
    public class CPUInfo : ICommand
    {
        public CPUInfo(string[] commandvalues) : base(commandvalues)
        {
            Description = "get cpu info";
        }
        //public static List<Processor> Processors = new List<Processor>();
        public override ReturnInfo Execute()
        {
            Console.WriteLine("CPU Information");
            Console.WriteLine("CPU #0:                  " + "UNKNOWN");
            Console.WriteLine("CPU AAVM:                " + "Full(software)");
            Console.WriteLine("CPU AVMI:                " + "4.2x16(software)");
            Console.WriteLine("Compatible Layer:        " + "BCL(bcl40_intel_amd_abstractl)");
            Console.WriteLine("");
            return new ReturnInfo(this, ReturnCode.OK);
        }
    }
}
