using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

using PressingProcess.Routes;
using PressingProcess.Folers;
using PressingProcess.Files;
using PressingProcess.Model;

namespace PressingProcess.Change
{
    class ChangeWords
    {
        public void ChangeWordsInFile(Route rout, FolderName folder, FileNames file, ParametricData param)
        {
            string scriptIn = folder.scriptsFolder + @"\" + file.abaqusMacos;
            string scriptOut = rout.workingDirectory + @"\" + file.abaqusMacos;

            try
            {
                var reader = new StreamReader(scriptIn);
                string content = reader.ReadToEnd();
                reader.Close();

                content = Regex.Replace(content, "@StampFolder", Convert.ToString(rout.stampFolder));
                content = Regex.Replace(content, "@BlankFolder", Convert.ToString(rout.blankFolder));
                content = Regex.Replace(content, "@PlatformFolder", Convert.ToString(rout.platformFolder));
                content = Regex.Replace(content, "@Ring1Folder", Convert.ToString(rout.ring1Folder));
                content = Regex.Replace(content, "@Ring2Folder", Convert.ToString(rout.ring2Folder));
                content = Regex.Replace(content, "@GoodBlankPosition", Convert.ToString(param.goodBlankPosition));
                content = Regex.Replace(content, "@BadBlankPosition", Convert.ToString(param.badBlankPosition));
                content = Regex.Replace(content, "@PlatformPosition", Convert.ToString(param.platformPosition));
                content = Regex.Replace(content, "@Displacement", Convert.ToString(param.displacement));

                var writer = new StreamWriter(scriptOut);
                writer.Write(content);
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Change: ", e.Message);
            }
        }

        public void RewriteExtract(Route rout, FolderName folder, FileNames file, ParametricData param)
        {
            string scriptIn = folder.scriptsFolder + @"\" + file.extractFileName;
            string scriptOut = rout.workingDirectory + @"\" + file.extractFileName;

            try
            {
                var reader = new StreamReader(scriptIn);
                string content = reader.ReadToEnd();
                reader.Close();

                var writer = new StreamWriter(scriptOut);
                writer.Write(content);
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Change: ", e.Message);
            }
        }
    }
}
