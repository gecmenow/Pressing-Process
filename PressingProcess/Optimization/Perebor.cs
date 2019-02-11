using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using PressingProcess.Model;
using PressingProcess.Routes;
using PressingProcess.Files;
using PressingProcess.Folers;
using PressingProcess.Function;


namespace PressingProcess.Optimization
{
    class Perebor
    {
        ParametricData param = new ParametricData();
        FileNames file = new FileNames();
        FolderName folder = new FolderName();
        Route rout = new Route();
        CommandCMD cmd = new CommandCMD();

        public Perebor(ParametricData param, FileNames file, FolderName folder, Route rout, CommandCMD cmd)
        {
            this.param = param;
            this.file = file;
            this.folder = folder;
            this.rout = rout;
            this.cmd = cmd;
        }

        public void iteration()
        {
            for (param.r2 = param.r2Start; param.r2 <= param.r2End; param.r2 += param.r2Step)
            {
                for (param.r3 = param.r3Start; param.r3 <= param.r3End; param.r3 += param.r3Step)
                {
                    for (param.a = param.aStart; param.a <= param.aEnd; param.a += param.aStep)
                    {
                        var func = new MainFunction(param, file, folder, rout,cmd);
                        func.runFunction();
                    }
                }
            }
        }
    }
}
