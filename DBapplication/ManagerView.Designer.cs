
namespace DBapplication
{
    partial class ManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManageTrips = new System.Windows.Forms.Button();
            this.ManageNews = new System.Windows.Forms.Button();
            this.RescheduleTrains = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.AddTrains = new System.Windows.Forms.Button();
            this.AddTrainPanel = new System.Windows.Forms.Panel();
            this.TripIDassign = new System.Windows.Forms.ComboBox();
            this.TrainIDassign = new System.Windows.Forms.ComboBox();
            this.assignbutton = new System.Windows.Forms.Button();
            this.AddTrain = new System.Windows.Forms.Button();
            this.PassIDWarn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTrainID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.RescheduleTrainPanel = new System.Windows.Forms.Panel();
            this.EndSericeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.StartSerivceTrain = new System.Windows.Forms.DateTimePicker();
            this.TrainTables = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmReplace = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.AddTripPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ArrivalStation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DepStation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TripIDAdd = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.NewsPanel = new System.Windows.Forms.Panel();
            this.NewsDataGrid = new System.Windows.Forms.DataGridView();
            this.newsUpdatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.railWayStationDataSet10 = new DBapplication.RailWayStationDataSet10();
            this.button2 = new System.Windows.Forms.Button();
            this.AddNews = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.NewsTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.managerTableAdapter = new DBapplication.RailWayStationDataSet10TableAdapters.ManagerTableAdapter();
            this.panel1.SuspendLayout();
            this.AddTrainPanel.SuspendLayout();
            this.RescheduleTrainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainTables)).BeginInit();
            this.AddTripPanel.SuspendLayout();
            this.NewsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railWayStationDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.ManageTrips);
            this.panel1.Controls.Add(this.ManageNews);
            this.panel1.Controls.Add(this.RescheduleTrains);
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.AddTrains);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 69);
            this.panel1.TabIndex = 1;
            // 
            // ManageTrips
            // 
            this.ManageTrips.BackColor = System.Drawing.SystemColors.Highlight;
            this.ManageTrips.FlatAppearance.BorderSize = 0;
            this.ManageTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageTrips.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ManageTrips.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageTrips.Location = new System.Drawing.Point(304, 2);
            this.ManageTrips.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManageTrips.Name = "ManageTrips";
            this.ManageTrips.Size = new System.Drawing.Size(182, 65);
            this.ManageTrips.TabIndex = 1;
            this.ManageTrips.Text = "Manage Trips";
            this.ManageTrips.UseVisualStyleBackColor = false;
            this.ManageTrips.Click += new System.EventHandler(this.ManageTrips_Click);
            // 
            // ManageNews
            // 
            this.ManageNews.BackColor = System.Drawing.SystemColors.Highlight;
            this.ManageNews.FlatAppearance.BorderSize = 0;
            this.ManageNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageNews.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ManageNews.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageNews.Location = new System.Drawing.Point(490, 2);
            this.ManageNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManageNews.Name = "ManageNews";
            this.ManageNews.Size = new System.Drawing.Size(168, 65);
            this.ManageNews.TabIndex = 1;
            this.ManageNews.Text = "Manage News";
            this.ManageNews.UseVisualStyleBackColor = false;
            this.ManageNews.Click += new System.EventHandler(this.TimetableVeiw_Click);
            // 
            // RescheduleTrains
            // 
            this.RescheduleTrains.BackColor = System.Drawing.SystemColors.Highlight;
            this.RescheduleTrains.FlatAppearance.BorderSize = 0;
            this.RescheduleTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RescheduleTrains.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RescheduleTrains.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RescheduleTrains.Location = new System.Drawing.Point(142, 2);
            this.RescheduleTrains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RescheduleTrains.Name = "RescheduleTrains";
            this.RescheduleTrains.Size = new System.Drawing.Size(158, 65);
            this.RescheduleTrains.TabIndex = 1;
            this.RescheduleTrains.Text = "Reschedule Trains";
            this.RescheduleTrains.UseVisualStyleBackColor = false;
            this.RescheduleTrains.Click += new System.EventHandler(this.RescheduleTrains_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOut.Location = new System.Drawing.Point(663, 2);
            this.LogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(136, 65);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // AddTrains
            // 
            this.AddTrains.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddTrains.FlatAppearance.BorderSize = 0;
            this.AddTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTrains.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddTrains.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTrains.Location = new System.Drawing.Point(2, 0);
            this.AddTrains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTrains.Name = "AddTrains";
            this.AddTrains.Size = new System.Drawing.Size(136, 67);
            this.AddTrains.TabIndex = 1;
            this.AddTrains.Text = "Add Trains";
            this.AddTrains.UseVisualStyleBackColor = false;
            this.AddTrains.Click += new System.EventHandler(this.AddTrains_Click);
            // 
            // AddTrainPanel
            // 
            this.AddTrainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddTrainPanel.BackgroundImage")));
            this.AddTrainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTrainPanel.Controls.Add(this.TripIDassign);
            this.AddTrainPanel.Controls.Add(this.TrainIDassign);
            this.AddTrainPanel.Controls.Add(this.assignbutton);
            this.AddTrainPanel.Controls.Add(this.AddTrain);
            this.AddTrainPanel.Controls.Add(this.PassIDWarn);
            this.AddTrainPanel.Controls.Add(this.label3);
            this.AddTrainPanel.Controls.Add(this.label2);
            this.AddTrainPanel.Controls.Add(this.AddTrainID);
            this.AddTrainPanel.Controls.Add(this.label1);
            this.AddTrainPanel.Controls.Add(this.label21);
            this.AddTrainPanel.Location = new System.Drawing.Point(11, 85);
            this.AddTrainPanel.Name = "AddTrainPanel";
            this.AddTrainPanel.Size = new System.Drawing.Size(801, 376);
            this.AddTrainPanel.TabIndex = 2;
            // 
            // TripIDassign
            // 
            this.TripIDassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TripIDassign.FormattingEnabled = true;
            this.TripIDassign.Location = new System.Drawing.Point(370, 189);
            this.TripIDassign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TripIDassign.Name = "TripIDassign";
            this.TripIDassign.Size = new System.Drawing.Size(96, 21);
            this.TripIDassign.TabIndex = 62;
            // 
            // TrainIDassign
            // 
            this.TrainIDassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainIDassign.FormattingEnabled = true;
            this.TrainIDassign.Location = new System.Drawing.Point(93, 189);
            this.TrainIDassign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrainIDassign.Name = "TrainIDassign";
            this.TrainIDassign.Size = new System.Drawing.Size(96, 21);
            this.TrainIDassign.TabIndex = 62;
            // 
            // assignbutton
            // 
            this.assignbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.assignbutton.FlatAppearance.BorderSize = 0;
            this.assignbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignbutton.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.assignbutton.Location = new System.Drawing.Point(530, 188);
            this.assignbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assignbutton.Name = "assignbutton";
            this.assignbutton.Size = new System.Drawing.Size(82, 25);
            this.assignbutton.TabIndex = 60;
            this.assignbutton.Text = "Assign";
            this.assignbutton.UseVisualStyleBackColor = false;
            // 
            // AddTrain
            // 
            this.AddTrain.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddTrain.FlatAppearance.BorderSize = 0;
            this.AddTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTrain.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTrain.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddTrain.Location = new System.Drawing.Point(260, 58);
            this.AddTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTrain.Name = "AddTrain";
            this.AddTrain.Size = new System.Drawing.Size(82, 25);
            this.AddTrain.TabIndex = 60;
            this.AddTrain.Text = "Add";
            this.AddTrain.UseVisualStyleBackColor = false;
            // 
            // PassIDWarn
            // 
            this.PassIDWarn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassIDWarn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassIDWarn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassIDWarn.Location = new System.Drawing.Point(93, 59);
            this.PassIDWarn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassIDWarn.Mask = "0000";
            this.PassIDWarn.Name = "PassIDWarn";
            this.PassIDWarn.PromptChar = ' ';
            this.PassIDWarn.Size = new System.Drawing.Size(142, 23);
            this.PassIDWarn.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Trip ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Train ID";
            // 
            // AddTrainID
            // 
            this.AddTrainID.AutoSize = true;
            this.AddTrainID.BackColor = System.Drawing.Color.Transparent;
            this.AddTrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTrainID.Location = new System.Drawing.Point(20, 62);
            this.AddTrainID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddTrainID.Name = "AddTrainID";
            this.AddTrainID.Size = new System.Drawing.Size(58, 17);
            this.AddTrainID.TabIndex = 58;
            this.AddTrainID.Text = "Train ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Assign Train to a Trip";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label21.Location = new System.Drawing.Point(19, 23);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 19);
            this.label21.TabIndex = 37;
            this.label21.Text = "Add a Train";
            // 
            // RescheduleTrainPanel
            // 
            this.RescheduleTrainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RescheduleTrainPanel.BackgroundImage")));
            this.RescheduleTrainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RescheduleTrainPanel.Controls.Add(this.EndSericeDate);
            this.RescheduleTrainPanel.Controls.Add(this.label5);
            this.RescheduleTrainPanel.Controls.Add(this.StartSerivceTrain);
            this.RescheduleTrainPanel.Controls.Add(this.TrainTables);
            this.RescheduleTrainPanel.Controls.Add(this.comboBox1);
            this.RescheduleTrainPanel.Controls.Add(this.label4);
            this.RescheduleTrainPanel.Controls.Add(this.ConfirmReplace);
            this.RescheduleTrainPanel.Controls.Add(this.label6);
            this.RescheduleTrainPanel.Controls.Add(this.label7);
            this.RescheduleTrainPanel.Controls.Add(this.label8);
            this.RescheduleTrainPanel.Controls.Add(this.label33);
            this.RescheduleTrainPanel.Location = new System.Drawing.Point(11, 85);
            this.RescheduleTrainPanel.Name = "RescheduleTrainPanel";
            this.RescheduleTrainPanel.Size = new System.Drawing.Size(801, 376);
            this.RescheduleTrainPanel.TabIndex = 63;
            // 
            // EndSericeDate
            // 
            this.EndSericeDate.Location = new System.Drawing.Point(49, 235);
            this.EndSericeDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.EndSericeDate.MinDate = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            this.EndSericeDate.Name = "EndSericeDate";
            this.EndSericeDate.Size = new System.Drawing.Size(200, 20);
            this.EndSericeDate.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(46, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 19);
            this.label5.TabIndex = 75;
            this.label5.Text = "Entering End Service Date";
            // 
            // StartSerivceTrain
            // 
            this.StartSerivceTrain.Location = new System.Drawing.Point(49, 149);
            this.StartSerivceTrain.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.StartSerivceTrain.MinDate = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            this.StartSerivceTrain.Name = "StartSerivceTrain";
            this.StartSerivceTrain.Size = new System.Drawing.Size(200, 20);
            this.StartSerivceTrain.TabIndex = 74;
            this.StartSerivceTrain.Value = new System.DateTime(2022, 1, 10, 1, 34, 38, 0);
            // 
            // TrainTables
            // 
            this.TrainTables.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TrainTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainTables.Location = new System.Drawing.Point(334, 106);
            this.TrainTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrainTables.Name = "TrainTables";
            this.TrainTables.RowHeadersWidth = 51;
            this.TrainTables.RowTemplate.Height = 24;
            this.TrainTables.Size = new System.Drawing.Size(204, 232);
            this.TrainTables.TabIndex = 73;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 58);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Trip ID";
            // 
            // ConfirmReplace
            // 
            this.ConfirmReplace.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmReplace.FlatAppearance.BorderSize = 0;
            this.ConfirmReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmReplace.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmReplace.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ConfirmReplace.Location = new System.Drawing.Point(166, 314);
            this.ConfirmReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmReplace.Name = "ConfirmReplace";
            this.ConfirmReplace.Size = new System.Drawing.Size(82, 25);
            this.ConfirmReplace.TabIndex = 70;
            this.ConfirmReplace.Text = "Confirm";
            this.ConfirmReplace.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(330, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "List of Trains";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(46, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 19);
            this.label7.TabIndex = 67;
            this.label7.Text = "Entering Start Service Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(330, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 19);
            this.label8.TabIndex = 68;
            this.label8.Text = "Select A Train to Replace the Current one";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label33.Location = new System.Drawing.Point(45, 13);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(120, 19);
            this.label33.TabIndex = 69;
            this.label33.Text = "Select a Trip ID";
            // 
            // AddTripPanel
            // 
            this.AddTripPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddTripPanel.BackgroundImage")));
            this.AddTripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTripPanel.Controls.Add(this.dateTimePicker1);
            this.AddTripPanel.Controls.Add(this.ArrivalStation);
            this.AddTripPanel.Controls.Add(this.label9);
            this.AddTripPanel.Controls.Add(this.DepStation);
            this.AddTripPanel.Controls.Add(this.label10);
            this.AddTripPanel.Controls.Add(this.TripIDAdd);
            this.AddTripPanel.Controls.Add(this.label11);
            this.AddTripPanel.Controls.Add(this.label12);
            this.AddTripPanel.Controls.Add(this.button1);
            this.AddTripPanel.Controls.Add(this.label13);
            this.AddTripPanel.Location = new System.Drawing.Point(11, 85);
            this.AddTripPanel.Name = "AddTripPanel";
            this.AddTripPanel.Size = new System.Drawing.Size(801, 376);
            this.AddTripPanel.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(487, 73);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 23);
            this.dateTimePicker1.TabIndex = 82;
            // 
            // ArrivalStation
            // 
            this.ArrivalStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArrivalStation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalStation.Location = new System.Drawing.Point(501, 145);
            this.ArrivalStation.Name = "ArrivalStation";
            this.ArrivalStation.Size = new System.Drawing.Size(142, 24);
            this.ArrivalStation.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Arrival Station";
            // 
            // DepStation
            // 
            this.DepStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepStation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepStation.Location = new System.Drawing.Point(166, 145);
            this.DepStation.Name = "DepStation";
            this.DepStation.Size = new System.Drawing.Size(142, 24);
            this.DepStation.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 78;
            this.label10.Text = "Departure Station";
            // 
            // TripIDAdd
            // 
            this.TripIDAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TripIDAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TripIDAdd.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TripIDAdd.Location = new System.Drawing.Point(119, 70);
            this.TripIDAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TripIDAdd.Mask = "0000";
            this.TripIDAdd.Name = "TripIDAdd";
            this.TripIDAdd.PromptChar = ' ';
            this.TripIDAdd.Size = new System.Drawing.Size(142, 23);
            this.TripIDAdd.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(396, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "Trip Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "Trip ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(561, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 70;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(45, 13);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 69;
            this.label13.Text = "Add a Trip";
            // 
            // NewsPanel
            // 
            this.NewsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewsPanel.BackgroundImage")));
            this.NewsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewsPanel.Controls.Add(this.NewsDataGrid);
            this.NewsPanel.Controls.Add(this.button2);
            this.NewsPanel.Controls.Add(this.AddNews);
            this.NewsPanel.Controls.Add(this.label15);
            this.NewsPanel.Controls.Add(this.NewsTextBox);
            this.NewsPanel.Controls.Add(this.label14);
            this.NewsPanel.Location = new System.Drawing.Point(11, 85);
            this.NewsPanel.Name = "NewsPanel";
            this.NewsPanel.Size = new System.Drawing.Size(801, 376);
            this.NewsPanel.TabIndex = 64;
            // 
            // NewsDataGrid
            // 
            this.NewsDataGrid.AllowUserToAddRows = false;
            this.NewsDataGrid.AutoGenerateColumns = false;
            this.NewsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.NewsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newsUpdatesDataGridViewTextBoxColumn});
            this.NewsDataGrid.DataSource = this.managerBindingSource;
            this.NewsDataGrid.Location = new System.Drawing.Point(304, 217);
            this.NewsDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewsDataGrid.Name = "NewsDataGrid";
            this.NewsDataGrid.ReadOnly = true;
            this.NewsDataGrid.RowHeadersWidth = 51;
            this.NewsDataGrid.RowTemplate.Height = 24;
            this.NewsDataGrid.Size = new System.Drawing.Size(328, 106);
            this.NewsDataGrid.TabIndex = 83;
            // 
            // newsUpdatesDataGridViewTextBoxColumn
            // 
            this.newsUpdatesDataGridViewTextBoxColumn.DataPropertyName = "News_Updates";
            this.newsUpdatesDataGridViewTextBoxColumn.HeaderText = "News_Updates";
            this.newsUpdatesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newsUpdatesDataGridViewTextBoxColumn.Name = "newsUpdatesDataGridViewTextBoxColumn";
            this.newsUpdatesDataGridViewTextBoxColumn.ReadOnly = true;
            this.newsUpdatesDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.railWayStationDataSet10;
            // 
            // railWayStationDataSet10
            // 
            this.railWayStationDataSet10.DataSetName = "RailWayStationDataSet10";
            this.railWayStationDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(700, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 25);
            this.button2.TabIndex = 82;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AddNews
            // 
            this.AddNews.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddNews.FlatAppearance.BorderSize = 0;
            this.AddNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNews.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNews.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddNews.Location = new System.Drawing.Point(700, 118);
            this.AddNews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddNews.Name = "AddNews";
            this.AddNews.Size = new System.Drawing.Size(82, 25);
            this.AddNews.TabIndex = 82;
            this.AddNews.Text = "Confirm";
            this.AddNews.UseVisualStyleBackColor = false;
            this.AddNews.Click += new System.EventHandler(this.AddNews_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(19, 232);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(223, 104);
            this.label15.TabIndex = 81;
            this.label15.Text = "OR\r\n\r\nYou can delete one\r\n\r\n";
            // 
            // NewsTextBox
            // 
            this.NewsTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewsTextBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsTextBox.Location = new System.Drawing.Point(416, 23);
            this.NewsTextBox.Multiline = true;
            this.NewsTextBox.Name = "NewsTextBox";
            this.NewsTextBox.Size = new System.Drawing.Size(366, 79);
            this.NewsTextBox.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(19, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(392, 78);
            this.label14.TabIndex = 69;
            this.label14.Text = "                You\'re the Boss\r\n\r\nYou can enter any updates or news\r\n";
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewsPanel);
            this.Controls.Add(this.AddTripPanel);
            this.Controls.Add(this.AddTrainPanel);
            this.Controls.Add(this.RescheduleTrainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerView";
            this.Text = "Modern Railways: Manager";
            this.Load += new System.EventHandler(this.ManagerView_Load);
            this.panel1.ResumeLayout(false);
            this.AddTrainPanel.ResumeLayout(false);
            this.AddTrainPanel.PerformLayout();
            this.RescheduleTrainPanel.ResumeLayout(false);
            this.RescheduleTrainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainTables)).EndInit();
            this.AddTripPanel.ResumeLayout(false);
            this.AddTripPanel.PerformLayout();
            this.NewsPanel.ResumeLayout(false);
            this.NewsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railWayStationDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManageTrips;
        private System.Windows.Forms.Button ManageNews;
        private System.Windows.Forms.Button RescheduleTrains;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button AddTrains;
        private System.Windows.Forms.Panel AddTrainPanel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label AddTrainID;
        private System.Windows.Forms.MaskedTextBox PassIDWarn;
        private System.Windows.Forms.Button AddTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TripIDassign;
        private System.Windows.Forms.ComboBox TrainIDassign;
        private System.Windows.Forms.Button assignbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel RescheduleTrainPanel;
        private System.Windows.Forms.DateTimePicker EndSericeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker StartSerivceTrain;
        private System.Windows.Forms.DataGridView TrainTables;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmReplace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel AddTripPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ArrivalStation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DepStation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TripIDAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel NewsPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NewsTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button AddNews;
        private System.Windows.Forms.DataGridView NewsDataGrid;
        private System.Windows.Forms.Button button2;
        private RailWayStationDataSet10 railWayStationDataSet10;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private RailWayStationDataSet10TableAdapters.ManagerTableAdapter managerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsUpdatesDataGridViewTextBoxColumn;
    }
}