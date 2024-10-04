
namespace ETS
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.MainHacks = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enableOfflineMode = new MetroSet_UI.Controls.MetroSetSwitch();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.searchButton = new System.Windows.Forms.Button();
            this.BlockSearchBar = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Information = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getHackStatus = new System.Windows.Forms.Label();
            this.hackstatus = new System.Windows.Forms.Label();
            this.ProcessID = new System.Windows.Forms.Label();
            this.procIDLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.metroSetTabControl1.SuspendLayout();
            this.MainHacks.SuspendLayout();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(472, 11);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.SineInOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.MainHacks);
            this.metroSetTabControl1.Controls.Add(this.Information);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(15, 76);
            this.metroSetTabControl1.MaximumSize = new System.Drawing.Size(557, 302);
            this.metroSetTabControl1.MinimumSize = new System.Drawing.Size(557, 302);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 1;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.Lime;
            this.metroSetTabControl1.Size = new System.Drawing.Size(557, 302);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 50;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 3;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = "Hispano";
            this.metroSetTabControl1.ThemeName = "Hispano";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Lime;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // MainHacks
            // 
            this.MainHacks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainHacks.Controls.Add(this.label4);
            this.MainHacks.Controls.Add(this.label3);
            this.MainHacks.Controls.Add(this.enableOfflineMode);
            this.MainHacks.Controls.Add(this.listViewResults);
            this.MainHacks.Controls.Add(this.searchButton);
            this.MainHacks.Controls.Add(this.BlockSearchBar);
            this.MainHacks.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainHacks.ImageIndex = 0;
            this.MainHacks.ImageKey = null;
            this.MainHacks.IsDerivedStyle = true;
            this.MainHacks.Location = new System.Drawing.Point(4, 42);
            this.MainHacks.Name = "MainHacks";
            this.MainHacks.Size = new System.Drawing.Size(549, 256);
            this.MainHacks.Style = MetroSet_UI.Enums.Style.Custom;
            this.MainHacks.StyleManager = null;
            this.MainHacks.TabIndex = 0;
            this.MainHacks.Text = "Utility";
            this.MainHacks.ThemeAuthor = "Narwin";
            this.MainHacks.ThemeName = "MetroLite";
            this.MainHacks.ToolTipText = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mod Menu scripted and compiled by Hispano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(413, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enable Offline-Mode";
            // 
            // enableOfflineMode
            // 
            this.enableOfflineMode.BackColor = System.Drawing.Color.Transparent;
            this.enableOfflineMode.BackgroundColor = System.Drawing.Color.Empty;
            this.enableOfflineMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.enableOfflineMode.CheckColor = System.Drawing.Color.Lime;
            this.enableOfflineMode.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.enableOfflineMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enableOfflineMode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.enableOfflineMode.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.enableOfflineMode.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.enableOfflineMode.IsDerivedStyle = true;
            this.enableOfflineMode.Location = new System.Drawing.Point(349, 3);
            this.enableOfflineMode.Name = "enableOfflineMode";
            this.enableOfflineMode.Size = new System.Drawing.Size(58, 22);
            this.enableOfflineMode.Style = MetroSet_UI.Enums.Style.Custom;
            this.enableOfflineMode.StyleManager = null;
            this.enableOfflineMode.Switched = false;
            this.enableOfflineMode.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.enableOfflineMode.TabIndex = 3;
            this.enableOfflineMode.ThemeAuthor = "Narwin";
            this.enableOfflineMode.ThemeName = "MetroLite";
            this.enableOfflineMode.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // listViewResults
            // 
            this.listViewResults.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listViewResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewResults.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(12, 33);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(523, 207);
            this.listViewResults.TabIndex = 2;
            this.listViewResults.TileSize = new System.Drawing.Size(1, 1);
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.List;
            this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listViewResults_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Lime;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.ForeColor = System.Drawing.Color.Lime;
            this.searchButton.Location = new System.Drawing.Point(248, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 27);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseMnemonic = false;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchButton_MouseClick);
            // 
            // BlockSearchBar
            // 
            this.BlockSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BlockSearchBar.AutoCompleteCustomSource = null;
            this.BlockSearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BlockSearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BlockSearchBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BlockSearchBar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BlockSearchBar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BlockSearchBar.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BlockSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BlockSearchBar.HoverColor = System.Drawing.Color.Lime;
            this.BlockSearchBar.Image = null;
            this.BlockSearchBar.IsDerivedStyle = true;
            this.BlockSearchBar.Lines = null;
            this.BlockSearchBar.Location = new System.Drawing.Point(12, 0);
            this.BlockSearchBar.MaxLength = 32767;
            this.BlockSearchBar.Multiline = false;
            this.BlockSearchBar.Name = "BlockSearchBar";
            this.BlockSearchBar.ReadOnly = false;
            this.BlockSearchBar.Size = new System.Drawing.Size(233, 27);
            this.BlockSearchBar.Style = MetroSet_UI.Enums.Style.Custom;
            this.BlockSearchBar.StyleManager = null;
            this.BlockSearchBar.TabIndex = 0;
            this.BlockSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlockSearchBar.ThemeAuthor = "A";
            this.BlockSearchBar.ThemeName = "A";
            this.BlockSearchBar.UseSystemPasswordChar = false;
            this.BlockSearchBar.WatermarkText = "Write here a Block Name";
            // 
            // Information
            // 
            this.Information.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.label1);
            this.Information.Controls.Add(this.getHackStatus);
            this.Information.Controls.Add(this.hackstatus);
            this.Information.Controls.Add(this.ProcessID);
            this.Information.Controls.Add(this.procIDLabel);
            this.Information.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.ImageIndex = 0;
            this.Information.ImageKey = null;
            this.Information.IsDerivedStyle = true;
            this.Information.Location = new System.Drawing.Point(4, 42);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(549, 256);
            this.Information.Style = MetroSet_UI.Enums.Style.Custom;
            this.Information.StyleManager = null;
            this.Information.TabIndex = 2;
            this.Information.Text = "Information";
            this.Information.ThemeAuthor = "Narwin";
            this.Information.ThemeName = "MetroLite";
            this.Information.ToolTipText = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mod Menu scripted and compiled by Hispano";
            // 
            // getHackStatus
            // 
            this.getHackStatus.AutoSize = true;
            this.getHackStatus.BackColor = System.Drawing.Color.Transparent;
            this.getHackStatus.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getHackStatus.ForeColor = System.Drawing.Color.Red;
            this.getHackStatus.Location = new System.Drawing.Point(84, 40);
            this.getHackStatus.Name = "getHackStatus";
            this.getHackStatus.Size = new System.Drawing.Size(93, 18);
            this.getHackStatus.TabIndex = 5;
            this.getHackStatus.Text = "DISCONNECTED";
            // 
            // hackstatus
            // 
            this.hackstatus.AutoSize = true;
            this.hackstatus.BackColor = System.Drawing.Color.Transparent;
            this.hackstatus.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hackstatus.Location = new System.Drawing.Point(7, 40);
            this.hackstatus.Name = "hackstatus";
            this.hackstatus.Size = new System.Drawing.Size(50, 18);
            this.hackstatus.TabIndex = 4;
            this.hackstatus.Text = "STATUS:";
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSize = true;
            this.ProcessID.BackColor = System.Drawing.Color.Transparent;
            this.ProcessID.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessID.Location = new System.Drawing.Point(7, 18);
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Size = new System.Drawing.Size(76, 18);
            this.ProcessID.TabIndex = 3;
            this.ProcessID.Text = "PROCESS ID:";
            // 
            // procIDLabel
            // 
            this.procIDLabel.AutoSize = true;
            this.procIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.procIDLabel.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procIDLabel.ForeColor = System.Drawing.Color.Red;
            this.procIDLabel.Location = new System.Drawing.Point(84, 19);
            this.procIDLabel.Name = "procIDLabel";
            this.procIDLabel.Size = new System.Drawing.Size(93, 18);
            this.procIDLabel.TabIndex = 2;
            this.procIDLabel.Text = "DISCONNECTED";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListIcons.TransparentColor = System.Drawing.Color.Empty;
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageTransparency = 0.1F;
            this.BorderColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(587, 393);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Font = new System.Drawing.Font("Impact", 13.2F);
            this.HeaderColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 353);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowTitle = false;
            this.SmallLineColor1 = System.Drawing.Color.Lime;
            this.SmallLineColor2 = System.Drawing.Color.Lime;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Custom;
            this.Text = "Easy To Stop";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeAuthor = "Hispano";
            this.ThemeName = "Lime";
            this.UseSlideAnimation = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroSetTabControl1.ResumeLayout(false);
            this.MainHacks.ResumeLayout(false);
            this.MainHacks.PerformLayout();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage MainHacks;
        private MetroSet_UI.Child.MetroSetSetTabPage Information;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label procIDLabel;
        private System.Windows.Forms.Label getHackStatus;
        private System.Windows.Forms.Label hackstatus;
        private System.Windows.Forms.Label ProcessID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MetroSet_UI.Controls.MetroSetTextBox BlockSearchBar;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Label label3;
        private MetroSet_UI.Controls.MetroSetSwitch enableOfflineMode;
        private System.Windows.Forms.Label label4;
    }
}

