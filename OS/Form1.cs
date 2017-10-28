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

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(about, "Visit Developer Site");
            toolTip.SetToolTip(closeBtn, "Exit");
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
            // For null selection handling  && initial values
            listDisk.SelectedIndex = 0;

            string initItem = drives[0].ToString();
            name.Text = getLabel(initItem);
            nameText.Text = getLabel(initItem);
            details.Text = showInfo(initItem);

            double percentage = (getAvailableSpace(initItem) / getTotalSpace(initItem));
            percentage = percentage * 100;
            int val = Convert.ToInt32(percentage);
            progressbar.Value = val;
            progressbar.Text = val + " %";
            progressbar.Update();


        }

        // Drive Processing

        private string showInfo(string item)
        {

            string available_space = "", total_space = "", type = "", file_system = "", label = "",root="";
            string selected_drive = item;
            int percentage = 0;
            try
            {
                DriveInfo info = new DriveInfo(selected_drive);
                available_space = info.AvailableFreeSpace.ToString();
                total_space = info.TotalSize.ToString();
                type = info.DriveType.ToString();
                file_system = info.DriveFormat.ToString();
                label = info.VolumeLabel.ToString();

                root = info.RootDirectory.ToString();
                percentage = int.Parse(available_space) / int.Parse(total_space) * 100;

            }
            catch (Exception ex)
            {

            }
            return "Free space: " + available_space + " Bytes\nTotal Sapace: " + total_space + " Bytes\nDrive type: " + type + "\nFile System: " + file_system+"\nRoot Directory: "+ root;
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
            nameText.Text = getLabel(item);
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
            if (d.IsReady)
            {
                try
                {
                    d.VolumeLabel = newLabel;
                    return true;
                }
                catch (Exception ex)
                {
                   // Console.Write(ex.Message);
                    return false;
                }
               
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
            string label = nameText.Text;
            if(label==null)
            {
                label = "";
            }

            bool res = SetVolumeLabel(d, label);
            if(res)
            {
                MessageBox.Show("Drive Rename Successfull!");
            }
            else
            {
                MessageBox.Show("Volume labels can only be set for writable local volumes.");

            }

        }

        private void about_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fsix.me");
        }
    }


}
