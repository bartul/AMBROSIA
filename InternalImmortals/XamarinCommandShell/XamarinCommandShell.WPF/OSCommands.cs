﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Diagnostics;
using System.Security.Cryptography;

namespace XamarinCommandShell.WPF
{
    class OSCommands : IOSCommands
    {
        public void ExecuteCommand(string command)
        {
            var commandProcess = new Process();
            commandProcess.StartInfo.FileName = "cmd.exe";
            commandProcess.StartInfo.Arguments = "/C " + command;
            //            commandProcess.StartInfo.RedirectStandardInput = true;
            //            commandProcess.StartInfo.RedirectStandardOutput = true;
            //            commandProcess.StartInfo.RedirectStandardError = true;
//            commandProcess.StartInfo.CreateNoWindow = true;
            commandProcess.StartInfo.UseShellExecute = false;
            commandProcess.StartInfo.RedirectStandardError = true;
            commandProcess.Start();
        }
    }
}
