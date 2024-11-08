
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
            this.EasyToStopWorker = new System.ComponentModel.BackgroundWorker();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.TabControl = new Sunny.UI.UITabControl();
            this.Utility = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.enableOfflineMode = new MetroSet_UI.Controls.MetroSetSwitch();
            this.searchButton = new System.Windows.Forms.Button();
            this.BlockSearchBar = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Information = new System.Windows.Forms.TabPage();
            this.procIDDisplay = new MetroSet_UI.Controls.MetroSetLabel();
            this.status_label = new MetroSet_UI.Controls.MetroSetLabel();
            this.getStatusDisplay = new MetroSet_UI.Controls.MetroSetLabel();
            this.process_label = new MetroSet_UI.Controls.MetroSetLabel();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.Hispano = new MetroSet_UI.Controls.MetroSetLabel();
            this.TabControl.SuspendLayout();
            this.Utility.SuspendLayout();
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(403, 11);
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
            // EasyToStopWorker
            // 
            this.EasyToStopWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EasyToStopWorker_DoWork);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListIcons.TransparentColor = System.Drawing.Color.Empty;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Utility);
            this.TabControl.Controls.Add(this.Information);
            this.TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabControl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(120, 30);
            this.TabControl.Location = new System.Drawing.Point(15, 93);
            this.TabControl.MainPage = "";
            this.TabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.TabControl.Name = "TabControl";
            this.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(488, 285);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabControl.TabIndex = 14;
            this.TabControl.TabSelectedColor = System.Drawing.Color.Lime;
            this.TabControl.TabSelectedForeColor = System.Drawing.Color.White;
            this.TabControl.TabSelectedHighColor = System.Drawing.Color.LimeGreen;
            this.TabControl.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // Utility
            // 
            this.Utility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Utility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Utility.Controls.Add(this.label3);
            this.Utility.Controls.Add(this.enableOfflineMode);
            this.Utility.Controls.Add(this.listViewResults);
            this.Utility.Controls.Add(this.searchButton);
            this.Utility.Controls.Add(this.BlockSearchBar);
            this.Utility.Location = new System.Drawing.Point(0, 30);
            this.Utility.Name = "Utility";
            this.Utility.Size = new System.Drawing.Size(488, 255);
            this.Utility.TabIndex = 0;
            this.Utility.Text = "Utility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(393, 19);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Offline-Mode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.enableOfflineMode.Location = new System.Drawing.Point(329, 16);
            this.enableOfflineMode.Name = "enableOfflineMode";
            this.enableOfflineMode.Size = new System.Drawing.Size(58, 22);
            this.enableOfflineMode.Style = MetroSet_UI.Enums.Style.Custom;
            this.enableOfflineMode.StyleManager = null;
            this.enableOfflineMode.Switched = false;
            this.enableOfflineMode.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.enableOfflineMode.TabIndex = 22;
            this.enableOfflineMode.ThemeAuthor = "Narwin";
            this.enableOfflineMode.ThemeName = "MetroLite";
            this.enableOfflineMode.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Lime;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(198, 14);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 27);
            this.searchButton.TabIndex = 20;
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
            this.BlockSearchBar.Location = new System.Drawing.Point(15, 14);
            this.BlockSearchBar.MaxLength = 32767;
            this.BlockSearchBar.Multiline = false;
            this.BlockSearchBar.Name = "BlockSearchBar";
            this.BlockSearchBar.ReadOnly = false;
            this.BlockSearchBar.Size = new System.Drawing.Size(180, 27);
            this.BlockSearchBar.Style = MetroSet_UI.Enums.Style.Custom;
            this.BlockSearchBar.StyleManager = null;
            this.BlockSearchBar.TabIndex = 19;
            this.BlockSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlockSearchBar.ThemeAuthor = "A";
            this.BlockSearchBar.ThemeName = "A";
            this.BlockSearchBar.UseSystemPasswordChar = false;
            this.BlockSearchBar.WatermarkText = "Write here a Block Name";
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Information.Controls.Add(this.Hispano);
            this.Information.Controls.Add(this.procIDDisplay);
            this.Information.Controls.Add(this.status_label);
            this.Information.Controls.Add(this.getStatusDisplay);
            this.Information.Controls.Add(this.process_label);
            this.Information.Location = new System.Drawing.Point(0, 30);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(488, 255);
            this.Information.TabIndex = 1;
            this.Information.Text = "Information";
            // 
            // procIDDisplay
            // 
            this.procIDDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.procIDDisplay.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procIDDisplay.IsDerivedStyle = true;
            this.procIDDisplay.Location = new System.Drawing.Point(105, 15);
            this.procIDDisplay.Name = "procIDDisplay";
            this.procIDDisplay.Size = new System.Drawing.Size(125, 23);
            this.procIDDisplay.Style = MetroSet_UI.Enums.Style.Custom;
            this.procIDDisplay.StyleManager = null;
            this.procIDDisplay.TabIndex = 3;
            this.procIDDisplay.Text = "DISCONNECTED";
            this.procIDDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.procIDDisplay.ThemeAuthor = "Hispano";
            this.procIDDisplay.ThemeName = "ETS-Lime";
            // 
            // status_label
            // 
            this.status_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.IsDerivedStyle = true;
            this.status_label.Location = new System.Drawing.Point(15, 38);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(84, 23);
            this.status_label.Style = MetroSet_UI.Enums.Style.Custom;
            this.status_label.StyleManager = null;
            this.status_label.TabIndex = 2;
            this.status_label.Text = "STATUS:";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status_label.ThemeAuthor = "Hispano";
            this.status_label.ThemeName = "ETS-Lime";
            // 
            // getStatusDisplay
            // 
            this.getStatusDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getStatusDisplay.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStatusDisplay.IsDerivedStyle = true;
            this.getStatusDisplay.Location = new System.Drawing.Point(105, 38);
            this.getStatusDisplay.Name = "getStatusDisplay";
            this.getStatusDisplay.Size = new System.Drawing.Size(125, 23);
            this.getStatusDisplay.Style = MetroSet_UI.Enums.Style.Custom;
            this.getStatusDisplay.StyleManager = null;
            this.getStatusDisplay.TabIndex = 1;
            this.getStatusDisplay.Text = "DISCONNECTED";
            this.getStatusDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getStatusDisplay.ThemeAuthor = "Hispano";
            this.getStatusDisplay.ThemeName = "ETS-Lime";
            // 
            // process_label
            // 
            this.process_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.process_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_label.IsDerivedStyle = true;
            this.process_label.Location = new System.Drawing.Point(15, 15);
            this.process_label.Name = "process_label";
            this.process_label.Size = new System.Drawing.Size(84, 23);
            this.process_label.Style = MetroSet_UI.Enums.Style.Custom;
            this.process_label.StyleManager = null;
            this.process_label.TabIndex = 0;
            this.process_label.Text = "PROCESS:";
            this.process_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.process_label.ThemeAuthor = "Hispano";
            this.process_label.ThemeName = "ETS-Lime";
            // 
            // listViewResults
            // 
            this.listViewResults.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listViewResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewResults.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(15, 47);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Scrollable = false;
            this.listViewResults.Size = new System.Drawing.Size(459, 190);
            this.listViewResults.TabIndex = 21;
            this.listViewResults.TileSize = new System.Drawing.Size(1, 1);
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.List;
            this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listViewResults_SelectedIndexChanged);
            // 
            // Hispano
            // 
            this.Hispano.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hispano.IsDerivedStyle = true;
            this.Hispano.Location = new System.Drawing.Point(95, 230);
            this.Hispano.Name = "Hispano";
            this.Hispano.Size = new System.Drawing.Size(293, 23);
            this.Hispano.Style = MetroSet_UI.Enums.Style.Light;
            this.Hispano.StyleManager = null;
            this.Hispano.TabIndex = 4;
            this.Hispano.Text = "Helium has been scripted and compiled by Hispano";
            this.Hispano.ThemeAuthor = "Narwin";
            this.Hispano.ThemeName = "MetroLite";
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageTransparency = 0.1F;
            this.BorderColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(518, 393);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.metroSetControlBox1);
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
            this.TabControl.ResumeLayout(false);
            this.Utility.ResumeLayout(false);
            this.Utility.PerformLayout();
            this.Information.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.ComponentModel.BackgroundWorker EasyToStopWorker;
        private System.Windows.Forms.ImageList imageListIcons;
        private Sunny.UI.UITabControl TabControl;
        private System.Windows.Forms.TabPage Utility;
        private System.Windows.Forms.Label label3;
        private MetroSet_UI.Controls.MetroSetSwitch enableOfflineMode;
        private System.Windows.Forms.Button searchButton;
        private MetroSet_UI.Controls.MetroSetTextBox BlockSearchBar;
        private System.Windows.Forms.TabPage Information;
        private MetroSet_UI.Controls.MetroSetLabel procIDDisplay;
        private MetroSet_UI.Controls.MetroSetLabel status_label;
        private MetroSet_UI.Controls.MetroSetLabel getStatusDisplay;
        private MetroSet_UI.Controls.MetroSetLabel process_label;
        private System.Windows.Forms.ListView listViewResults;
        private MetroSet_UI.Controls.MetroSetLabel Hispano;
    }
}

