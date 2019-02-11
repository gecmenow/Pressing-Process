//made by Karachentsev Egor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using PressingProcess.Model;
using PressingProcess.Routes;
using PressingProcess.Folers;
using PressingProcess.Files;
using PressingProcess.Change;
using PressingProcess.ExtractData;
using PressingProcess.runCAD;
using PressingProcess.runCAE;

namespace PressingProcess.Function
{
    class MainFunction
    {
        ParametricData param = new ParametricData();
        FolderName folder = new FolderName();
        FileNames file = new FileNames();
        Route rout = new Route();
        ChangeWords change = new ChangeWords();
        CommandCMD cmd = new CommandCMD();

        public MainFunction(ParametricData param ,FileNames file, FolderName folder,Route rout, CommandCMD cmd)
        {
            this.param = param;
            this.file = file;
            this.folder = folder;
            this.rout = rout;
            this.cmd = cmd;
        }

        public void runFunction()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            #region Создание общей папки

            folder.generalFolder = (param.r2 * 2).ToString();

            if (!Directory.Exists(folder.generalFolder))
                Directory.CreateDirectory(folder.generalFolder);

            #endregion

            string abaqusOutputFolder = Convert.ToString(param.r3 * 2)+ "(d3)" 
                                        + Convert.ToString(param.a) + "(angle)";

            folder.outputFolder = Path.Combine(folder.generalFolder, abaqusOutputFolder);

            if (!Directory.Exists(folder.outputFolder))
                Directory.CreateDirectory(folder.outputFolder);

            #region Пути для солида

            rout.stampFolder = Path.Combine(Environment.CurrentDirectory, folder.outputFolder, file.stamp);
            rout.stampFolder = rout.stampFolder.Replace(@"\", "/");
            rout.blankFolder = Path.Combine(Environment.CurrentDirectory, folder.outputFolder, file.blank);
            rout.blankFolder = rout.blankFolder.Replace(@"\", "/");
            rout.platformFolder = Path.Combine(Environment.CurrentDirectory, folder.outputFolder, file.platform);
            rout.platformFolder = rout.platformFolder.Replace(@"\", "/");
            rout.ring1Folder = Path.Combine(Environment.CurrentDirectory, folder.outputFolder, file.ring1);
            rout.ring1Folder = rout.ring1Folder.Replace(@"\", "/");
            rout.ring2Folder = Path.Combine(Environment.CurrentDirectory, folder.outputFolder, file.ring2);
            rout.ring2Folder = rout.ring2Folder.Replace(@"\", "/");

            #endregion

            rout.workingDirectory = folder.outputFolder;
            
            double r1 = 20;
            double temp = Math.Tan((90 - param.a) * Math.PI / 180);

            double h3 = Math.Tan((90 - param.a) * Math.PI / 180) * (r1 - param.r2);
            
            double h3Volume = (Math.PI * h3 * (Math.Pow(r1, 2) + r1 * param.r2 + Math.Pow(param.r2, 2))) / 3;

            double h4 = 15;

            double h4Volume = Math.PI * Math.Pow(param.r2, 2) * h4;

            double h5 = Math.Tan((90 - param.a) * Math.PI / 180) * (param.r2 - param.r3);

            double h5Volume = (Math.PI * h5 * (Math.Pow(param.r2, 2) + param.r2 * param.r3 + Math.Pow(param.r3, 2))) / 3;

            double h6 = h4;

            double h6Volume = Math.PI * Math.Pow(param.r3, 2) * h6;

            double blankVolume = h3Volume + h4Volume + h5Volume + h6Volume;

            param.blankHeight = blankVolume / (Math.PI * Math.Pow(r1,2));

            param.goodBlankPosition = ((h3 + 85) + 15) + (h5);
            param.goodBlankPosition = Math.Round(param.goodBlankPosition, 2);

            param.badBlankPosition = param.goodBlankPosition + param.blankHeight;
            param.badBlankPosition = Math.Round(param.badBlankPosition, 2);

            param.platformPosition = param.badBlankPosition + param.blankHeight;
            param.platformPosition = Math.Round(param.platformPosition, 2);

            param.displacement = (param.blankHeight * 2) / 0.05;
            param.displacement = Math.Round(param.displacement, 1);

            var solid = new CAD();
            solid.UseSolid(file, param, rout);

            change.ChangeWordsInFile(rout, folder, file, param);

            var abaqus = new CAE();
            abaqus.runAbaqus(rout, cmd);

            change.RewriteExtract(rout, folder, file, param);

            var run = new DataProcessing(rout,cmd);
            run.Processing(file, param);
        }
    }
}
