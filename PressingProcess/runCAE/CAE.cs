using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

using PressingProcess.Routes;

namespace PressingProcess.runCAE
{
    class CAE
    {
        const string name = "ABQcaeG";//процесс, который нужно закрыть
        public void runAbaqus(Route rout, CommandCMD cmd)
        {
            try
            {
                Process[] etc = Process.GetProcesses();//получим процессы
                foreach (Process anti in etc)//обойдем каждый процесс
                    if (anti.ProcessName.ToLower().Contains(name.ToLower())) anti.Kill();//переводим имя в нижний регистр, на всякий пожарный

                var proc = new Process();
                proc.StartInfo.UseShellExecute = false; //нужно для правильного запуска консоли, но т.к. мы явно указываем консоль, то оно особо и не нужно
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
                proc.StartInfo.WorkingDirectory = rout.workingDirectory;//рабочая дериктория, чтобы консоль видела макрос
                proc.StartInfo.FileName = Path.Combine(rout.cmdEXE, "cmd.exe");
                proc.StartInfo.Arguments = "/" + rout.systemDisk + cmd.runAbaqus; //передаем команду в консоль
                proc.StartInfo.CreateNoWindow = true; // Скрывает консоль

                proc.Start();

                StreamReader writer = proc.StandardOutput;

                string output = writer.ReadToEnd();
                // Write the redirected output to this application's window.
                File.WriteAllText(rout.workingDirectory  + @"\log.txt", output);

                proc.WaitForExit();
                proc.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Abaqus" + e.Message);
            }
        }
    }
}
