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
using System.Diagnostics;
using FastColoredTextBoxNS;

namespace DarkScript_2
{
    public partial class GUI : Form
    {
        public EventProject Project;
        public GUI thisForm;
        public bool scrolling = false;

        public GUI()
        {
            SetStyles();
            InitializeComponent();
            editorSplit.SplitterDistance = 400;
            thisForm = this;

            editorNumeric.AllowSeveralTextStyleDrawing = true;
            editorVerbose.AllowSeveralTextStyleDrawing = true;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            editorSplit.SplitterWidth = 20;
            editorSplit.SplitterDistance = 400;
        }

        private void ScrollPosChanged(FastColoredTextBox target, FastColoredTextBox source)
        {
            if (scrolling) return;
            scrolling = true;
            if (source.VerticalScroll.Value <= target.VerticalScroll.Maximum)
            {
                int a = target.VerticalScroll.Maximum;
                int b = source.VerticalScroll.Maximum;
                int c = source.VerticalScroll.Value;
                int val = Math.Min(Math.Min(a, b), c);
                int checkCount = 0;
                while (target.VerticalScroll.Value != val)
                {
                    if (checkCount > 2) break;
                    target.VerticalScroll.Value = val;
                    checkCount++;
                }
            }
            Console.WriteLine("SRC --> " + source.VerticalScroll.Value + " : TGT --> " + target.VerticalScroll.Value);
            scrolling = false;
        }

        private void SyncNumToVerb() => ScrollPosChanged(editorNumeric, editorVerbose);

        private void SyncVerbToNum() => ScrollPosChanged(editorVerbose, editorNumeric);

        private void editorNumeric_Scroll(object sender, ScrollEventArgs e) => SyncVerbToNum();

        private void editorNumeric_SelectionChangedDelayed(object sender, EventArgs e) => SyncVerbToNum();

        private void editorNumeric_SelectionChanged(object sender, EventArgs e) => SyncVerbToNum();

        private void editorVerbose_Scroll(object sender, ScrollEventArgs e) => SyncNumToVerb();

        private void editorVerbose_SelectionChanged(object sender, EventArgs e) => SyncNumToVerb();

        private void editorVerbose_SelectionChangedDelayed(object sender, EventArgs e) => SyncNumToVerb();

        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
            FastColoredTextBox box = sender as FastColoredTextBox;
            if (e.Control && e.KeyCode == Keys.F)
            {
                box.ShowFindDialog();
            } else if (e.Control && e.Shift && e.KeyCode == Keys.R)
            {
                box.ShowReplaceDialog();
            } else
            {
                e.SuppressKeyPress = false;
                e.Handled = false;
            }
            

        }

        static Dictionary<string, Style> Styles = new Dictionary<string, Style>();

        private void SetStyles()
        {
            TextStyle style(Brush b) => new TextStyle(b, Brushes.Transparent, FontStyle.Regular);
            Styles["GREEN"] = style(Brushes.DarkGreen);
            Styles["BLUE"] = style(Brushes.Blue);
            Styles["DARKBLUE"] = style(Brushes.DarkBlue);
            Styles["SLATEBLUE"] = style(Brushes.DarkSlateBlue);
            Styles["PURPLE"] = style(Brushes.DarkMagenta);
            Styles["BLACK"] = style(Brushes.Black);
            Styles["RED"] = style(Brushes.Red);
            Styles["GRAY"] = style(Brushes.Gray);
        }



        private void editorNumeric_TextChanged(object sender, TextChangedEventArgs e)
        {

            void style(string brush, string pattern) => e.ChangedRange.SetStyle(Styles[brush], pattern);

            e.ChangedRange.ClearStyle(Styles.Values.ToArray());

            style("SLATEBLUE", "\\d+");
            style("GREEN", "[A-Za-z]+");
            style("BLUE", "(?<range>\\d+)\\[\\d+\\]");
            style("BLUE", "\\d+\\[(?<range>\\d+)\\]");
            style("DARKBLUE", "\\n\\d+,\\s*\\d+\\s*\\n");
            style("BLACK", "EVD[^\\n]+");
            style("GRAY", "#([^\\r\\n]|#)*");
        }


