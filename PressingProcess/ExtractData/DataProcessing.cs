using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using PressingProcess.Model;
using PressingProcess.Files;
using PressingProcess.Routes;
using PressingProcess.Reports;

namespace PressingProcess.ExtractData
{
    class DataProcessing
    {
        Route rout = new Route();
        CommandCMD cmd = new CommandCMD();

        public DataProcessing(Route rout, CommandCMD cmd)
        {
            this.rout = rout;
            this.cmd = cmd;
        }

        #region Обработка полученных результатов

        public void Processing(FileNames file, ParametricData param)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                var extractODB = new ExtractFromOdb();

                extractODB.ExtractFiles(rout, cmd.extractFiles);

                rout.StressRout = rout.workingDirectory + @"\" + file.Stress;
                rout.DeformationRout = rout.workingDirectory + @"\" + file.Deformation;
                rout.PlasticDeformationRout = rout.workingDirectory + @"\" + file.PlasticDeformation;
                                
                var extr = new ExtractValues();

                var rpr = new Report(param);

                extr.Extract(rout.StressRout);
                rpr.makeReport("Stress", extr);

                extr.Extract(rout.DeformationRout);
                rpr.makeReport("Deformation", extr);

                extr.Extract(rout.PlasticDeformationRout);
                rpr.makeReport("Plastic Deformation", extr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion
    }
}
