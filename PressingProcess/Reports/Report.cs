using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using PressingProcess.ExtractData;
using PressingProcess.Model;

namespace PressingProcess.Reports
{
    class Report
    {
        ParametricData param = new ParametricData();

        public Report(ParametricData param)
        { this.param = param; }

        public void makeReport(string outputVariable, ExtractValues extract)
        {
            String header = String.Join(
                Environment.NewLine,
                  "d2, mm" + ";"
                + "d3, mm" + ";"
                + "angle, °" + ";"
                + "min" + "outputVariable" + ", PA" + ";"
                + "avg" + "outputVariable" + ", PA" + ";"
                + "max" + "outputVariable" + ", PA" + ";"
                + Environment.NewLine);

            String csv = String.Join(
                         Environment.NewLine,
                            (param.r2 * 2) + ";"
                          + (param.r3 * 2) + ";"
                          + param.a  + ";"
                          + extract.getMinValue() + ";"
                          + extract.getAvgValue() + ";"
                          + extract.getMaxValue() + ";");

            string fileName = outputVariable + ".csv";

            string path = Path.Combine((param.r2 * 2).ToString(), fileName);

            if (!File.Exists(path))
                File.WriteAllText(path, header);

            File.AppendAllText(path, csv + Environment.NewLine);
        }
    }
}
