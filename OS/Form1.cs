using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using OS;

namespace OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getDrives();
        }
        // Drive information acquisition
        private void getDrives()
        {
            string info_sum = "";
            string[] drives = Directory.GetLogicalDrives();
            foreach (string item in drives)
            {

                info_sum += getLabel(item);
                if(getTotalSpace(item)>0)
                {
                    listDisk.Items.Add(item);
                }
                

            }
            // For null selection handling 
            listDisk.SelectedIndex = 0;
            

        }

        // Drive Processing

        private string showInfo(string item)
        {

            string available_space = "", total_space = "", type = "", file_system = "", label = "";
            string selected_drive = item;
            int percentage = 0;
            try
            {
                DriveInfo info = new DriveInfo(selected_drive);
                available_space = info.AvailableFreeSpace.ToString();
                total_space = info.TotalFreeSpace.ToString();
                type = info.DriveType.ToString();
                file_system = info.DriveFormat.ToString();
                label = info.VolumeLabel.ToString();

                percentage = int.Parse(available_space) / int.Parse(total_space) * 100;
            
            }
            catch (Exception ex)
            {

            }
            return "Free space: " + available_space + "\nTotal Sapace: " + total_space + "\nDrive type: " + type + "\nFile System: " + file_system;
        }

        private string getLabel(string drive)
        {
            string result = "";
            DriveInfo info = new DriveInfo(drive);
            try
            {
                result = info.VolumeLabel.ToString();
            }
            catch(Exception ex)
            {

            }
            return result;
        }
        private string getFileSystem(string drive)
        {
            string result = "";
            DriveInfo info = new DriveInfo(drive);
            try
            {
                result = info.DriveFormat.ToString();
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        private double getTotalSpace(string drive)
        {
            double result = 0;
            DriveInfo info = new DriveInfo(drive);
            try
            {
                result = double.Parse(info.TotalSize.ToString());
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        private double getAvailableSpace(string drive)
        {
            double result = 0;
            DriveInfo info = new DriveInfo(drive);
            try
            {
                result = double.Parse(info.AvailableFreeSpace.ToString());
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        private string getType(string drive)
        {
            string result = "";
            DriveInfo info = new DriveInfo(drive);
            try
            {
                result = info.DriveType.ToString();
            }
            catch (Exception ex)
            {

            }
            return result;
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Drag controll
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        // Drag control end


        private void create_panel_Paint(object sender, PaintEventArgs e)
        {
            /// VVI
            /// don't delete.. used for design
        }

        // Display Drive
        private void dispBtn_Click(object sender, EventArgs e)
        {
            string item = listDisk.SelectedItem.ToString();
            name.Text = getLabel(item);
            details.Text = showInfo(item);

            double percentage = (getAvailableSpace(item) / getTotalSpace(item));
            percentage = percentage * 100;
            int val = Convert.ToInt32(percentage);
            progressbar.Value = val;
            progressbar.Text = val + " %";
            progressbar.Update();
        }

        // Format drive
        private void formatBtn_Click(object sender, EventArgs e)
        {
            string item = listDisk.SelectedItem.ToString();
            char driveLetter = item[0];
            DriveInfo d = new DriveInfo(item);
            //Console.Write(driveLetter);

            DialogResult dr = MessageBox.Show("Are you sure to format this Drive?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (d.IsReady && d.DriveType == DriveType.Removable)
                {
                    bool res = DriveManager.FormatDrive(driveLetter, getLabel(item));
                    if (res)
                    {
                        MessageBox.Show("Format completed!", "Operation Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Can't Format Drive!", "Operation Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Drive formatting blocked. Select a removable drive!");
                }
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }

           
        }
        // Rename drive
        public bool SetVolumeLabel(DriveInfo d,string newLabel)
        {
            if (d.IsReady && d.DriveType == DriveType.Removable)
            {
                d.VolumeLabel = newLabel;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            string item = listDisk.SelectedItem.ToString();
            DriveInfo d = new DriveInfo(item);

            ShowDialog("Enter label","Change label");
            bool res = SetVolumeLabel(d, "Noor");
            if(res)
            {
                MessageBox.Show("Drive Rename Successfull!");
            }
            else
            {
                MessageBox.Show("Drive Rename blocked. Select a removable drive!");

            }

        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

    }

}
