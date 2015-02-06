namespace MacroSoundBoard
{
    partial class SoundBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundBoard));
            this.vac_folder_btn = new System.Windows.Forms.Button();
            this.vac_folder_tb = new System.Windows.Forms.TextBox();
            this.vac_cp_launch = new System.Windows.Forms.Button();
            this.vac_ar_launch = new System.Windows.Forms.Button();
            this.realmic = new System.Windows.Forms.Label();
            this.realmic_name = new System.Windows.Forms.ComboBox();
            this.virtualmic_name = new System.Windows.Forms.ComboBox();
            this.virtualmic = new System.Windows.Forms.Label();
            this.realspeakers_name = new System.Windows.Forms.ComboBox();
            this.realspeakers = new System.Windows.Forms.Label();
            this.virtualinput_name = new System.Windows.Forms.ComboBox();
            this.virtualinput = new System.Windows.Forms.Label();
            this.toggle_ar = new System.Windows.Forms.Button();
            this.ar_1 = new System.Windows.Forms.Label();
            this.ar_2 = new System.Windows.Forms.Label();
            this.ar_3 = new System.Windows.Forms.Label();
            this.vlc_folder_tb = new System.Windows.Forms.TextBox();
            this.vlc_folder_btn = new System.Windows.Forms.Button();
            this.vac_folder_l = new System.Windows.Forms.Label();
            this.vlc_folder_l = new System.Windows.Forms.Label();
            this.ar_group = new System.Windows.Forms.GroupBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem_exit = new System.Windows.Forms.MenuItem();
            this.menuItem_toggle = new System.Windows.Forms.MenuItem();
            this.ar_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // vac_folder_btn
            // 
            this.vac_folder_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vac_folder_btn.Location = new System.Drawing.Point(367, 12);
            this.vac_folder_btn.Name = "vac_folder_btn";
            this.vac_folder_btn.Size = new System.Drawing.Size(30, 20);
            this.vac_folder_btn.TabIndex = 0;
            this.vac_folder_btn.Text = "...";
            this.vac_folder_btn.UseVisualStyleBackColor = true;
            this.vac_folder_btn.Click += new System.EventHandler(this.vac_folder_btn_Click);
            // 
            // vac_folder_tb
            // 
            this.vac_folder_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vac_folder_tb.Location = new System.Drawing.Point(95, 12);
            this.vac_folder_tb.Name = "vac_folder_tb";
            this.vac_folder_tb.Size = new System.Drawing.Size(266, 20);
            this.vac_folder_tb.TabIndex = 1;
            this.vac_folder_tb.TextChanged += new System.EventHandler(this.vac_folder_tb_TextChanged);
            // 
            // vac_cp_launch
            // 
            this.vac_cp_launch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vac_cp_launch.Location = new System.Drawing.Point(12, 64);
            this.vac_cp_launch.Name = "vac_cp_launch";
            this.vac_cp_launch.Size = new System.Drawing.Size(385, 23);
            this.vac_cp_launch.TabIndex = 2;
            this.vac_cp_launch.Text = "VAC Control Panel";
            this.vac_cp_launch.UseVisualStyleBackColor = true;
            this.vac_cp_launch.Click += new System.EventHandler(this.vac_cp_launch_Click);
            // 
            // vac_ar_launch
            // 
            this.vac_ar_launch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vac_ar_launch.Location = new System.Drawing.Point(12, 93);
            this.vac_ar_launch.Name = "vac_ar_launch";
            this.vac_ar_launch.Size = new System.Drawing.Size(385, 23);
            this.vac_ar_launch.TabIndex = 3;
            this.vac_ar_launch.Text = "Audio Repeater";
            this.vac_ar_launch.UseVisualStyleBackColor = true;
            this.vac_ar_launch.Click += new System.EventHandler(this.vac_ar_launch_Click);
            // 
            // realmic
            // 
            this.realmic.AutoSize = true;
            this.realmic.Location = new System.Drawing.Point(40, 125);
            this.realmic.Name = "realmic";
            this.realmic.Size = new System.Drawing.Size(49, 13);
            this.realmic.TabIndex = 4;
            this.realmic.Text = "Real Mic";
            // 
            // realmic_name
            // 
            this.realmic_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.realmic_name.FormattingEnabled = true;
            this.realmic_name.Location = new System.Drawing.Point(95, 122);
            this.realmic_name.Name = "realmic_name";
            this.realmic_name.Size = new System.Drawing.Size(302, 21);
            this.realmic_name.TabIndex = 5;
            this.realmic_name.SelectedIndexChanged += new System.EventHandler(this.realmic_name_SelectedIndexChanged);
            // 
            // virtualmic_name
            // 
            this.virtualmic_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualmic_name.FormattingEnabled = true;
            this.virtualmic_name.Location = new System.Drawing.Point(95, 149);
            this.virtualmic_name.Name = "virtualmic_name";
            this.virtualmic_name.Size = new System.Drawing.Size(302, 21);
            this.virtualmic_name.TabIndex = 7;
            this.virtualmic_name.SelectedIndexChanged += new System.EventHandler(this.virtualmic_name_SelectedIndexChanged);
            // 
            // virtualmic
            // 
            this.virtualmic.AutoSize = true;
            this.virtualmic.Location = new System.Drawing.Point(33, 152);
            this.virtualmic.Name = "virtualmic";
            this.virtualmic.Size = new System.Drawing.Size(56, 13);
            this.virtualmic.TabIndex = 6;
            this.virtualmic.Text = "Virtual Mic";
            // 
            // realspeakers_name
            // 
            this.realspeakers_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.realspeakers_name.FormattingEnabled = true;
            this.realspeakers_name.Location = new System.Drawing.Point(95, 203);
            this.realspeakers_name.Name = "realspeakers_name";
            this.realspeakers_name.Size = new System.Drawing.Size(302, 21);
            this.realspeakers_name.TabIndex = 9;
            this.realspeakers_name.SelectedIndexChanged += new System.EventHandler(this.realspeakers_name_SelectedIndexChanged);
            // 
            // realspeakers
            // 
            this.realspeakers.AutoSize = true;
            this.realspeakers.Location = new System.Drawing.Point(16, 206);
            this.realspeakers.Name = "realspeakers";
            this.realspeakers.Size = new System.Drawing.Size(77, 13);
            this.realspeakers.TabIndex = 8;
            this.realspeakers.Text = "Real Speakers";
            // 
            // virtualinput_name
            // 
            this.virtualinput_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualinput_name.FormattingEnabled = true;
            this.virtualinput_name.Location = new System.Drawing.Point(95, 176);
            this.virtualinput_name.Name = "virtualinput_name";
            this.virtualinput_name.Size = new System.Drawing.Size(302, 21);
            this.virtualinput_name.TabIndex = 11;
            this.virtualinput_name.SelectedIndexChanged += new System.EventHandler(this.virtualinput_name_SelectedIndexChanged);
            // 
            // virtualinput
            // 
            this.virtualinput.AutoSize = true;
            this.virtualinput.Location = new System.Drawing.Point(26, 179);
            this.virtualinput.Name = "virtualinput";
            this.virtualinput.Size = new System.Drawing.Size(63, 13);
            this.virtualinput.TabIndex = 10;
            this.virtualinput.Text = "Virtual Input";
            // 
            // toggle_ar
            // 
            this.toggle_ar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggle_ar.Location = new System.Drawing.Point(221, 35);
            this.toggle_ar.Name = "toggle_ar";
            this.toggle_ar.Size = new System.Drawing.Size(75, 23);
            this.toggle_ar.TabIndex = 12;
            this.toggle_ar.Text = "Start";
            this.toggle_ar.UseVisualStyleBackColor = true;
            this.toggle_ar.Click += new System.EventHandler(this.toggle_ar_Click);
            // 
            // ar_1
            // 
            this.ar_1.AutoSize = true;
            this.ar_1.Location = new System.Drawing.Point(6, 16);
            this.ar_1.Name = "ar_1";
            this.ar_1.Size = new System.Drawing.Size(28, 13);
            this.ar_1.TabIndex = 13;
            this.ar_1.Text = "ar_1";
            // 
            // ar_2
            // 
            this.ar_2.AutoSize = true;
            this.ar_2.Location = new System.Drawing.Point(6, 29);
            this.ar_2.Name = "ar_2";
            this.ar_2.Size = new System.Drawing.Size(28, 13);
            this.ar_2.TabIndex = 14;
            this.ar_2.Text = "ar_2";
            // 
            // ar_3
            // 
            this.ar_3.AutoSize = true;
            this.ar_3.Location = new System.Drawing.Point(6, 42);
            this.ar_3.Name = "ar_3";
            this.ar_3.Size = new System.Drawing.Size(28, 13);
            this.ar_3.TabIndex = 15;
            this.ar_3.Text = "ar_3";
            // 
            // vlc_folder_tb
            // 
            this.vlc_folder_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlc_folder_tb.Location = new System.Drawing.Point(95, 38);
            this.vlc_folder_tb.Name = "vlc_folder_tb";
            this.vlc_folder_tb.Size = new System.Drawing.Size(266, 20);
            this.vlc_folder_tb.TabIndex = 16;
            this.vlc_folder_tb.TextChanged += new System.EventHandler(this.vlc_folder_tb_TextChanged);
            // 
            // vlc_folder_btn
            // 
            this.vlc_folder_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vlc_folder_btn.Location = new System.Drawing.Point(367, 37);
            this.vlc_folder_btn.Name = "vlc_folder_btn";
            this.vlc_folder_btn.Size = new System.Drawing.Size(30, 20);
            this.vlc_folder_btn.TabIndex = 17;
            this.vlc_folder_btn.Text = "...";
            this.vlc_folder_btn.UseVisualStyleBackColor = true;
            this.vlc_folder_btn.Click += new System.EventHandler(this.vlc_folder_btn_Click);
            // 
            // vac_folder_l
            // 
            this.vac_folder_l.AutoSize = true;
            this.vac_folder_l.Location = new System.Drawing.Point(16, 15);
            this.vac_folder_l.Name = "vac_folder_l";
            this.vac_folder_l.Size = new System.Drawing.Size(73, 13);
            this.vac_folder_l.TabIndex = 18;
            this.vac_folder_l.Text = "VAC Directory";
            // 
            // vlc_folder_l
            // 
            this.vlc_folder_l.AutoSize = true;
            this.vlc_folder_l.Location = new System.Drawing.Point(16, 41);
            this.vlc_folder_l.Name = "vlc_folder_l";
            this.vlc_folder_l.Size = new System.Drawing.Size(72, 13);
            this.vlc_folder_l.TabIndex = 19;
            this.vlc_folder_l.Text = "VLC Directory";
            // 
            // ar_group
            // 
            this.ar_group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ar_group.Controls.Add(this.ar_3);
            this.ar_group.Controls.Add(this.ar_2);
            this.ar_group.Controls.Add(this.ar_1);
            this.ar_group.Controls.Add(this.toggle_ar);
            this.ar_group.Location = new System.Drawing.Point(95, 230);
            this.ar_group.Name = "ar_group";
            this.ar_group.Size = new System.Drawing.Size(302, 64);
            this.ar_group.TabIndex = 20;
            this.ar_group.TabStop = false;
            this.ar_group.Text = "Audio Repeater Processes";
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenu = this.trayIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Macro Sound Board";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_exit,
            this.menuItem_toggle});
            // 
            // menuItem_exit
            // 
            this.menuItem_exit.Index = 0;
            this.menuItem_exit.Text = "Exit";
            this.menuItem_exit.Click += new System.EventHandler(this.menuItem_exit_Click);
            // 
            // menuItem_toggle
            // 
            this.menuItem_toggle.Index = 1;
            this.menuItem_toggle.Text = "Start";
            this.menuItem_toggle.Click += new System.EventHandler(this.toggle_ar_Click);
            // 
            // SoundBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 306);
            this.Controls.Add(this.ar_group);
            this.Controls.Add(this.vlc_folder_l);
            this.Controls.Add(this.vac_folder_l);
            this.Controls.Add(this.vlc_folder_btn);
            this.Controls.Add(this.vlc_folder_tb);
            this.Controls.Add(this.virtualinput_name);
            this.Controls.Add(this.virtualinput);
            this.Controls.Add(this.realspeakers_name);
            this.Controls.Add(this.realspeakers);
            this.Controls.Add(this.virtualmic_name);
            this.Controls.Add(this.virtualmic);
            this.Controls.Add(this.realmic_name);
            this.Controls.Add(this.realmic);
            this.Controls.Add(this.vac_ar_launch);
            this.Controls.Add(this.vac_cp_launch);
            this.Controls.Add(this.vac_folder_tb);
            this.Controls.Add(this.vac_folder_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 344);
            this.Name = "SoundBoard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Sound Board";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoundBoard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoundBoard_FormClosed);
            this.Load += new System.EventHandler(this.SoundBoard_Load);
            this.Resize += new System.EventHandler(this.SoundBoard_Resize);
            this.ar_group.ResumeLayout(false);
            this.ar_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vac_folder_btn;
        private System.Windows.Forms.TextBox vac_folder_tb;
        private System.Windows.Forms.Button vac_cp_launch;
        private System.Windows.Forms.Button vac_ar_launch;
        private System.Windows.Forms.Label realmic;
        private System.Windows.Forms.ComboBox realmic_name;
        private System.Windows.Forms.ComboBox virtualmic_name;
        private System.Windows.Forms.Label virtualmic;
        private System.Windows.Forms.ComboBox realspeakers_name;
        private System.Windows.Forms.Label realspeakers;
        private System.Windows.Forms.ComboBox virtualinput_name;
        private System.Windows.Forms.Label virtualinput;
        private System.Windows.Forms.Button toggle_ar;
        private System.Windows.Forms.Label ar_1;
        private System.Windows.Forms.Label ar_2;
        private System.Windows.Forms.Label ar_3;
        private System.Windows.Forms.TextBox vlc_folder_tb;
        private System.Windows.Forms.Button vlc_folder_btn;
        private System.Windows.Forms.Label vac_folder_l;
        private System.Windows.Forms.Label vlc_folder_l;
        private System.Windows.Forms.GroupBox ar_group;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenu trayIconMenu;
        private System.Windows.Forms.MenuItem menuItem_exit;
        private System.Windows.Forms.MenuItem menuItem_toggle;
    }
}

