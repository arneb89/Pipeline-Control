namespace Control
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plotOrdIdent = new NPlot.Windows.PlotSurface2D();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cbOrdIdent_IdentOrders = new System.Windows.Forms.CheckBox();
            this.cbOrdIdent_OrdPos = new System.Windows.Forms.CheckBox();
            this.btnOrdIdent_RefreshPlot = new System.Windows.Forms.Button();
            this.btnOrdIdent_LoadData = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTracing_Refresh = new System.Windows.Forms.Button();
            this.btnTracing_LoadData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTracing_Ord2 = new System.Windows.Forms.TextBox();
            this.txtTracing_Ord1 = new System.Windows.Forms.TextBox();
            this.cbTracing_MinimaFitting = new System.Windows.Forms.CheckBox();
            this.cbTracing_OrdersFitting = new System.Windows.Forms.CheckBox();
            this.cbTrcing_MinimaTracing = new System.Windows.Forms.CheckBox();
            this.cbTracing_OrdersTracing = new System.Windows.Forms.CheckBox();
            this.plotTracing = new NPlot.Windows.PlotSurface2D();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbFlatOrdersFit = new System.Windows.Forms.CheckBox();
            this.cbFlatNorm = new System.Windows.Forms.CheckBox();
            this.cbFlatOrders = new System.Windows.Forms.CheckBox();
            this.lbFlatOrders = new System.Windows.Forms.ListBox();
            this.btnLoadFlatNormData = new System.Windows.Forms.Button();
            this.plotFlatNorm = new NPlot.Windows.PlotSurface2D();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSelectOrder = new System.Windows.Forms.CheckBox();
            this.rbDeviations = new System.Windows.Forms.RadioButton();
            this.rbDispCurve = new System.Windows.Forms.RadioButton();
            this.rbRepers = new System.Windows.Forms.RadioButton();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.btnRepers = new System.Windows.Forms.Button();
            this.plotWL = new NPlot.Windows.PlotSurface2D();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.rbOrders = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.plotOrdIdent);
            this.tabPage1.Controls.Add(this.groupBox);
            this.tabPage1.Controls.Add(this.btnOrdIdent_RefreshPlot);
            this.tabPage1.Controls.Add(this.btnOrdIdent_LoadData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ORD_IDENT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // plotOrdIdent
            // 
            this.plotOrdIdent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plotOrdIdent.AutoScaleAutoGeneratedAxes = false;
            this.plotOrdIdent.AutoScaleTitle = false;
            this.plotOrdIdent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotOrdIdent.DateTimeToolTip = false;
            this.plotOrdIdent.Legend = null;
            this.plotOrdIdent.LegendZOrder = -1;
            this.plotOrdIdent.Location = new System.Drawing.Point(127, 6);
            this.plotOrdIdent.Name = "plotOrdIdent";
            this.plotOrdIdent.RightMenu = null;
            this.plotOrdIdent.ShowCoordinates = true;
            this.plotOrdIdent.Size = new System.Drawing.Size(872, 507);
            this.plotOrdIdent.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plotOrdIdent.TabIndex = 4;
            this.plotOrdIdent.Text = "plotSurface2D1";
            this.plotOrdIdent.Title = "";
            this.plotOrdIdent.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plotOrdIdent.XAxis1 = null;
            this.plotOrdIdent.XAxis2 = null;
            this.plotOrdIdent.YAxis1 = null;
            this.plotOrdIdent.YAxis2 = null;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.cbOrdIdent_IdentOrders);
            this.groupBox.Controls.Add(this.cbOrdIdent_OrdPos);
            this.groupBox.Location = new System.Drawing.Point(6, 63);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(115, 69);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Pointers";
            // 
            // cbOrdIdent_IdentOrders
            // 
            this.cbOrdIdent_IdentOrders.AutoSize = true;
            this.cbOrdIdent_IdentOrders.Location = new System.Drawing.Point(6, 42);
            this.cbOrdIdent_IdentOrders.Name = "cbOrdIdent_IdentOrders";
            this.cbOrdIdent_IdentOrders.Size = new System.Drawing.Size(84, 17);
            this.cbOrdIdent_IdentOrders.TabIndex = 4;
            this.cbOrdIdent_IdentOrders.Text = "Ident Orders";
            this.cbOrdIdent_IdentOrders.UseVisualStyleBackColor = true;
            // 
            // cbOrdIdent_OrdPos
            // 
            this.cbOrdIdent_OrdPos.AutoSize = true;
            this.cbOrdIdent_OrdPos.Location = new System.Drawing.Point(6, 19);
            this.cbOrdIdent_OrdPos.Name = "cbOrdIdent_OrdPos";
            this.cbOrdIdent_OrdPos.Size = new System.Drawing.Size(102, 17);
            this.cbOrdIdent_OrdPos.TabIndex = 3;
            this.cbOrdIdent_OrdPos.Text = "Orders Positions";
            this.cbOrdIdent_OrdPos.UseVisualStyleBackColor = true;
            // 
            // btnOrdIdent_RefreshPlot
            // 
            this.btnOrdIdent_RefreshPlot.Location = new System.Drawing.Point(6, 138);
            this.btnOrdIdent_RefreshPlot.Name = "btnOrdIdent_RefreshPlot";
            this.btnOrdIdent_RefreshPlot.Size = new System.Drawing.Size(115, 54);
            this.btnOrdIdent_RefreshPlot.TabIndex = 1;
            this.btnOrdIdent_RefreshPlot.Text = "Refresh Plot";
            this.btnOrdIdent_RefreshPlot.UseVisualStyleBackColor = true;
            this.btnOrdIdent_RefreshPlot.Click += new System.EventHandler(this.btnOrdIdent_RefreshPlot_Click);
            // 
            // btnOrdIdent_LoadData
            // 
            this.btnOrdIdent_LoadData.Location = new System.Drawing.Point(6, 6);
            this.btnOrdIdent_LoadData.Name = "btnOrdIdent_LoadData";
            this.btnOrdIdent_LoadData.Size = new System.Drawing.Size(115, 51);
            this.btnOrdIdent_LoadData.TabIndex = 0;
            this.btnOrdIdent_LoadData.Text = "Load Data";
            this.btnOrdIdent_LoadData.UseVisualStyleBackColor = true;
            this.btnOrdIdent_LoadData.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTracing_Refresh);
            this.tabPage2.Controls.Add(this.btnTracing_LoadData);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.plotTracing);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1005, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TRACING";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTracing_Refresh
            // 
            this.btnTracing_Refresh.Location = new System.Drawing.Point(6, 200);
            this.btnTracing_Refresh.Name = "btnTracing_Refresh";
            this.btnTracing_Refresh.Size = new System.Drawing.Size(133, 42);
            this.btnTracing_Refresh.TabIndex = 6;
            this.btnTracing_Refresh.Text = "Refresh";
            this.btnTracing_Refresh.UseVisualStyleBackColor = true;
            this.btnTracing_Refresh.Click += new System.EventHandler(this.btnTracing_Refresh_Click);
            // 
            // btnTracing_LoadData
            // 
            this.btnTracing_LoadData.Location = new System.Drawing.Point(6, 10);
            this.btnTracing_LoadData.Name = "btnTracing_LoadData";
            this.btnTracing_LoadData.Size = new System.Drawing.Size(133, 42);
            this.btnTracing_LoadData.TabIndex = 5;
            this.btnTracing_LoadData.Text = "Load Data";
            this.btnTracing_LoadData.UseVisualStyleBackColor = true;
            this.btnTracing_LoadData.Click += new System.EventHandler(this.btnTracing_LoadData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTracing_Ord2);
            this.groupBox2.Controls.Add(this.txtTracing_Ord1);
            this.groupBox2.Controls.Add(this.cbTracing_MinimaFitting);
            this.groupBox2.Controls.Add(this.cbTracing_OrdersFitting);
            this.groupBox2.Controls.Add(this.cbTrcing_MinimaTracing);
            this.groupBox2.Controls.Add(this.cbTracing_OrdersTracing);
            this.groupBox2.Location = new System.Drawing.Point(6, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 136);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plotting Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "--";
            // 
            // txtTracing_Ord2
            // 
            this.txtTracing_Ord2.Location = new System.Drawing.Point(95, 19);
            this.txtTracing_Ord2.Name = "txtTracing_Ord2";
            this.txtTracing_Ord2.Size = new System.Drawing.Size(32, 20);
            this.txtTracing_Ord2.TabIndex = 9;
            // 
            // txtTracing_Ord1
            // 
            this.txtTracing_Ord1.Location = new System.Drawing.Point(48, 19);
            this.txtTracing_Ord1.Name = "txtTracing_Ord1";
            this.txtTracing_Ord1.Size = new System.Drawing.Size(32, 20);
            this.txtTracing_Ord1.TabIndex = 5;
            // 
            // cbTracing_MinimaFitting
            // 
            this.cbTracing_MinimaFitting.AutoSize = true;
            this.cbTracing_MinimaFitting.Location = new System.Drawing.Point(6, 114);
            this.cbTracing_MinimaFitting.Name = "cbTracing_MinimaFitting";
            this.cbTracing_MinimaFitting.Size = new System.Drawing.Size(90, 17);
            this.cbTracing_MinimaFitting.TabIndex = 8;
            this.cbTracing_MinimaFitting.Text = "Minima Fitting";
            this.cbTracing_MinimaFitting.UseVisualStyleBackColor = true;
            // 
            // cbTracing_OrdersFitting
            // 
            this.cbTracing_OrdersFitting.AutoSize = true;
            this.cbTracing_OrdersFitting.Location = new System.Drawing.Point(6, 91);
            this.cbTracing_OrdersFitting.Name = "cbTracing_OrdersFitting";
            this.cbTracing_OrdersFitting.Size = new System.Drawing.Size(88, 17);
            this.cbTracing_OrdersFitting.TabIndex = 7;
            this.cbTracing_OrdersFitting.Text = "Orders Fitting";
            this.cbTracing_OrdersFitting.UseVisualStyleBackColor = true;
            // 
            // cbTrcing_MinimaTracing
            // 
            this.cbTrcing_MinimaTracing.AutoSize = true;
            this.cbTrcing_MinimaTracing.Location = new System.Drawing.Point(6, 68);
            this.cbTrcing_MinimaTracing.Name = "cbTrcing_MinimaTracing";
            this.cbTrcing_MinimaTracing.Size = new System.Drawing.Size(98, 17);
            this.cbTrcing_MinimaTracing.TabIndex = 6;
            this.cbTrcing_MinimaTracing.Text = "Minima Tracing";
            this.cbTrcing_MinimaTracing.UseVisualStyleBackColor = true;
            // 
            // cbTracing_OrdersTracing
            // 
            this.cbTracing_OrdersTracing.AutoSize = true;
            this.cbTracing_OrdersTracing.Location = new System.Drawing.Point(6, 45);
            this.cbTracing_OrdersTracing.Name = "cbTracing_OrdersTracing";
            this.cbTracing_OrdersTracing.Size = new System.Drawing.Size(96, 17);
            this.cbTracing_OrdersTracing.TabIndex = 5;
            this.cbTracing_OrdersTracing.Text = "Orders Tracing";
            this.cbTracing_OrdersTracing.UseVisualStyleBackColor = true;
            // 
            // plotTracing
            // 
            this.plotTracing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plotTracing.AutoScaleAutoGeneratedAxes = false;
            this.plotTracing.AutoScaleTitle = false;
            this.plotTracing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotTracing.DateTimeToolTip = false;
            this.plotTracing.Legend = null;
            this.plotTracing.LegendZOrder = -1;
            this.plotTracing.Location = new System.Drawing.Point(145, 6);
            this.plotTracing.Name = "plotTracing";
            this.plotTracing.RightMenu = null;
            this.plotTracing.ShowCoordinates = true;
            this.plotTracing.Size = new System.Drawing.Size(854, 507);
            this.plotTracing.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plotTracing.TabIndex = 0;
            this.plotTracing.Text = "plotSurface2D1";
            this.plotTracing.Title = "";
            this.plotTracing.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plotTracing.XAxis1 = null;
            this.plotTracing.XAxis2 = null;
            this.plotTracing.YAxis1 = null;
            this.plotTracing.YAxis2 = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbFlatOrdersFit);
            this.tabPage3.Controls.Add(this.cbFlatNorm);
            this.tabPage3.Controls.Add(this.cbFlatOrders);
            this.tabPage3.Controls.Add(this.lbFlatOrders);
            this.tabPage3.Controls.Add(this.btnLoadFlatNormData);
            this.tabPage3.Controls.Add(this.plotFlatNorm);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1005, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FLAT NORM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbFlatOrdersFit
            // 
            this.cbFlatOrdersFit.AutoSize = true;
            this.cbFlatOrdersFit.Location = new System.Drawing.Point(6, 72);
            this.cbFlatOrdersFit.Name = "cbFlatOrdersFit";
            this.cbFlatOrdersFit.Size = new System.Drawing.Size(91, 17);
            this.cbFlatOrdersFit.TabIndex = 7;
            this.cbFlatOrdersFit.Text = "Flat Orders Fit";
            this.cbFlatOrdersFit.UseVisualStyleBackColor = true;
            // 
            // cbFlatNorm
            // 
            this.cbFlatNorm.AutoSize = true;
            this.cbFlatNorm.Location = new System.Drawing.Point(6, 95);
            this.cbFlatNorm.Name = "cbFlatNorm";
            this.cbFlatNorm.Size = new System.Drawing.Size(71, 17);
            this.cbFlatNorm.TabIndex = 6;
            this.cbFlatNorm.Text = "Norm Flat";
            this.cbFlatNorm.UseVisualStyleBackColor = true;
            // 
            // cbFlatOrders
            // 
            this.cbFlatOrders.AutoSize = true;
            this.cbFlatOrders.Location = new System.Drawing.Point(6, 49);
            this.cbFlatOrders.Name = "cbFlatOrders";
            this.cbFlatOrders.Size = new System.Drawing.Size(77, 17);
            this.cbFlatOrders.TabIndex = 5;
            this.cbFlatOrders.Text = "Flat Orders";
            this.cbFlatOrders.UseVisualStyleBackColor = true;
            // 
            // lbFlatOrders
            // 
            this.lbFlatOrders.FormattingEnabled = true;
            this.lbFlatOrders.Location = new System.Drawing.Point(6, 122);
            this.lbFlatOrders.Name = "lbFlatOrders";
            this.lbFlatOrders.Size = new System.Drawing.Size(96, 95);
            this.lbFlatOrders.TabIndex = 4;
            // 
            // btnLoadFlatNormData
            // 
            this.btnLoadFlatNormData.Location = new System.Drawing.Point(3, 6);
            this.btnLoadFlatNormData.Name = "btnLoadFlatNormData";
            this.btnLoadFlatNormData.Size = new System.Drawing.Size(99, 37);
            this.btnLoadFlatNormData.TabIndex = 3;
            this.btnLoadFlatNormData.Text = "Load Data";
            this.btnLoadFlatNormData.UseVisualStyleBackColor = true;
            this.btnLoadFlatNormData.Click += new System.EventHandler(this.btnLoadFlatNormData_Click);
            // 
            // plotFlatNorm
            // 
            this.plotFlatNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plotFlatNorm.AutoScaleAutoGeneratedAxes = false;
            this.plotFlatNorm.AutoScaleTitle = false;
            this.plotFlatNorm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotFlatNorm.DateTimeToolTip = false;
            this.plotFlatNorm.Legend = null;
            this.plotFlatNorm.LegendZOrder = -1;
            this.plotFlatNorm.Location = new System.Drawing.Point(108, 6);
            this.plotFlatNorm.Name = "plotFlatNorm";
            this.plotFlatNorm.RightMenu = null;
            this.plotFlatNorm.ShowCoordinates = true;
            this.plotFlatNorm.Size = new System.Drawing.Size(882, 507);
            this.plotFlatNorm.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plotFlatNorm.TabIndex = 2;
            this.plotFlatNorm.Text = "plotSurface2D1";
            this.plotFlatNorm.Title = "";
            this.plotFlatNorm.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plotFlatNorm.XAxis1 = null;
            this.plotFlatNorm.XAxis2 = null;
            this.plotFlatNorm.YAxis1 = null;
            this.plotFlatNorm.YAxis2 = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.lbOrders);
            this.tabPage4.Controls.Add(this.btnRepers);
            this.tabPage4.Controls.Add(this.plotWL);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1005, 519);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "WL_CALIBR";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrders);
            this.groupBox1.Controls.Add(this.cbSelectOrder);
            this.groupBox1.Controls.Add(this.rbDeviations);
            this.groupBox1.Controls.Add(this.rbDispCurve);
            this.groupBox1.Controls.Add(this.rbRepers);
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // cbSelectOrder
            // 
            this.cbSelectOrder.AutoSize = true;
            this.cbSelectOrder.Location = new System.Drawing.Point(35, 109);
            this.cbSelectOrder.Name = "cbSelectOrder";
            this.cbSelectOrder.Size = new System.Drawing.Size(85, 17);
            this.cbSelectOrder.TabIndex = 4;
            this.cbSelectOrder.Text = "Select Order";
            this.cbSelectOrder.UseVisualStyleBackColor = true;
            // 
            // rbDeviations
            // 
            this.rbDeviations.AutoSize = true;
            this.rbDeviations.Location = new System.Drawing.Point(6, 88);
            this.rbDeviations.Name = "rbDeviations";
            this.rbDeviations.Size = new System.Drawing.Size(75, 17);
            this.rbDeviations.TabIndex = 6;
            this.rbDeviations.Text = "Deviations";
            this.rbDeviations.UseVisualStyleBackColor = true;
            this.rbDeviations.CheckedChanged += new System.EventHandler(this.rbDeviations_CheckedChanged);
            // 
            // rbDispCurve
            // 
            this.rbDispCurve.AutoSize = true;
            this.rbDispCurve.Location = new System.Drawing.Point(6, 42);
            this.rbDispCurve.Name = "rbDispCurve";
            this.rbDispCurve.Size = new System.Drawing.Size(105, 17);
            this.rbDispCurve.TabIndex = 5;
            this.rbDispCurve.Text = "Dispersion Curve";
            this.rbDispCurve.UseVisualStyleBackColor = true;
            this.rbDispCurve.CheckedChanged += new System.EventHandler(this.rbDispCurve_CheckedChanged);
            // 
            // rbRepers
            // 
            this.rbRepers.AutoSize = true;
            this.rbRepers.Checked = true;
            this.rbRepers.Location = new System.Drawing.Point(6, 19);
            this.rbRepers.Name = "rbRepers";
            this.rbRepers.Size = new System.Drawing.Size(103, 17);
            this.rbRepers.TabIndex = 4;
            this.rbRepers.TabStop = true;
            this.rbRepers.Text = "Repers Location";
            this.rbRepers.UseVisualStyleBackColor = true;
            this.rbRepers.CheckedChanged += new System.EventHandler(this.rbRepers_CheckedChanged);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(6, 181);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(126, 95);
            this.lbOrders.TabIndex = 2;
            // 
            // btnRepers
            // 
            this.btnRepers.Location = new System.Drawing.Point(6, 6);
            this.btnRepers.Name = "btnRepers";
            this.btnRepers.Size = new System.Drawing.Size(126, 31);
            this.btnRepers.TabIndex = 1;
            this.btnRepers.Text = "Load Data";
            this.btnRepers.UseVisualStyleBackColor = true;
            this.btnRepers.Click += new System.EventHandler(this.btnRepers_Click);
            // 
            // plotWL
            // 
            this.plotWL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plotWL.AutoScaleAutoGeneratedAxes = false;
            this.plotWL.AutoScaleTitle = false;
            this.plotWL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotWL.DateTimeToolTip = false;
            this.plotWL.Legend = null;
            this.plotWL.LegendZOrder = -1;
            this.plotWL.Location = new System.Drawing.Point(138, 6);
            this.plotWL.Name = "plotWL";
            this.plotWL.RightMenu = null;
            this.plotWL.ShowCoordinates = true;
            this.plotWL.Size = new System.Drawing.Size(861, 507);
            this.plotWL.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plotWL.TabIndex = 0;
            this.plotWL.Text = "plotSurface2D1";
            this.plotWL.Title = "";
            this.plotWL.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plotWL.XAxis1 = null;
            this.plotWL.XAxis2 = null;
            this.plotWL.YAxis1 = null;
            this.plotWL.YAxis2 = null;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(12, 12);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(106, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(124, 14);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(901, 20);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.Text = "D:\\FITS_READER\\FITS_READER\\bin\\Debug";
            // 
            // rbOrders
            // 
            this.rbOrders.AutoSize = true;
            this.rbOrders.Location = new System.Drawing.Point(6, 65);
            this.rbOrders.Name = "rbOrders";
            this.rbOrders.Size = new System.Drawing.Size(56, 17);
            this.rbOrders.TabIndex = 7;
            this.rbOrders.Text = "Orders";
            this.rbOrders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 603);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PIPELINE CONTROL";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private NPlot.Windows.PlotSurface2D plotTracing;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRepers;
        private NPlot.Windows.PlotSurface2D plotWL;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.ListBox lbFlatOrders;
        private System.Windows.Forms.Button btnLoadFlatNormData;
        private NPlot.Windows.PlotSurface2D plotFlatNorm;
        private System.Windows.Forms.CheckBox cbFlatOrdersFit;
        private System.Windows.Forms.CheckBox cbFlatNorm;
        private System.Windows.Forms.CheckBox cbFlatOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDispCurve;
        private System.Windows.Forms.RadioButton rbRepers;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnOrdIdent_RefreshPlot;
        private System.Windows.Forms.Button btnOrdIdent_LoadData;
        private System.Windows.Forms.CheckBox cbOrdIdent_OrdPos;
        private System.Windows.Forms.CheckBox cbOrdIdent_IdentOrders;
        private NPlot.Windows.PlotSurface2D plotOrdIdent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTracing_Ord2;
        private System.Windows.Forms.TextBox txtTracing_Ord1;
        private System.Windows.Forms.CheckBox cbTracing_MinimaFitting;
        private System.Windows.Forms.CheckBox cbTracing_OrdersFitting;
        private System.Windows.Forms.CheckBox cbTrcing_MinimaTracing;
        private System.Windows.Forms.CheckBox cbTracing_OrdersTracing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTracing_Refresh;
        private System.Windows.Forms.Button btnTracing_LoadData;
        private System.Windows.Forms.RadioButton rbDeviations;
        private System.Windows.Forms.CheckBox cbSelectOrder;
        private System.Windows.Forms.RadioButton rbOrders;
    }
}

