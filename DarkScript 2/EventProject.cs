using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkScript_2
{
    public class EventProject
    {

        public string ProjectPath { get; set; }
        public string EmevdPath { get; set; }
        public string NumericText { get; set; }

        public EventProject(string path, bool fromProject = true)
        {
            if (fromProject)
            {
                string[] text = File.ReadAllLines(path);
                EmevdPath = text[0];
                NumericText = string.Join(Environment.NewLine, text.Skip(1));
                ProjectPath = EmevdPath + ".dscproj";
            }
            else
            {
                EmevdPath = path;
                NumericText = ReadFile("-n \"" + EmevdPath + "\"");
                ProjectPath = "";
            }
        }

        public void SaveToProject()
        {
            string output = EmevdPath + "\n" + NumericText;
            File.WriteAllText(ProjectPath, output);
        }


        public void SaveToEmevd()
        {
            var fileName = Path.GetRandomFileName();

            File.WriteAllText(fileName, RevertAdjustNumeric(NumericText));
            var p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true; ;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "EventScriptTool.exe";
            p.StartInfo.Arguments = fileName + " -p -o \"" + EmevdPath + "";
            Console.WriteLine(EmevdPath);
            p.Start();
            string err = p.StandardError.ReadToEnd();
            p.WaitForExit();
            p.Dispose();
            File.Delete(fileName);
            if (err.Length > 0) throw new Exception("PYTHON ERROR\n\n" + err);
        }

        public string VerboseOutput()
        {
            string fileName = Path.GetRandomFileName();
            File.WriteAllText(fileName, RevertAdjustNumeric(NumericText));
            string output = ReadFile("-p " + fileName + " -v");
            File.Delete(fileName);
            return AdjustVerbose(output);
        }

        public string VerboseFromString(string input)
        {
            NumericText = input;
            return VerboseOutput();
        }

        private string AdjustNumeric(string numeric) => numeric.Replace(Environment.NewLine + "    ^", " ^");

        private string RevertAdjustNumeric(string numeric) => numeric.Replace(" ^", Environment.NewLine + "    ^");

        private string AdjustVerbose(string verbose) => verbose.Replace(Environment.NewLine + "Parameters:", " | Parameters:");

        private string ReadFile(string arguments)
        {
            string fileName = Path.GetRandomFileName();

            var p = new Process();
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "EventScriptTool.exe";
            p.StartInfo.Arguments = arguments + " -s -o " + fileName;

            p.Start();
            string err = p.StandardError.ReadToEnd();
            p.WaitForExit();
            if (err.Length > 0) throw new Exception("PYTHON ERROR\n\n" + err);

            string output = File.ReadAllText(fileName);
            File.Delete(fileName);
            return output;
        }
    }
}
