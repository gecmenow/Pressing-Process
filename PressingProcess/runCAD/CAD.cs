//made by Kirill Tatarincev
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

using PressingProcess.Model;
using PressingProcess.Files;
using PressingProcess.Routes;

namespace PressingProcess.runCAD
{
    class CAD
    {
        public void UseSolid(FileNames file, ParametricData param, Route rout)
        {
            SldWorks swApp;
            IModelDoc2 swModel;

            CloseSolid();

            object process = System.Activator.CreateInstance(System.Type.GetTypeFromProgID("SldWorks.Application"));
            swApp = (SldWorks)process;
            swApp.Visible = false;
            swApp.NewPart();
            swModel = swApp.IActiveDoc2;

            double r1 = 0.02;
            double r3 = param.r3 / 1000;
            double r2 = param.r2 / 1000;

            double thickness = (param.stampThickness + 20) / 1000;//0.08-0.02=0.06 ТОЛЩИНА ШТАМПА
            double thicknessRing1 = param.smallRingThickness / 1000;//ТОЛЩИНА кольца1
            double thicknessRing2 = param.bigRingThickness / 1000;//ТОЛЩИНА кольца2

            double angle1 = Math.Tan((90 - param.a) * Math.PI / 180) * (r1 - r2);
            double angle2 = Math.Tan((90 - param.a) * Math.PI / 180) * (r2 - r3);
            //Матрица

            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);

            swModel.SketchManager.CreateLine(0.02, 0, 0, 0.02, 0.05, 0);//1
            swModel.SketchManager.CreateLine(0.02, 0.05, 0, r3, 0.07, 0);//2
            swModel.SketchManager.CreateLine(r3, 0.07, 0, r3, 0.085, 0);//3
            swModel.SetInferenceMode(false);
            swModel.SketchManager.CreateLine(r3, 0.085, 0, r2, angle2 + 0.085, 0);//4
            swModel.SetInferenceMode(true);
            swModel.SketchManager.CreateLine(r2, angle2 + 0.085, 0,
                r2, (angle2 + 0.085) + 0.015, 0);//5
            swModel.SetInferenceMode(false);
            swModel.SketchManager.CreateLine(r2, (angle2 + 0.085) + 0.015, 0,
                0.02, ((angle1 + 0.085) + 0.015) + (angle2), 0);//6
            swModel.SetInferenceMode(true);
            swModel.SketchManager.CreateLine(0.02, ((angle1 + 0.085) + 0.015) + (angle2), 0,
                0.02, ((angle1 + 0.085) + 0.015) + (angle2) + 0.07, 0);//7
            swModel.SketchManager.CreateLine(0.02, ((angle1 + 0.085) + 0.015) + (angle2) + 0.07, 0,
                thickness, ((angle1 + 0.085) + 0.015) + (angle2) + 0.07, 0);//8
            swModel.SketchManager.CreateLine(thickness, 0, 0, thickness, 0.05, 0);//9            
            swModel.SketchManager.CreateLine(thickness, 0.05, 0,
               thickness + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0);//10
            swModel.SetInferenceMode(false);
            swModel.SketchManager.CreateLine(thickness + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0,
                thickness, ((angle1 + 0.085) + 0.015) + (angle2) + (((angle1 + 0.085) + 0.015) + (angle2) - 0.05), 0);//11            
            swModel.SketchManager.CreateLine(thickness, ((angle1 + 0.085) + 0.015) + (angle2) + (((angle1 + 0.085) + 0.015) + (angle2) - 0.05), 0,
                thickness, ((angle1 + 0.085) + 0.015) + (angle2) + 0.07, 0);//12            
            swModel.SetInferenceMode(true);
            swModel.SketchManager.CreateLine(thickness, 0, 0, 0.02, 0, 0);//13            
            swModel.SketchManager.CreateCenterLine(0, 0, 0, 0, 0.05, 0);//14
            swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.Extension.SelectByID2("Line11", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.Extension.SelectByID2("Line12", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.ClearSelection2(true);
            swModel.Extension.SelectByID2("Line14", "SKETCHSEGMENT", 0, 0, 0, false, 16, null, 0);
            swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SaveAs3((rout.stampFolder), 0, 0);

            swApp.NewPart();
            swModel = swApp.IActiveDoc2;
            swApp.CloseDoc("Деталь1.SLDPRT");

            //заготовка

            double height = param.blankHeight / 1000;

            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);

            swModel.SketchManager.CreateLine(0, 0, 0, 0.02, 0, 0);
            swModel.SketchManager.CreateLine(0.02, 0, 0, 0.02, height, 0);
            swModel.SketchManager.CreateLine(0.02, height, 0, 0, height, 0);
            swModel.SketchManager.CreateLine(0, height, 0, 0, 0, 0);
            swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 16, null, 0);
            swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SaveAs3((rout.blankFolder), 0, 0);

