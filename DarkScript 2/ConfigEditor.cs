using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DarkScript_2
{
    public partial class ConfigEditor : Form
    {
        public GUIConfig Config;

        public ConfigEditor(GUIConfig config)
        {
            InitializeComponent();
            Config = config;
            if (Config.ExistingProjectAction == EPHV.Ask) askBtn.Checked = true;
            else if (Config.ExistingProjectAction == EPHV.Backup) backupBtn.Checked = true;
            else if (Config.ExistingProjectAction == EPHV.Load) loadBtn.Checked = true;
            else if (Config.ExistingProjectAction == EPHV.Overwrite) overwriteBtn.Checked = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (askBtn.Checked) Config.ExistingProjectAction = EPHV.Ask;
            else if (backupBtn.Checked) Config.ExistingProjectAction = EPHV.Backup;
            else if (loadBtn.Checked) Config.ExistingProjectAction = EPHV.Load;
            else if (overwriteBtn.Checked) Config.ExistingProjectAction = EPHV.Overwrite;
            Config.Write("DarkScript2.config");
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public class GUIConfig
    {
        [DisplayName("Action when loading an EMEVD with an existing project file.")]
        public EPHV ExistingProjectAction { get; set; }

        public GUIConfig()
        {
            ExistingProjectAction = EPHV.Ask;
        }

        public GUIConfig(string file)
        {
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                var s = line.Split('=');
                if (s.Length != 2) continue;
                string prop = s[0];
                string val = s[1];
                if (prop == "ExistingProjectAction") ExistingProjectAction = (EPHV) Enum.Parse(typeof(EPHV), val);
            }
        }

        public void Write(string file)
        {
            var sb = new StringBuilder();
            var props = GetType().GetProperties();
            foreach (var prop in props) sb.AppendLine(prop.Name + "=" + prop.GetValue(this).ToString());
            File.WriteAllText(file, sb.ToString().Trim());
        }
    }

    public enum EPHV { Ask, Load, Backup, Overwrite }
}
