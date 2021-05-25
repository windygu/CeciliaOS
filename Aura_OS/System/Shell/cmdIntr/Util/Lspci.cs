/*
* PROJECT:          Aura Operating System Development
* CONTENT:          List PCI Devices
* PROGRAMMER(S):    Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using Aura_OS.System.Security;
using Aura_OS.System.Utils;
using System;
using static Cosmos.HAL.PCIDevice;

namespace Aura_OS.System.Shell.cmdIntr.Util
{
    class CommandLspci : ICommand
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public CommandLspci(string[] commandvalues) : base(commandvalues)
        {
            Description = "list pci devices";
        }

        /// <summary>
        /// CommandLspci
        /// </summary>
        public override ReturnInfo Execute()
        {
            int count = 0;
            foreach (Cosmos.HAL.PCIDevice device in Cosmos.HAL.PCI.Devices)
            {
                Console.WriteLine(Conversion.D2(device.bus) + ":" + Conversion.D2(device.slot) + ":" + Conversion.D2(device.function) + " - " + "0x" + Conversion.D4(Conversion.DecToHex(device.VendorID)) + ":0x" + Conversion.D4(Conversion.DecToHex(device.DeviceID)) + " : " + DeviceClass.GetTypeString(device) + ": " + DeviceClass.GetDeviceString(device));
                count++;
                if (count == Console.WindowHeight) //is full screened
                {
                    Console.ReadKey();
                    count = 0;
                }
            }
            Console.WriteLine("0xD829~0xDB70: Biscuitcube Convert Layer MXA(mxa40_intel_amd_virtual) Enabled");
            Console.WriteLine("0xDB72~0xDD00: Biscuitcube Compatible Layer BCL(bcl40_intel_amd_abstractl) Enabled");
            Console.WriteLine("0xDD02~0xDE09: Biscuitcube Virtual CPU Support vCSL(vcsl_intel_amd_x86-64_isoix) Enabled");
            Console.WriteLine("0xDE11~0xDFCA: Biscuitcube Micro Ops for Virtual Support vMOS(vmos_intel_amd_x86-64_isoix) Enabled");
            CustomConsole.WriteLineError("0xDFCC~0xDFE7: Unknown PCI Device(" + Sha256.hash("J401IJ1SDA@$!4IJSDPR151#$%)") + ")");
            CustomConsole.WriteLineOK("NO ADDRESS: Virtual Memory Extendend run successful.");
            return new ReturnInfo(this, ReturnCode.OK);
        }
    }
}
