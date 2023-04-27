namespace Schedule_Lookup_UI
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePagePanel = new System.Windows.Forms.Panel();
            this.singleClassroomSearchPanel = new System.Windows.Forms.Panel();
            this.singleSearchTimePicker = new System.Windows.Forms.DateTimePicker();
            this.singleSearchDatePicker = new System.Windows.Forms.DateTimePicker();
            this.noClassScheduledOnDateTimeNotificationLabel = new System.Windows.Forms.Label();
            this.singleClassroomSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.singleSearchBackButton = new System.Windows.Forms.Button();
            this.singleSearchDisplayAcceptableRooms = new System.Windows.Forms.Button();
            this.roomDisplayTitleLabel = new System.Windows.Forms.Label();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.singleClassroomSearchSearchButton = new System.Windows.Forms.Button();
            this.roomPromptTextBox = new System.Windows.Forms.TextBox();
            this.roomPromptLabel = new System.Windows.Forms.Label();
            this.singleClassroomSearchTitleLabel = new System.Windows.Forms.Label();
            this.title_Label = new System.Windows.Forms.Label();
            this.buildingsDashboardGroupBox = new System.Windows.Forms.GroupBox();
            this.acadCountLabel = new System.Windows.Forms.Label();
            this.brecCountLabel = new System.Windows.Forms.Label();
            this.cuchCountLabel = new System.Windows.Forms.Label();
            this.uhalCountLabel = new System.Windows.Forms.Label();
            this.laneCountLabel = new System.Windows.Forms.Label();
            this.ocseCountLabel = new System.Windows.Forms.Label();
            this.engrCountLabel = new System.Windows.Forms.Label();
            this.dwirCountLabel = new System.Windows.Forms.Label();
            this.centCountLabel = new System.Windows.Forms.Label();
            this.coluCountLabel = new System.Windows.Forms.Label();
            this.acadBlgLabel = new System.Windows.Forms.Label();
            this.brecBlgLabel = new System.Windows.Forms.Label();
            this.cuchBlgLabel = new System.Windows.Forms.Label();
            this.uhalBlgLabel = new System.Windows.Forms.Label();
            this.laneBlgLabel = new System.Windows.Forms.Label();
            this.ocseBlgLabel = new System.Windows.Forms.Label();
            this.engrBlgLabel = new System.Windows.Forms.Label();
            this.dwirBlgLabel = new System.Windows.Forms.Label();
            this.centBlgLabel = new System.Windows.Forms.Label();
            this.coluBlgLabel = new System.Windows.Forms.Label();
            this.uccsLogoBox = new System.Windows.Forms.PictureBox();
            this.globalSearchBtn = new System.Windows.Forms.Button();
            this.singleClassroomSearchBtn = new System.Windows.Forms.Button();
            this.globalSearchPanel = new System.Windows.Forms.Panel();
            this.globalSearchBackBtn = new System.Windows.Forms.Button();
            this.globalSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.globalSearchSearchBtn = new System.Windows.Forms.Button();
            this.selectDateTimeLabel = new System.Windows.Forms.Label();
            this.globalSearchTimePicker = new System.Windows.Forms.DateTimePicker();
            this.globalSearchDatePicker = new System.Windows.Forms.DateTimePicker();
            this.globalSearchTitleLabel = new System.Windows.Forms.Label();
            this.classScheduledOnDateTimeNotificationLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.homePagePanel.SuspendLayout();
            this.singleClassroomSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleClassroomSearchDataGridView)).BeginInit();
            this.buildingsDashboardGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccsLogoBox)).BeginInit();
            this.globalSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalSearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.reportABugToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.reportABugToolStripMenuItem.Text = "Report a bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // homePagePanel
            // 
            this.homePagePanel.Controls.Add(this.singleClassroomSearchPanel);
            this.homePagePanel.Controls.Add(this.title_Label);
            this.homePagePanel.Controls.Add(this.buildingsDashboardGroupBox);
            this.homePagePanel.Controls.Add(this.uccsLogoBox);
            this.homePagePanel.Controls.Add(this.globalSearchBtn);
            this.homePagePanel.Controls.Add(this.singleClassroomSearchBtn);
            this.homePagePanel.Controls.Add(this.globalSearchPanel);
            this.homePagePanel.Location = new System.Drawing.Point(0, 25);
            this.homePagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePagePanel.Name = "homePagePanel";
            this.homePagePanel.Size = new System.Drawing.Size(789, 469);
            this.homePagePanel.TabIndex = 1;
            // 
            // singleClassroomSearchPanel
            // 
            this.singleClassroomSearchPanel.Controls.Add(this.classScheduledOnDateTimeNotificationLabel);
            this.singleClassroomSearchPanel.Controls.Add(this.singleSearchTimePicker);
            this.singleClassroomSearchPanel.Controls.Add(this.singleSearchDatePicker);
            this.singleClassroomSearchPanel.Controls.Add(this.noClassScheduledOnDateTimeNotificationLabel);
            this.singleClassroomSearchPanel.Controls.Add(this.singleClassroomSearchDataGridView);
            this.singleClassroomSearchPanel.Controls.Add(this.singleSearchBackButton);
            this.singleClassroomSearchPanel.Controls.Add(this.singleSearchDisplayAcceptableRooms);
            this.singleClassroomSearchPanel.Controls.Add(this.roomDisplayTitleLabel);
            this.singleClassroomSearchPanel.Controls.Add(this.notificationLabel);
            this.singleClassroomSearchPanel.Controls.Add(this.singleClassroomSearchSearchButton);
            this.singleClassroomSearchPanel.Controls.Add(this.roomPromptTextBox);
            this.singleClassroomSearchPanel.Controls.Add(this.roomPromptLabel);
            this.singleClassroomSearchPanel.Controls.Add(this.singleClassroomSearchTitleLabel);
            this.singleClassroomSearchPanel.Location = new System.Drawing.Point(3, 4);
            this.singleClassroomSearchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.singleClassroomSearchPanel.Name = "singleClassroomSearchPanel";
            this.singleClassroomSearchPanel.Size = new System.Drawing.Size(785, 470);
            this.singleClassroomSearchPanel.TabIndex = 7;
            // 
            // singleSearchTimePicker
            // 
            this.singleSearchTimePicker.CustomFormat = "hh:mm tt";
            this.singleSearchTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.singleSearchTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.singleSearchTimePicker.Location = new System.Drawing.Point(630, 129);
            this.singleSearchTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.singleSearchTimePicker.Name = "singleSearchTimePicker";
            this.singleSearchTimePicker.Size = new System.Drawing.Size(135, 29);
            this.singleSearchTimePicker.TabIndex = 11;
            // 
            // singleSearchDatePicker
            // 
            this.singleSearchDatePicker.CustomFormat = "dd MMMM yyyy";
            this.singleSearchDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.singleSearchDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.singleSearchDatePicker.Location = new System.Drawing.Point(279, 129);
            this.singleSearchDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.singleSearchDatePicker.Name = "singleSearchDatePicker";
            this.singleSearchDatePicker.Size = new System.Drawing.Size(253, 29);
            this.singleSearchDatePicker.TabIndex = 10;
            // 
            // noClassScheduledOnDateTimeNotificationLabel
            // 
            this.noClassScheduledOnDateTimeNotificationLabel.AutoSize = true;
            this.noClassScheduledOnDateTimeNotificationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.noClassScheduledOnDateTimeNotificationLabel.Location = new System.Drawing.Point(38, 196);
            this.noClassScheduledOnDateTimeNotificationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noClassScheduledOnDateTimeNotificationLabel.Name = "noClassScheduledOnDateTimeNotificationLabel";
            this.noClassScheduledOnDateTimeNotificationLabel.Size = new System.Drawing.Size(312, 13);
            this.noClassScheduledOnDateTimeNotificationLabel.TabIndex = 9;
            this.noClassScheduledOnDateTimeNotificationLabel.Text = "Display notificaiton here if no classrooms scheduled on date/time";
            // 
            // singleClassroomSearchDataGridView
            // 
            this.singleClassroomSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singleClassroomSearchDataGridView.Location = new System.Drawing.Point(38, 235);
            this.singleClassroomSearchDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.singleClassroomSearchDataGridView.Name = "singleClassroomSearchDataGridView";
            this.singleClassroomSearchDataGridView.RowTemplate.Height = 28;
            this.singleClassroomSearchDataGridView.Size = new System.Drawing.Size(687, 222);
            this.singleClassroomSearchDataGridView.TabIndex = 8;
            // 
            // singleSearchBackButton
            // 
            this.singleSearchBackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.singleSearchBackButton.Location = new System.Drawing.Point(19, 62);
            this.singleSearchBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.singleSearchBackButton.Name = "singleSearchBackButton";
            this.singleSearchBackButton.Size = new System.Drawing.Size(105, 48);
            this.singleSearchBackButton.TabIndex = 7;
            this.singleSearchBackButton.Text = "Back";
            this.singleSearchBackButton.UseVisualStyleBackColor = false;
            this.singleSearchBackButton.Click += new System.EventHandler(this.singleSearchBackButton_Click);
            // 
            // singleSearchDisplayAcceptableRooms
            // 
            this.singleSearchDisplayAcceptableRooms.BackColor = System.Drawing.SystemColors.Info;
            this.singleSearchDisplayAcceptableRooms.Location = new System.Drawing.Point(147, 62);
            this.singleSearchDisplayAcceptableRooms.Margin = new System.Windows.Forms.Padding(2);
            this.singleSearchDisplayAcceptableRooms.Name = "singleSearchDisplayAcceptableRooms";
            this.singleSearchDisplayAcceptableRooms.Size = new System.Drawing.Size(105, 48);
            this.singleSearchDisplayAcceptableRooms.TabIndex = 6;
            this.singleSearchDisplayAcceptableRooms.Text = "Display Acceptable Rooms";
            this.singleSearchDisplayAcceptableRooms.UseVisualStyleBackColor = false;
            this.singleSearchDisplayAcceptableRooms.Click += new System.EventHandler(this.singleSearchDisplayAcceptableRooms_Click);
            // 
            // roomDisplayTitleLabel
            // 
            this.roomDisplayTitleLabel.AutoSize = true;
            this.roomDisplayTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.roomDisplayTitleLabel.Location = new System.Drawing.Point(35, 164);
            this.roomDisplayTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomDisplayTitleLabel.Name = "roomDisplayTitleLabel";
            this.roomDisplayTitleLabel.Size = new System.Drawing.Size(478, 26);
            this.roomDisplayTitleLabel.TabIndex = 5;
            this.roomDisplayTitleLabel.Text = "Displaying: room### | # Classes in Room Today";
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.ForeColor = System.Drawing.Color.Red;
            this.notificationLabel.Location = new System.Drawing.Point(393, 101);
            this.notificationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(256, 13);
            this.notificationLabel.TabIndex = 4;
            this.notificationLabel.Text = "This will store error messages from the above prompt!";
            // 
            // singleClassroomSearchSearchButton
            // 
            this.singleClassroomSearchSearchButton.Location = new System.Drawing.Point(666, 60);
            this.singleClassroomSearchSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.singleClassroomSearchSearchButton.Name = "singleClassroomSearchSearchButton";
            this.singleClassroomSearchSearchButton.Size = new System.Drawing.Size(97, 30);
            this.singleClassroomSearchSearchButton.TabIndex = 3;
            this.singleClassroomSearchSearchButton.Text = "Search";
            this.singleClassroomSearchSearchButton.UseVisualStyleBackColor = true;
            this.singleClassroomSearchSearchButton.Click += new System.EventHandler(this.singleClassroomSearchSearchButton_Click);
            // 
            // roomPromptTextBox
            // 
            this.roomPromptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.roomPromptTextBox.Location = new System.Drawing.Point(425, 60);
            this.roomPromptTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.roomPromptTextBox.Name = "roomPromptTextBox";
            this.roomPromptTextBox.Size = new System.Drawing.Size(195, 29);
            this.roomPromptTextBox.TabIndex = 2;
            this.roomPromptTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // roomPromptLabel
            // 
            this.roomPromptLabel.AutoSize = true;
            this.roomPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.roomPromptLabel.Location = new System.Drawing.Point(282, 62);
            this.roomPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomPromptLabel.Name = "roomPromptLabel";
            this.roomPromptLabel.Size = new System.Drawing.Size(121, 24);
            this.roomPromptLabel.TabIndex = 1;
            this.roomPromptLabel.Text = "Enter Room: ";
            // 
            // singleClassroomSearchTitleLabel
            // 
            this.singleClassroomSearchTitleLabel.AutoSize = true;
            this.singleClassroomSearchTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline);
            this.singleClassroomSearchTitleLabel.Location = new System.Drawing.Point(227, 12);
            this.singleClassroomSearchTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.singleClassroomSearchTitleLabel.Name = "singleClassroomSearchTitleLabel";
            this.singleClassroomSearchTitleLabel.Size = new System.Drawing.Size(319, 31);
            this.singleClassroomSearchTitleLabel.TabIndex = 0;
            this.singleClassroomSearchTitleLabel.Text = "Single Classroom Search";
            // 
            // title_Label
            // 
            this.title_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title_Label.AutoSize = true;
            this.title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline);
            this.title_Label.Location = new System.Drawing.Point(75, 28);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(646, 39);
            this.title_Label.TabIndex = 3;
            this.title_Label.Text = "UCCS OIT - Classroom Schedule Lookup";
            // 
            // buildingsDashboardGroupBox
            // 
            this.buildingsDashboardGroupBox.Controls.Add(this.acadCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.brecCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.cuchCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.uhalCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.laneCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.ocseCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.engrCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.dwirCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.centCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.coluCountLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.acadBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.brecBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.cuchBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.uhalBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.laneBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.ocseBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.engrBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.dwirBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.centBlgLabel);
            this.buildingsDashboardGroupBox.Controls.Add(this.coluBlgLabel);
            this.buildingsDashboardGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buildingsDashboardGroupBox.Location = new System.Drawing.Point(11, 83);
            this.buildingsDashboardGroupBox.Name = "buildingsDashboardGroupBox";
            this.buildingsDashboardGroupBox.Size = new System.Drawing.Size(760, 96);
            this.buildingsDashboardGroupBox.TabIndex = 4;
            this.buildingsDashboardGroupBox.TabStop = false;
            this.buildingsDashboardGroupBox.Text = "Buildings Dashboard - Number of Available Rooms";
            // 
            // acadCountLabel
            // 
            this.acadCountLabel.AutoSize = true;
            this.acadCountLabel.Location = new System.Drawing.Point(693, 51);
            this.acadCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acadCountLabel.Name = "acadCountLabel";
            this.acadCountLabel.Size = new System.Drawing.Size(18, 20);
            this.acadCountLabel.TabIndex = 20;
            this.acadCountLabel.Text = "0";
            // 
            // brecCountLabel
            // 
            this.brecCountLabel.AutoSize = true;
            this.brecCountLabel.Location = new System.Drawing.Point(617, 51);
            this.brecCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brecCountLabel.Name = "brecCountLabel";
            this.brecCountLabel.Size = new System.Drawing.Size(18, 20);
            this.brecCountLabel.TabIndex = 19;
            this.brecCountLabel.Text = "0";
            // 
            // cuchCountLabel
            // 
            this.cuchCountLabel.AutoSize = true;
            this.cuchCountLabel.Location = new System.Drawing.Point(545, 51);
            this.cuchCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cuchCountLabel.Name = "cuchCountLabel";
            this.cuchCountLabel.Size = new System.Drawing.Size(18, 20);
            this.cuchCountLabel.TabIndex = 18;
            this.cuchCountLabel.Text = "0";
            // 
            // uhalCountLabel
            // 
            this.uhalCountLabel.AutoSize = true;
            this.uhalCountLabel.Location = new System.Drawing.Point(461, 51);
            this.uhalCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uhalCountLabel.Name = "uhalCountLabel";
            this.uhalCountLabel.Size = new System.Drawing.Size(18, 20);
            this.uhalCountLabel.TabIndex = 17;
            this.uhalCountLabel.Text = "0";
            // 
            // laneCountLabel
            // 
            this.laneCountLabel.AutoSize = true;
            this.laneCountLabel.Location = new System.Drawing.Point(381, 51);
            this.laneCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laneCountLabel.Name = "laneCountLabel";
            this.laneCountLabel.Size = new System.Drawing.Size(18, 20);
            this.laneCountLabel.TabIndex = 16;
            this.laneCountLabel.Text = "0";
            // 
            // ocseCountLabel
            // 
            this.ocseCountLabel.AutoSize = true;
            this.ocseCountLabel.Location = new System.Drawing.Point(305, 51);
            this.ocseCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ocseCountLabel.Name = "ocseCountLabel";
            this.ocseCountLabel.Size = new System.Drawing.Size(18, 20);
            this.ocseCountLabel.TabIndex = 15;
            this.ocseCountLabel.Text = "0";
            // 
            // engrCountLabel
            // 
            this.engrCountLabel.AutoSize = true;
            this.engrCountLabel.Location = new System.Drawing.Point(232, 51);
            this.engrCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.engrCountLabel.Name = "engrCountLabel";
            this.engrCountLabel.Size = new System.Drawing.Size(18, 20);
            this.engrCountLabel.TabIndex = 14;
            this.engrCountLabel.Text = "0";
            // 
            // dwirCountLabel
            // 
            this.dwirCountLabel.AutoSize = true;
            this.dwirCountLabel.Location = new System.Drawing.Point(165, 51);
            this.dwirCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dwirCountLabel.Name = "dwirCountLabel";
            this.dwirCountLabel.Size = new System.Drawing.Size(18, 20);
            this.dwirCountLabel.TabIndex = 13;
            this.dwirCountLabel.Text = "0";
            // 
            // centCountLabel
            // 
            this.centCountLabel.AutoSize = true;
            this.centCountLabel.Location = new System.Drawing.Point(95, 51);
            this.centCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.centCountLabel.Name = "centCountLabel";
            this.centCountLabel.Size = new System.Drawing.Size(18, 20);
            this.centCountLabel.TabIndex = 12;
            this.centCountLabel.Text = "0";
            // 
            // coluCountLabel
            // 
            this.coluCountLabel.AutoSize = true;
            this.coluCountLabel.Location = new System.Drawing.Point(27, 51);
            this.coluCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coluCountLabel.Name = "coluCountLabel";
            this.coluCountLabel.Size = new System.Drawing.Size(18, 20);
            this.coluCountLabel.TabIndex = 11;
            this.coluCountLabel.Text = "0";
            // 
            // acadBlgLabel
            // 
            this.acadBlgLabel.AutoSize = true;
            this.acadBlgLabel.Location = new System.Drawing.Point(681, 26);
            this.acadBlgLabel.Name = "acadBlgLabel";
            this.acadBlgLabel.Size = new System.Drawing.Size(54, 20);
            this.acadBlgLabel.TabIndex = 9;
            this.acadBlgLabel.Text = "ACAD";
            // 
            // brecBlgLabel
            // 
            this.brecBlgLabel.AutoSize = true;
            this.brecBlgLabel.Location = new System.Drawing.Point(607, 26);
            this.brecBlgLabel.Name = "brecBlgLabel";
            this.brecBlgLabel.Size = new System.Drawing.Size(54, 20);
            this.brecBlgLabel.TabIndex = 8;
            this.brecBlgLabel.Text = "BREC";
            // 
            // cuchBlgLabel
            // 
            this.cuchBlgLabel.AutoSize = true;
            this.cuchBlgLabel.Location = new System.Drawing.Point(532, 26);
            this.cuchBlgLabel.Name = "cuchBlgLabel";
            this.cuchBlgLabel.Size = new System.Drawing.Size(55, 20);
            this.cuchBlgLabel.TabIndex = 7;
            this.cuchBlgLabel.Text = "CUCH";
            // 
            // uhalBlgLabel
            // 
            this.uhalBlgLabel.AutoSize = true;
            this.uhalBlgLabel.Location = new System.Drawing.Point(453, 26);
            this.uhalBlgLabel.Name = "uhalBlgLabel";
            this.uhalBlgLabel.Size = new System.Drawing.Size(53, 20);
            this.uhalBlgLabel.TabIndex = 6;
            this.uhalBlgLabel.Text = "UHAL";
            // 
            // laneBlgLabel
            // 
            this.laneBlgLabel.AutoSize = true;
            this.laneBlgLabel.Location = new System.Drawing.Point(373, 26);
            this.laneBlgLabel.Name = "laneBlgLabel";
            this.laneBlgLabel.Size = new System.Drawing.Size(51, 20);
            this.laneBlgLabel.TabIndex = 5;
            this.laneBlgLabel.Text = "LANE";
            // 
            // ocseBlgLabel
            // 
            this.ocseBlgLabel.AutoSize = true;
            this.ocseBlgLabel.Location = new System.Drawing.Point(293, 26);
            this.ocseBlgLabel.Name = "ocseBlgLabel";
            this.ocseBlgLabel.Size = new System.Drawing.Size(54, 20);
            this.ocseBlgLabel.TabIndex = 4;
            this.ocseBlgLabel.Text = "OCSE";
            // 
            // engrBlgLabel
            // 
            this.engrBlgLabel.AutoSize = true;
            this.engrBlgLabel.Location = new System.Drawing.Point(221, 26);
            this.engrBlgLabel.Name = "engrBlgLabel";
            this.engrBlgLabel.Size = new System.Drawing.Size(56, 20);
            this.engrBlgLabel.TabIndex = 3;
            this.engrBlgLabel.Text = "ENGR";
            // 
            // dwirBlgLabel
            // 
            this.dwirBlgLabel.AutoSize = true;
            this.dwirBlgLabel.Location = new System.Drawing.Point(153, 26);
            this.dwirBlgLabel.Name = "dwirBlgLabel";
            this.dwirBlgLabel.Size = new System.Drawing.Size(53, 20);
            this.dwirBlgLabel.TabIndex = 2;
            this.dwirBlgLabel.Text = "DWIR";
            // 
            // centBlgLabel
            // 
            this.centBlgLabel.AutoSize = true;
            this.centBlgLabel.Location = new System.Drawing.Point(83, 26);
            this.centBlgLabel.Name = "centBlgLabel";
            this.centBlgLabel.Size = new System.Drawing.Size(51, 20);
            this.centBlgLabel.TabIndex = 1;
            this.centBlgLabel.Text = "CENT";
            // 
            // coluBlgLabel
            // 
            this.coluBlgLabel.AutoSize = true;
            this.coluBlgLabel.Location = new System.Drawing.Point(16, 26);
            this.coluBlgLabel.Name = "coluBlgLabel";
            this.coluBlgLabel.Size = new System.Drawing.Size(53, 20);
            this.coluBlgLabel.TabIndex = 0;
            this.coluBlgLabel.Text = "COLU";
            // 
            // uccsLogoBox
            // 
            this.uccsLogoBox.Location = new System.Drawing.Point(33, 235);
            this.uccsLogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.uccsLogoBox.Name = "uccsLogoBox";
            this.uccsLogoBox.Size = new System.Drawing.Size(385, 188);
            this.uccsLogoBox.TabIndex = 7;
            this.uccsLogoBox.TabStop = false;
            // 
            // globalSearchBtn
            // 
            this.globalSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.globalSearchBtn.Location = new System.Drawing.Point(475, 235);
            this.globalSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.globalSearchBtn.Name = "globalSearchBtn";
            this.globalSearchBtn.Size = new System.Drawing.Size(205, 50);
            this.globalSearchBtn.TabIndex = 5;
            this.globalSearchBtn.Text = "Global Search";
            this.globalSearchBtn.UseVisualStyleBackColor = true;
            this.globalSearchBtn.Click += new System.EventHandler(this.globalSearchBtn_Click);
            // 
            // singleClassroomSearchBtn
            // 
            this.singleClassroomSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.singleClassroomSearchBtn.Location = new System.Drawing.Point(453, 320);
            this.singleClassroomSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.singleClassroomSearchBtn.Name = "singleClassroomSearchBtn";
            this.singleClassroomSearchBtn.Size = new System.Drawing.Size(249, 54);
            this.singleClassroomSearchBtn.TabIndex = 6;
            this.singleClassroomSearchBtn.Text = "Single Classroom Search";
            this.singleClassroomSearchBtn.UseVisualStyleBackColor = true;
            this.singleClassroomSearchBtn.Click += new System.EventHandler(this.singleClassroomSearchBtn_Click);
            // 
            // globalSearchPanel
            // 
            this.globalSearchPanel.Controls.Add(this.globalSearchBackBtn);
            this.globalSearchPanel.Controls.Add(this.globalSearchDataGridView);
            this.globalSearchPanel.Controls.Add(this.globalSearchSearchBtn);
            this.globalSearchPanel.Controls.Add(this.selectDateTimeLabel);
            this.globalSearchPanel.Controls.Add(this.globalSearchTimePicker);
            this.globalSearchPanel.Controls.Add(this.globalSearchDatePicker);
            this.globalSearchPanel.Controls.Add(this.globalSearchTitleLabel);
            this.globalSearchPanel.Location = new System.Drawing.Point(2, 2);
            this.globalSearchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.globalSearchPanel.Name = "globalSearchPanel";
            this.globalSearchPanel.Size = new System.Drawing.Size(787, 474);
            this.globalSearchPanel.TabIndex = 8;
            // 
            // globalSearchBackBtn
            // 
            this.globalSearchBackBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.globalSearchBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.globalSearchBackBtn.Location = new System.Drawing.Point(94, 21);
            this.globalSearchBackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.globalSearchBackBtn.Name = "globalSearchBackBtn";
            this.globalSearchBackBtn.Size = new System.Drawing.Size(103, 37);
            this.globalSearchBackBtn.TabIndex = 6;
            this.globalSearchBackBtn.Text = "Back";
            this.globalSearchBackBtn.UseVisualStyleBackColor = false;
            this.globalSearchBackBtn.Click += new System.EventHandler(this.globalSearchBackBtn_Click);
            // 
            // globalSearchDataGridView
            // 
            this.globalSearchDataGridView.AllowUserToAddRows = false;
            this.globalSearchDataGridView.AllowUserToDeleteRows = false;
            this.globalSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.globalSearchDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.globalSearchDataGridView.Location = new System.Drawing.Point(31, 147);
            this.globalSearchDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.globalSearchDataGridView.Name = "globalSearchDataGridView";
            this.globalSearchDataGridView.ReadOnly = true;
            this.globalSearchDataGridView.RowTemplate.Height = 28;
            this.globalSearchDataGridView.Size = new System.Drawing.Size(723, 307);
            this.globalSearchDataGridView.TabIndex = 5;
            // 
            // globalSearchSearchBtn
            // 
            this.globalSearchSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.globalSearchSearchBtn.Location = new System.Drawing.Point(582, 93);
            this.globalSearchSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.globalSearchSearchBtn.Name = "globalSearchSearchBtn";
            this.globalSearchSearchBtn.Size = new System.Drawing.Size(103, 37);
            this.globalSearchSearchBtn.TabIndex = 4;
            this.globalSearchSearchBtn.Text = "Search";
            this.globalSearchSearchBtn.UseVisualStyleBackColor = true;
            this.globalSearchSearchBtn.Click += new System.EventHandler(this.globalSearchSearchBtn_Click);
            // 
            // selectDateTimeLabel
            // 
            this.selectDateTimeLabel.AutoSize = true;
            this.selectDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.selectDateTimeLabel.Location = new System.Drawing.Point(80, 102);
            this.selectDateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectDateTimeLabel.Name = "selectDateTimeLabel";
            this.selectDateTimeLabel.Size = new System.Drawing.Size(158, 24);
            this.selectDateTimeLabel.TabIndex = 3;
            this.selectDateTimeLabel.Text = "Select Date/Time:";
            // 
            // globalSearchTimePicker
            // 
            this.globalSearchTimePicker.CustomFormat = "hh:mm tt";
            this.globalSearchTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.globalSearchTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.globalSearchTimePicker.Location = new System.Drawing.Point(420, 99);
            this.globalSearchTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.globalSearchTimePicker.Name = "globalSearchTimePicker";
            this.globalSearchTimePicker.Size = new System.Drawing.Size(113, 29);
            this.globalSearchTimePicker.TabIndex = 2;
            // 
            // globalSearchDatePicker
            // 
            this.globalSearchDatePicker.CustomFormat = "dd MMMM yyyy";
            this.globalSearchDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.globalSearchDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.globalSearchDatePicker.Location = new System.Drawing.Point(243, 99);
            this.globalSearchDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.globalSearchDatePicker.Name = "globalSearchDatePicker";
            this.globalSearchDatePicker.Size = new System.Drawing.Size(159, 29);
            this.globalSearchDatePicker.TabIndex = 1;
            // 
            // globalSearchTitleLabel
            // 
            this.globalSearchTitleLabel.AutoSize = true;
            this.globalSearchTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline);
            this.globalSearchTitleLabel.Location = new System.Drawing.Point(300, 24);
            this.globalSearchTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.globalSearchTitleLabel.Name = "globalSearchTitleLabel";
            this.globalSearchTitleLabel.Size = new System.Drawing.Size(233, 39);
            this.globalSearchTitleLabel.TabIndex = 0;
            this.globalSearchTitleLabel.Text = "Global Search";
            // 
            // classScheduledOnDateTimeNotificationLabel
            // 
            this.classScheduledOnDateTimeNotificationLabel.AutoSize = true;
            this.classScheduledOnDateTimeNotificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classScheduledOnDateTimeNotificationLabel.ForeColor = System.Drawing.Color.Red;
            this.classScheduledOnDateTimeNotificationLabel.Location = new System.Drawing.Point(470, 196);
            this.classScheduledOnDateTimeNotificationLabel.Name = "classScheduledOnDateTimeNotificationLabel";
            this.classScheduledOnDateTimeNotificationLabel.Size = new System.Drawing.Size(179, 17);
            this.classScheduledOnDateTimeNotificationLabel.TabIndex = 12;
            this.classScheduledOnDateTimeNotificationLabel.Text = "Display if room in use here!";
            this.classScheduledOnDateTimeNotificationLabel.Visible = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.homePagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "UCCS Class Schedule Lookup";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.homePagePanel.ResumeLayout(false);
            this.homePagePanel.PerformLayout();
            this.singleClassroomSearchPanel.ResumeLayout(false);
            this.singleClassroomSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleClassroomSearchDataGridView)).EndInit();
            this.buildingsDashboardGroupBox.ResumeLayout(false);
            this.buildingsDashboardGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccsLogoBox)).EndInit();
            this.globalSearchPanel.ResumeLayout(false);
            this.globalSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalSearchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.Panel homePagePanel;
        private System.Windows.Forms.GroupBox buildingsDashboardGroupBox;
        private System.Windows.Forms.Label acadCountLabel;
        private System.Windows.Forms.Label brecCountLabel;
        private System.Windows.Forms.Label cuchCountLabel;
        private System.Windows.Forms.Label uhalCountLabel;
        private System.Windows.Forms.Label laneCountLabel;
        private System.Windows.Forms.Label ocseCountLabel;
        private System.Windows.Forms.Label engrCountLabel;
        private System.Windows.Forms.Label dwirCountLabel;
        private System.Windows.Forms.Label centCountLabel;
        private System.Windows.Forms.Label coluCountLabel;
        private System.Windows.Forms.Label acadBlgLabel;
        private System.Windows.Forms.Label brecBlgLabel;
        private System.Windows.Forms.Label cuchBlgLabel;
        private System.Windows.Forms.Label uhalBlgLabel;
        private System.Windows.Forms.Label laneBlgLabel;
        private System.Windows.Forms.Label ocseBlgLabel;
        private System.Windows.Forms.Label engrBlgLabel;
        private System.Windows.Forms.Label dwirBlgLabel;
        private System.Windows.Forms.Label centBlgLabel;
        private System.Windows.Forms.Label coluBlgLabel;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Button globalSearchBtn;
        private System.Windows.Forms.Button singleClassroomSearchBtn;
        private System.Windows.Forms.PictureBox uccsLogoBox;
        private System.Windows.Forms.Panel globalSearchPanel;
        private System.Windows.Forms.Label globalSearchTitleLabel;
        private System.Windows.Forms.DateTimePicker globalSearchDatePicker;
        private System.Windows.Forms.DateTimePicker globalSearchTimePicker;
        private System.Windows.Forms.Label selectDateTimeLabel;
        private System.Windows.Forms.Button globalSearchSearchBtn;
        private System.Windows.Forms.DataGridView globalSearchDataGridView;
        private System.Windows.Forms.Button globalSearchBackBtn;
        private System.Windows.Forms.Panel singleClassroomSearchPanel;
        private System.Windows.Forms.Label singleClassroomSearchTitleLabel;
        private System.Windows.Forms.Button singleClassroomSearchSearchButton;
        private System.Windows.Forms.TextBox roomPromptTextBox;
        private System.Windows.Forms.Label roomPromptLabel;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Label roomDisplayTitleLabel;
        private System.Windows.Forms.Button singleSearchDisplayAcceptableRooms;
        private System.Windows.Forms.Button singleSearchBackButton;
        private System.Windows.Forms.DataGridView singleClassroomSearchDataGridView;
        private System.Windows.Forms.Label noClassScheduledOnDateTimeNotificationLabel;
        private System.Windows.Forms.DateTimePicker singleSearchTimePicker;
        private System.Windows.Forms.DateTimePicker singleSearchDatePicker;
        private System.Windows.Forms.Label classScheduledOnDateTimeNotificationLabel;
    }
}

