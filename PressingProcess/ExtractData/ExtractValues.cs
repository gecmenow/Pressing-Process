using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using PressingProcess.Routes;
using PressingProcess.Model;

namespace PressingProcess.ExtractData
{
    class ExtractValues
    {
        Dictionary<double, double> Values = new Dictionary<double, double>();

        double minValue;
        double avgValue;
        double maxValue;

        public double getMinValue()
        { return minValue; }

        public double getAvgValue()
        { return avgValue; }

        public double getMaxValue()
        { return maxValue; }

        public void Extract(string rout)
        {
            try
            {
                Values.Clear();

                Values = File.ReadLines(rout)
                        .Skip(1)
                        .Select(line => line.Split(';'))
                        .ToDictionary(key => Convert.ToDouble(key[0]), value => Convert.ToDouble(value[1]));

                Values = Values
                .Where(v => v.Value != 0)
                .ToDictionary(k => k.Key, v => v.Value);

                minValue = Values.Min(v => v.Value);
                avgValue = Values.Average(v => v.Value);
                maxValue = Values.Max(v => v.Value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Extract Values");
            }
        }
    }
}