        private void editorVerbose_TextChanged(object sender, TextChangedEventArgs e)
        {
            void style(string brush, string pattern) => e.ChangedRange.SetStyle(Styles[brush], pattern);

            e.ChangedRange.ClearStyle(Styles.Values.ToArray());

            style("BLACK", "[(){},]+");
            style("BLACK", "\\)\\s*\n");
            style("RED", "\\b(SKIP|END|IF)\\b");
            style("GREEN", "\\b(AND|OR|MAIN)\\n");
            style("BLUE", "\\b(END|Disable|Enable|RESTART|Set|Initialize|Batch)\\b");
            style("SLATEBLUE", "\\d+");
            style("SLATEBLUE", "[A-Za-z0-9\\s]+:(?<range>[^,)]+)");
            style("PURPLE", "(?<range>[A-Za-z0-9-\\s]+):([^,)]+)");
        }

        private void GUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (Project == null) return;
        }

        private void RefreshVerbose()
        {
            if (Project == null) return;
            int cursorPos = editorNumeric.SelectionStart;
            int scrollPos = editorNumeric.VerticalScroll.Value;
            editorVerbose.Text = Project.VerboseFromString(editorNumeric.Text);

            editorNumeric.SelectionStart = cursorPos;
            editorNumeric.SelectionLength = 0;
            editorNumeric.VerticalScroll.Value = scrollPos;
            editorVerbose.VerticalScroll.Value = scrollPos;
            editorNumeric.VerticalScroll.Value = scrollPos;
            editorVerbose.VerticalScroll.Value = scrollPos;
        }

        private void refreshProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshVerbose();
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Project == null) return;
            Project.NumericText = editorNumeric.Text;
            if (string.IsNullOrWhiteSpace(Project.ProjectPath))
            {
                saveProjectAsToolStripMenuItem_Click(sender, e);
            } else
            {
                Project.SaveToProject();
            }
            RefreshVerbose();
        }

        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Project == null) return;
            var sfd = new SaveFileDialog();
            sfd.Title = "Save Project As";
            if (string.IsNullOrWhiteSpace(Project.ProjectPath))
            {
                sfd.InitialDirectory = Path.GetDirectoryName(Project.EmevdPath);
                sfd.FileName = Path.GetFileName(Project.EmevdPath) + ".dscproj";
            } else
            {
                sfd.InitialDirectory = Path.GetDirectoryName(Project.ProjectPath);
            }
            sfd.FileName = Path.GetFileName(Project.ProjectPath);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Project.NumericText = editorNumeric.Text;
                Project.ProjectPath = sfd.FileName;
                Project.SaveToProject();
            }
            RefreshVerbose();
        }


        private void openEMEVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Path.GetExtension(ofd.FileName) == ".dscproj")
                    {
                        Project = new EventProject(ofd.FileName, true);
                    }
                    else
                    {
                        if (!File.Exists(ofd.FileName + ".bak")) File.Copy(ofd.FileName, ofd.FileName + ".bak");
                        if (File.Exists(ofd.FileName + ".dscproj"))
                        {
                            var result = MessageBox.Show("An event project already exists for this file. Load it?", "Alert", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes) Project = new EventProject(ofd.FileName + ".dscproj", true);
                            else Project = new EventProject(ofd.FileName, false);
                        } else Project = new EventProject(ofd.FileName, false);
                    }
                    editorNumeric.Text = Project.NumericText;
                    editorVerbose.Text = Project.VerboseOutput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void saveEMEVDAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Project == null) return;
            var sfd = new SaveFileDialog();
            sfd.Title = "Save EMEVD As";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Project.EmevdPath = sfd.FileName;
                Project.SaveToProject();
                Project.SaveToEmevd();
            }
        }

        private void saveEMEVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Project == null) return;
            MessageBox.Show(Project.EmevdPath);
            Project.SaveToEmevd();
        }
    }
}
