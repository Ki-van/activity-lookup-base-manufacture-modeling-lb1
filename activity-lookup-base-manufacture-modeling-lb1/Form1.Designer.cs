
namespace activity_lookup_base_manufacture_modeling_lb1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbGuild = new System.Windows.Forms.Label();
            this.lbGuildStorage = new System.Windows.Forms.Label();
            this.lbCenterStorage = new System.Windows.Forms.Label();
            this.dgvModelingProtocol = new System.Windows.Forms.DataGridView();
            this.colModelTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldetailsOnRoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuildStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udN1 = new System.Windows.Forms.NumericUpDown();
            this.lbN1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.udN2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.udN3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.udN4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.udt1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.udt2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.udt3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.udt4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.udImmitationSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabIndicators = new System.Windows.Forms.TabPage();
            this.lbAvgLoad = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbProbobility = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbIncomingCaret = new System.Windows.Forms.Label();
            this.lbOutcomingCaret = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelingProtocol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udImmitationSpeed)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabIndicators.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGuild
            // 
            this.lbGuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGuild.Location = new System.Drawing.Point(602, 95);
            this.lbGuild.Name = "lbGuild";
            this.lbGuild.Size = new System.Drawing.Size(124, 82);
            this.lbGuild.TabIndex = 0;
            this.lbGuild.Text = "Цех";
            this.lbGuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGuildStorage
            // 
            this.lbGuildStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGuildStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGuildStorage.Location = new System.Drawing.Point(602, 13);
            this.lbGuildStorage.Name = "lbGuildStorage";
            this.lbGuildStorage.Size = new System.Drawing.Size(124, 82);
            this.lbGuildStorage.TabIndex = 1;
            this.lbGuildStorage.Text = "Цеховой склад";
            this.lbGuildStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCenterStorage
            // 
            this.lbCenterStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCenterStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCenterStorage.Location = new System.Drawing.Point(883, 13);
            this.lbCenterStorage.Name = "lbCenterStorage";
            this.lbCenterStorage.Size = new System.Drawing.Size(124, 82);
            this.lbCenterStorage.TabIndex = 2;
            this.lbCenterStorage.Text = "Центральный склад";
            this.lbCenterStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvModelingProtocol
            // 
            this.dgvModelingProtocol.AllowUserToAddRows = false;
            this.dgvModelingProtocol.AllowUserToDeleteRows = false;
            this.dgvModelingProtocol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelingProtocol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModelTime,
            this.colN1,
            this.ColModelEvent,
            this.coldetailsOnRoad,
            this.colGuildStatus});
            this.dgvModelingProtocol.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvModelingProtocol.Location = new System.Drawing.Point(0, 0);
            this.dgvModelingProtocol.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.dgvModelingProtocol.Name = "dgvModelingProtocol";
            this.dgvModelingProtocol.ReadOnly = true;
            this.dgvModelingProtocol.ShowEditingIcon = false;
            this.dgvModelingProtocol.Size = new System.Drawing.Size(571, 496);
            this.dgvModelingProtocol.TabIndex = 4;
            // 
            // colModelTime
            // 
            this.colModelTime.HeaderText = "Модельное время";
            this.colModelTime.Name = "colModelTime";
            this.colModelTime.ReadOnly = true;
            // 
            // colN1
            // 
            this.colN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colN1.HeaderText = "N1";
            this.colN1.Name = "colN1";
            this.colN1.ReadOnly = true;
            this.colN1.Width = 46;
            // 
            // ColModelEvent
            // 
            this.ColModelEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColModelEvent.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColModelEvent.HeaderText = "События";
            this.ColModelEvent.Name = "ColModelEvent";
            this.ColModelEvent.ReadOnly = true;
            this.ColModelEvent.Width = 76;
            // 
            // coldetailsOnRoad
            // 
            this.coldetailsOnRoad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldetailsOnRoad.HeaderText = "Деталей в дороге";
            this.coldetailsOnRoad.Name = "coldetailsOnRoad";
            this.coldetailsOnRoad.ReadOnly = true;
            this.coldetailsOnRoad.Width = 81;
            // 
            // colGuildStatus
            // 
            this.colGuildStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGuildStatus.HeaderText = "Состояние цеха";
            this.colGuildStatus.Name = "colGuildStatus";
            this.colGuildStatus.ReadOnly = true;
            // 
            // udN1
            // 
            this.udN1.AutoSize = true;
            this.udN1.Location = new System.Drawing.Point(33, 1);
            this.udN1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udN1.Name = "udN1";
            this.udN1.Size = new System.Drawing.Size(44, 20);
            this.udN1.TabIndex = 5;
            this.udN1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.udN1.ValueChanged += new System.EventHandler(this.udN1_ValueChanged);
            // 
            // lbN1
            // 
            this.lbN1.AutoSize = true;
            this.lbN1.Location = new System.Drawing.Point(6, 3);
            this.lbN1.Name = "lbN1";
            this.lbN1.Size = new System.Drawing.Size(24, 13);
            this.lbN1.TabIndex = 6;
            this.lbN1.Text = "N1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "N2:";
            // 
            // udN2
            // 
            this.udN2.AutoSize = true;
            this.udN2.Location = new System.Drawing.Point(33, 27);
            this.udN2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udN2.Name = "udN2";
            this.udN2.Size = new System.Drawing.Size(44, 20);
            this.udN2.TabIndex = 7;
            this.udN2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udN2.ValueChanged += new System.EventHandler(this.udN2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "N3:";
            // 
            // udN3
            // 
            this.udN3.AutoSize = true;
            this.udN3.Location = new System.Drawing.Point(33, 53);
            this.udN3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udN3.Name = "udN3";
            this.udN3.Size = new System.Drawing.Size(44, 20);
            this.udN3.TabIndex = 9;
            this.udN3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udN3.ValueChanged += new System.EventHandler(this.udN3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "N4:";
            // 
            // udN4
            // 
            this.udN4.AutoSize = true;
            this.udN4.Location = new System.Drawing.Point(33, 79);
            this.udN4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udN4.Name = "udN4";
            this.udN4.Size = new System.Drawing.Size(44, 20);
            this.udN4.TabIndex = 11;
            this.udN4.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.udN4.ValueChanged += new System.EventHandler(this.udN4_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "t1:";
            // 
            // udt1
            // 
            this.udt1.AutoSize = true;
            this.udt1.Location = new System.Drawing.Point(123, 1);
            this.udt1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udt1.Name = "udt1";
            this.udt1.Size = new System.Drawing.Size(44, 20);
            this.udt1.TabIndex = 13;
            this.udt1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udt1.ValueChanged += new System.EventHandler(this.udt1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "t2:";
            // 
            // udt2
            // 
            this.udt2.AutoSize = true;
            this.udt2.Location = new System.Drawing.Point(123, 27);
            this.udt2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udt2.Name = "udt2";
            this.udt2.Size = new System.Drawing.Size(44, 20);
            this.udt2.TabIndex = 15;
            this.udt2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udt2.ValueChanged += new System.EventHandler(this.udt2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "t3:";
            // 
            // udt3
            // 
            this.udt3.AutoSize = true;
            this.udt3.Location = new System.Drawing.Point(123, 53);
            this.udt3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udt3.Name = "udt3";
            this.udt3.Size = new System.Drawing.Size(44, 20);
            this.udt3.TabIndex = 17;
            this.udt3.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udt3.ValueChanged += new System.EventHandler(this.udt3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "t4:";
            // 
            // udt4
            // 
            this.udt4.AutoSize = true;
            this.udt4.Location = new System.Drawing.Point(123, 79);
            this.udt4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udt4.Name = "udt4";
            this.udt4.Size = new System.Drawing.Size(44, 20);
            this.udt4.TabIndex = 19;
            this.udt4.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.udt4.ValueChanged += new System.EventHandler(this.udt4_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Скорость имитации:";
            // 
            // udImmitationSpeed
            // 
            this.udImmitationSpeed.AutoSize = true;
            this.udImmitationSpeed.Location = new System.Drawing.Point(122, 117);
            this.udImmitationSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udImmitationSpeed.Name = "udImmitationSpeed";
            this.udImmitationSpeed.Size = new System.Drawing.Size(44, 20);
            this.udImmitationSpeed.TabIndex = 22;
            this.udImmitationSpeed.ValueChanged += new System.EventHandler(this.udImmitationSpeed_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "сек/4/такт";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(931, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Транспортные расходы:";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabIndicators);
            this.tabs.Location = new System.Drawing.Point(577, 244);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(431, 213);
            this.tabs.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbN1);
            this.tabPage1.Controls.Add(this.udN1);
            this.tabPage1.Controls.Add(this.udN2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.udImmitationSpeed);
            this.tabPage1.Controls.Add(this.udN3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.udN4);
            this.tabPage1.Controls.Add(this.udt4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.udt1);
            this.tabPage1.Controls.Add(this.udt3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.udt2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabIndicators
            // 
            this.tabIndicators.Controls.Add(this.lbAvgLoad);
            this.tabIndicators.Controls.Add(this.label12);
            this.tabIndicators.Controls.Add(this.lbProbobility);
            this.tabIndicators.Controls.Add(this.label11);
            this.tabIndicators.Controls.Add(this.lbCost);
            this.tabIndicators.Controls.Add(this.label10);
            this.tabIndicators.Location = new System.Drawing.Point(4, 22);
            this.tabIndicators.Name = "tabIndicators";
            this.tabIndicators.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndicators.Size = new System.Drawing.Size(423, 187);
            this.tabIndicators.TabIndex = 1;
            this.tabIndicators.Text = "Показатели работы";
            this.tabIndicators.UseVisualStyleBackColor = true;
            this.tabIndicators.Click += new System.EventHandler(this.tabIndicators_Click);
            // 
            // lbAvgLoad
            // 
            this.lbAvgLoad.AutoSize = true;
            this.lbAvgLoad.Location = new System.Drawing.Point(202, 49);
            this.lbAvgLoad.Name = "lbAvgLoad";
            this.lbAvgLoad.Size = new System.Drawing.Size(13, 13);
            this.lbAvgLoad.TabIndex = 30;
            this.lbAvgLoad.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Средняя загрузка цехового склада:";
            // 
            // lbProbobility
            // 
            this.lbProbobility.AutoSize = true;
            this.lbProbobility.Location = new System.Drawing.Point(202, 26);
            this.lbProbobility.Name = "lbProbobility";
            this.lbProbobility.Size = new System.Drawing.Size(13, 13);
            this.lbProbobility.TabIndex = 28;
            this.lbProbobility.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Вероятность простоя цеха: ";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(202, 3);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(13, 13);
            this.lbCost.TabIndex = 26;
            this.lbCost.Text = "0";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbIncomingCaret
            // 
            this.lbIncomingCaret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIncomingCaret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIncomingCaret.Location = new System.Drawing.Point(732, 13);
            this.lbIncomingCaret.Name = "lbIncomingCaret";
            this.lbIncomingCaret.Size = new System.Drawing.Size(40, 40);
            this.lbIncomingCaret.TabIndex = 27;
            this.lbIncomingCaret.Text = "80";
            this.lbIncomingCaret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIncomingCaret.Visible = false;
            // 
            // lbOutcomingCaret
            // 
            this.lbOutcomingCaret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOutcomingCaret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOutcomingCaret.Location = new System.Drawing.Point(732, 55);
            this.lbOutcomingCaret.Name = "lbOutcomingCaret";
            this.lbOutcomingCaret.Size = new System.Drawing.Size(40, 40);
            this.lbOutcomingCaret.TabIndex = 28;
            this.lbOutcomingCaret.Text = "53";
            this.lbOutcomingCaret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOutcomingCaret.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 496);
            this.Controls.Add(this.lbOutcomingCaret);
            this.Controls.Add(this.lbIncomingCaret);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvModelingProtocol);
            this.Controls.Add(this.lbCenterStorage);
            this.Controls.Add(this.lbGuildStorage);
            this.Controls.Add(this.lbGuild);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelingProtocol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udN4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udImmitationSpeed)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabIndicators.ResumeLayout(false);
            this.tabIndicators.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGuild;
        private System.Windows.Forms.Label lbGuildStorage;
        private System.Windows.Forms.Label lbCenterStorage;
        private System.Windows.Forms.DataGridView dgvModelingProtocol;
        private System.Windows.Forms.NumericUpDown udN1;
        private System.Windows.Forms.Label lbN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udN3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udN4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown udt2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown udt3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udt4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown udImmitationSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldetailsOnRoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuildStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabIndicators;
        private System.Windows.Forms.Label lbAvgLoad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbProbobility;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbIncomingCaret;
        private System.Windows.Forms.Label lbOutcomingCaret;
    }
}

