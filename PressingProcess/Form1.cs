using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PressingProcess.Model;
using PressingProcess.Routes;
using PressingProcess.Files;
using PressingProcess.Folers;
using PressingProcess.Optimization;

namespace PressingProcess
{
    public partial class Form1 : Form
    {
        ParametricData param = new ParametricData();
        Route rout = new Route();
        CommandCMD cmd = new CommandCMD();
        FileNames file = new FileNames();
        FolderName folder = new FolderName();

        public Form1()
        {
            InitializeComponent();
        }

        private void compute_Click(object sender, EventArgs e)
        {
            ReadFormData();
            FileNames();
            runProgram();
        }

        private void ReadFormData()
        {
            param.r2Start = double.Parse(d2.Text) / 2;
            param.r3Start = double.Parse(d3.Text) / 2;
            param.aStart = double.Parse(αAngle.Text);

            param.r2End = double.Parse(d2End.Text) / 2;
            param.r3End = double.Parse(d3End.Text) / 2;
            param.aEnd = double.Parse(αAngleEnd.Text);

            param.r2Step = double.Parse(d2Step.Text) / 2;
            param.r3Step = double.Parse(d3Step.Text) / 2;
            param.aStep = double.Parse(αAngleStep.Text);

            param.stampThickness = double.Parse(stampThikness.Text);
            param.smallRingThickness = double.Parse(smallRingThikness.Text);
            param.bigRingThickness = double.Parse(bigRingThikness.Text);
        }

        public void FileNames()
        {
            rout.cmdEXE = Environment.GetFolderPath(Environment.SpecialFolder.System);
            rout.systemDisk = Environment.SystemDirectory.Substring(0, 1) + " ";

            folder.scriptsFolder = "Scripts";

            file.abaqusMacos = "abaqusMacros.py";
            file.extractFileName = "extract.py";

            file.Stress = "SOutput.csv";
            file.Deformation = "LEOutput.csv";
            file.PlasticDeformation = "PEEQOutput.csv";

            file.blank = "Blank.IGS";
            file.stamp = "Stamp.IGS";
            file.platform = "Platform.IGS";
            file.ring1 = "Ring1.IGS";
            file.ring2 = "Ring2.IGS";

            cmd.extractFiles = "abaqus cae script noGUI=extract.py";
            cmd.runAbaqus = "abaqus cae script noGUI=abaqusMacros.py";
        }

        public void runProgram()
        {
            var run = new Perebor(param,file,folder,rout,cmd);
            run.iteration();
        }
    }
}
