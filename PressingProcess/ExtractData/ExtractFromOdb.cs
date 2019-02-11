using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

using PressingProcess.Routes;
using PressingProcess.Files;

namespace PressingProcess.ExtractData
{
    class ExtractFromOdb
    {
        const string name = "ABQcaeG";//процесс, который нужно закрыть

        public void ExtractFiles(Route rout, string cmd)
        {
            try
            {
                Process[] etc = Process.GetProcesses();//получим процессы
                foreach (Process anti in etc)//обойдем каждый процесс
                    if (anti.ProcessName.ToLower().Contains(name.ToLower())) anti.Kill();//переводим имя в нижний регистр, на всякий пожарный

                var proc = new ProcessStartInfo()
                {
                    UseShellExecute = true, //нужно для правильного запуска консоли, но т.к. мы явно указываем консоль, то оно особо и не нужно
                    WorkingDirectory = rout.workingDirectory,//рабочая дериктория, чтобы консоль видела макрос
                    FileName = Path.Combine(rout.cmdEXE, "cmd.exe"),
                    Arguments = "/" + rout.systemDisk + cmd, //передаем команду в консоль
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(proc).WaitForExit();
            }
            catch (Exception e)
            {
                MessageBox.Show("Abaqus", e.Message);
            }
        }
    }
}
