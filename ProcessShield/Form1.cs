using dnlib.DotNet;
using dnlib.DotNet.Writer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcessShield.Theme;


//TODO: Add Inject Helper to plugin base
namespace ProcessShield
{
    public partial class Form1 : Form
    {

        private static ButtonBorderStyle dashColor = ButtonBorderStyle.Dashed;

        public Form1()
        {
            InitializeComponent();
            titleBar1.Text = "Process Shield";
            extraListBox1.Enabled = false;
            extraListBox2.Enabled = false;
        }

        private void dragPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dragPanel.ClientRectangle, Color.Black, dashColor);
        }

        private void dragPanel_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
          
        }

        private void dragPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            dirTextBox1.Text = files[0];
            outputTextBox.Text = Path.GetDirectoryName(files[0]) + "\\"+ Path.GetFileNameWithoutExtension(files[0]) + "_ps.exe";
            Globals._Output = Path.GetDirectoryName(files[0]) + "\\" + Path.GetFileNameWithoutExtension(files[0]) + "_ps.exe";
            FileInfo f = new FileInfo(files[0]);
            filesizeChangeLbl.Text = $"{(f.Length / 1024)}kb";
            dashColor = ButtonBorderStyle.Dashed;
            dragPanel.Invalidate();
            Globals._Module = ModuleDefMD.Load(files[0]);

            extraListBox1.Enabled = true;
            extraListBox2.Enabled = true;
        }

        private void dragPanel_DragLeave(object sender, EventArgs e)
        {
            dashColor = ButtonBorderStyle.Dashed;
            dragPanel.Invalidate();
        }

        private void dragPanel_DragEnter(object sender, DragEventArgs e)
        {
            dashColor = ButtonBorderStyle.Solid;
            dragPanel.Invalidate();
        }

        private void extraListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = extraListBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                extraListBox1.Items.RemoveAt(index);
                Globals._ActivePlugins.Add(Globals._Plugins[index]);
                extraListBox2.AddItemTitle(Globals._Plugins[index].Name, Globals._Plugins[index].Description);
                Globals._Plugins.RemoveAt(index);
            }
        }

        private void extraListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = extraListBox2.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                
                extraListBox1.AddItemTitle(Globals._ActivePlugins[index].Name, Globals._ActivePlugins[index].Description);
                Globals._Plugins.Add(Globals._ActivePlugins[index]);
                extraListBox2.Items.RemoveAt(index);
                Globals._ActivePlugins.RemoveAt(index);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Globals._Plugins = PluginSystem.Framework.LoadPlugins();
                foreach (var item in PluginSystem.Framework.LoadPlugins())
                {
                    this.Invoke((MethodInvoker)(() => extraListBox1.AddItemTitle(item.Name, item.Description)));
                }
            });
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void UpdateList(string text, Color clr)
        {
            this.Invoke((MethodInvoker)(() => richTextBox1.AppendText(text, clr, true)));
        }

        private List<PluginSystem.PluginObject> p1 = new List<PluginSystem.PluginObject>();

        private async void protectBtn_Click(object sender, EventArgs e)
        {
            foreach (var mod in Globals._ActivePlugins)
            {
                mod.Protection.LogWriter = new pShieldPluginBase.Log();
                mod.Protection.LogWriter.WriterCallBack = UpdateList;
                Globals._Module=  mod.Protection.Manipulate(Globals._Module);
            }
            var opts = new ModuleWriterOptions(Globals._Module);
            opts.Logger = DummyLogger.NoThrowInstance;
            Globals._Module.Write(Globals._Output, opts);
            await Task.Delay(1000);
            richTextBox1.AppendText($"Successfully saved - ", Color.Green, true);
            richTextBox1.AppendText($"{Globals._Output}{Environment.NewLine}", Color.Black, false);

            if (memLoadCheckBox.Checked)
            {
                ModuleDefMD loadFile = ModuleDefMD.Load(Globals._Output);
                var tempLoader = InlineProtections.MemoryLoader.Create(loadFile);
                richTextBox1.AppendText($"Generating loader{Environment.NewLine}", Color.Purple, true);
                foreach (var mod in Globals._ActivePlugins)
                {
                    if (mod.Name == "ProcessShield" || mod.Name == "Integer Encryption") continue;

                    tempLoader = mod.Protection.Manipulate(tempLoader);
                }
                loadFile.Dispose();
                richTextBox1.AppendText($"Deleting old assembly{Environment.NewLine}", Color.Purple, true);
                File.Delete(Globals._Output);
                richTextBox1.AppendText($"[-]{Path.GetFileNameWithoutExtension(Globals._Output)}{Environment.NewLine}", Color.Black, true);
                Globals._Output = Globals._Output.Replace("_ps.exe", "_loader.exe");                
                tempLoader.Write(Globals._Output, opts);
                richTextBox1.AppendText($"Successfully saved - ", Color.Green, true);
                richTextBox1.AppendText($"{Globals._Output}{Environment.NewLine}", Color.Black, false);
            }

            if (nopCheckBox.Checked)
            {               
                richTextBox1.AppendText($"Erasing dos information{Environment.NewLine}", Color.Purple, true);
                InlineProtections.ErasePEHeader.Run();
                await Task.Delay(200);
                richTextBox1.AppendText($"Verifying...{Environment.NewLine}", Color.Black, true);
                if (InlineProtections.ErasePEHeader.Verify())
                {
                    await Task.Delay(200);
                    richTextBox1.AppendText($"Successfully nopped{Environment.NewLine}", Color.Green, true);
                }
                else
                {
                    await Task.Delay(200);
                    richTextBox1.AppendText($"Error nopping dos information{Environment.NewLine}", Color.Red, true);
                }
                
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
