namespace OS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.create_panel = new System.Windows.Forms.Panel();
            this.dispBtn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.listDisk = new MetroFramework.Controls.MetroComboBox();
            this.details = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.progressbar = new CircularProgressBar.CircularProgressBar();
            this.content = new System.Windows.Forms.Panel();
            this.formatBtn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.renameBtn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.create_panel.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Disk Utility";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::OS.Properties.Resources.if_6___Cross_1815573;
            this.pictureBox1.Location = new System.Drawing.Point(679, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.close_Click);
            // 
            // create_panel
            // 
            this.create_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.create_panel.Controls.Add(this.renameBtn);
            this.create_panel.Controls.Add(this.formatBtn);
            this.create_panel.Controls.Add(this.dispBtn);
            this.create_panel.Controls.Add(this.listDisk);
            this.create_panel.Controls.Add(this.details);
            this.create_panel.Controls.Add(this.name);
            this.create_panel.Controls.Add(this.progressbar);
            this.create_panel.Location = new System.Drawing.Point(0, 0);
            this.create_panel.Name = "create_panel";
            this.create_panel.Size = new System.Drawing.Size(746, 338);
            this.create_panel.TabIndex = 3;
            this.create_panel.Tag = "2";
            this.create_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.create_panel_Paint);
            // 
            // dispBtn
            // 
            this.dispBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dispBtn.Image = null;
            this.dispBtn.Location = new System.Drawing.Point(562, 9);
            this.dispBtn.Name = "dispBtn";
            this.dispBtn.Size = new System.Drawing.Size(136, 35);
            this.dispBtn.TabIndex = 4;
            this.dispBtn.Text = "Show Info";
            this.dispBtn.UseSelectable = true;
            this.dispBtn.UseVisualStyleBackColor = true;
            this.dispBtn.Click += new System.EventHandler(this.dispBtn_Click);
            // 
            // listDisk
            // 
            this.listDisk.FormattingEnabled = true;
            this.listDisk.ItemHeight = 23;
            this.listDisk.Location = new System.Drawing.Point(12, 9);
            this.listDisk.Name = "listDisk";
            this.listDisk.Size = new System.Drawing.Size(523, 29);
            this.listDisk.TabIndex = 3;
            this.listDisk.UseSelectable = true;
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.Color.Gold;
            this.details.Location = new System.Drawing.Point(36, 214);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(51, 17);
            this.details.TabIndex = 2;
            this.details.Text = "Details";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.name.Location = new System.Drawing.Point(35, 193);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(66, 22);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // progressbar
            // 
            this.progressbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressbar.AnimationSpeed = 500;
            this.progressbar.BackColor = System.Drawing.Color.Transparent;
            this.progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressbar.InnerMargin = 2;
            this.progressbar.InnerWidth = -1;
            this.progressbar.Location = new System.Drawing.Point(12, 44);
            this.progressbar.MarqueeAnimationSpeed = 2000;
            this.progressbar.Name = "progressbar";
            this.progressbar.OuterColor = System.Drawing.Color.Navy;
            this.progressbar.OuterMargin = -25;
            this.progressbar.OuterWidth = 20;
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progressbar.ProgressWidth = 15;
            this.progressbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressbar.Size = new System.Drawing.Size(133, 130);
            this.progressbar.StartAngle = 270;
            this.progressbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressbar.SubscriptText = "";
            this.progressbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressbar.SuperscriptText = "";
            this.progressbar.TabIndex = 1;
            this.progressbar.Text = "0%";
            this.progressbar.TextMargin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.progressbar.Value = 68;
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.content.Controls.Add(this.create_panel);
            this.content.Location = new System.Drawing.Point(0, 43);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(746, 338);
            this.content.TabIndex = 2;
            this.content.Tag = "1";
            // 
            // formatBtn
            // 
            this.formatBtn.Image = null;
            this.formatBtn.Location = new System.Drawing.Point(562, 99);
            this.formatBtn.Name = "formatBtn";
            this.formatBtn.Size = new System.Drawing.Size(136, 35);
            this.formatBtn.TabIndex = 5;
            this.formatBtn.Text = "Format Drive";
            this.formatBtn.UseSelectable = true;
            this.formatBtn.UseVisualStyleBackColor = true;
            this.formatBtn.Click += new System.EventHandler(this.formatBtn_Click);
            // 
            // renameBtn
            // 
            this.renameBtn.Image = null;
            this.renameBtn.Location = new System.Drawing.Point(562, 140);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(136, 34);
            this.renameBtn.TabIndex = 6;
            this.renameBtn.Text = "Rename Drive";
            this.renameBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.renameBtn.UseSelectable = true;
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(746, 381);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.create_panel.ResumeLayout(false);
            this.create_panel.PerformLayout();
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel content;
        private CircularProgressBar.CircularProgressBar progressbar;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Panel create_panel;
        private MetroFramework.Controls.MetroComboBox listDisk;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton dispBtn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton formatBtn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton renameBtn;
    }
}