            swApp.NewPart();
            swModel = swApp.IActiveDoc2;
            swApp.CloseDoc("Деталь2.SLDPRT");

            //толкатель = платформа

            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0, 0, 0, 0.025, 0, 0);
            swModel.SketchManager.CreateLine(0.025, 0, 0, 0.025, 0.003, 0);
            swModel.SketchManager.CreateLine(0.025, 0.003, 0, 0, 0.003, 0);
            swModel.SketchManager.CreateLine(0, 0.003, 0, 0, 0, 0);
            swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 16, null, 0);
            swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SaveAs3((rout.platformFolder), 0, 0);

            //бандаж1

            swApp.NewPart();
            swModel = swApp.IActiveDoc2;
            swApp.CloseDoc("Деталь3.SLDPRT");

            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(thickness + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0,
                thickness, ((angle1 + 0.085) + 0.015) + (angle2) + (((angle1 + 0.085) + 0.015) + (angle2) - 0.05), 0);

            swModel.SketchManager.CreateLine(thickness + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0,
                thickness + thicknessRing1 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0);

            swModel.SketchManager.CreateLine(thickness + thicknessRing1 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0,
               thickness + thicknessRing1 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2) + (((angle1 + 0.085) + 0.015) + (angle2) - 0.05), 0);
            swModel.SketchManager.CreateLine(thickness + thicknessRing1 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2) + (((angle1 + 0.085) + 0.015) + (angle2) - 0.05), 0, thickness, ((angle1 + 0.085) + 0.015) + (angle2) + (((angle1 + 0.085) + 0.015) + (angle2) - 0.05), 0);

            swModel.SketchManager.CreateCenterLine(0, 0, 0, 0, 0.05, 0);
            swModel.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 16, null, 0);
            swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SaveAs3((rout.ring1Folder), 0, 0);


            swApp.NewPart();
            swModel = swApp.IActiveDoc2;
            swApp.CloseDoc("Деталь4.SLDPRT");

            //бандаж2

            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(thickness, 0.05, 0,
            thickness + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0);

            swModel.SketchManager.CreateLine(thickness + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0, thickness + thicknessRing2 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0);
            swModel.SketchManager.CreateLine(thickness + thicknessRing2 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), ((angle1 + 0.085) + 0.015) + (angle2), 0, thickness + thicknessRing2 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), 0.05, 0);
            swModel.SketchManager.CreateLine(thickness, 0.05, 0,
                thickness + thicknessRing2 + (Math.Tan(3 * Math.PI / 180) * (((angle1 + 0.085) + 0.015) + (angle1) - 0.05)), 0.05, 0);
            swModel.SketchManager.CreateCenterLine(0, 0, 0, 0, 0.05, 0);
            swModel.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 16, null, 0);
            swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SaveAs3((rout.ring2Folder), 0, 0);

            CloseSolid();
        }

        public void CloseSolid()
        {
            //закрытие приложения, если оно открыто
            Process[] processes = Process.GetProcessesByName("SLDWORKS");
            foreach (Process p in processes)
            {
                p.CloseMainWindow();
                p.Kill();
            }
        }
    }
}
