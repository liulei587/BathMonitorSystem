namespace BathMonitorSystem
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pl_Top = new System.Windows.Forms.Panel();
            this.lbl_CurrentUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_CurrentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pl_Left = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTrend = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnParamSet = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblTrend = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblParamSet = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.pl_Right = new System.Windows.Forms.Panel();
            this.pl_Bottom = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.pl_Left.SuspendLayout();
            this.pl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pl_Top);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 768);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // pl_Top
            // 
            this.pl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pl_Top.Controls.Add(this.btnClose);
            this.pl_Top.Controls.Add(this.lbl_CurrentUser);
            this.pl_Top.Controls.Add(this.label4);
            this.pl_Top.Controls.Add(this.lbl_CurrentTime);
            this.pl_Top.Controls.Add(this.label3);
            this.pl_Top.Controls.Add(this.label2);
            this.pl_Top.Controls.Add(this.label1);
            this.pl_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Top.Location = new System.Drawing.Point(0, 0);
            this.pl_Top.Name = "pl_Top";
            this.pl_Top.Size = new System.Drawing.Size(1280, 65);
            this.pl_Top.TabIndex = 0;
            // 
            // lbl_CurrentUser
            // 
            this.lbl_CurrentUser.AutoSize = true;
            this.lbl_CurrentUser.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CurrentUser.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentUser.Location = new System.Drawing.Point(1083, 38);
            this.lbl_CurrentUser.Name = "lbl_CurrentUser";
            this.lbl_CurrentUser.Size = new System.Drawing.Size(72, 20);
            this.lbl_CurrentUser.TabIndex = 0;
            this.lbl_CurrentUser.Text = "管理员";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(899, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "当前用户：";
            // 
            // lbl_CurrentTime
            // 
            this.lbl_CurrentTime.AutoSize = true;
            this.lbl_CurrentTime.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CurrentTime.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentTime.Location = new System.Drawing.Point(1009, 9);
            this.lbl_CurrentTime.Name = "lbl_CurrentTime";
            this.lbl_CurrentTime.Size = new System.Drawing.Size(195, 20);
            this.lbl_CurrentTime.TabIndex = 0;
            this.lbl_CurrentTime.Text = "2018-12-12 16：16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(899, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "当前时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(128)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QTouch";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pl_Bottom);
            this.splitContainer2.Size = new System.Drawing.Size(1280, 702);
            this.splitContainer2.SplitterDistance = 654;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pl_Left);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pl_Right);
            this.splitContainer3.Size = new System.Drawing.Size(1280, 654);
            this.splitContainer3.SplitterDistance = 147;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // pl_Left
            // 
            this.pl_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.pl_Left.Controls.Add(this.btnExit);
            this.pl_Left.Controls.Add(this.btnReport);
            this.pl_Left.Controls.Add(this.btnTrend);
            this.pl_Left.Controls.Add(this.btnAlarm);
            this.pl_Left.Controls.Add(this.btnParamSet);
            this.pl_Left.Controls.Add(this.btnProcess);
            this.pl_Left.Controls.Add(this.btnView);
            this.pl_Left.Controls.Add(this.lblTrend);
            this.pl_Left.Controls.Add(this.lblReport);
            this.pl_Left.Controls.Add(this.label10);
            this.pl_Left.Controls.Add(this.lblAlarm);
            this.pl_Left.Controls.Add(this.lblParamSet);
            this.pl_Left.Controls.Add(this.lblProcess);
            this.pl_Left.Controls.Add(this.lblView);
            this.pl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Left.Location = new System.Drawing.Point(0, 0);
            this.pl_Left.Name = "pl_Left";
            this.pl_Left.Size = new System.Drawing.Size(147, 654);
            this.pl_Left.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Image = global::BathMonitorSystem.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(62, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 72);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnReport.BackgroundImage = global::BathMonitorSystem.Properties.Resources.folder_documents;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Location = new System.Drawing.Point(62, 481);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(72, 72);
            this.btnReport.TabIndex = 2;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTrend
            // 
            this.btnTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnTrend.BackgroundImage = global::BathMonitorSystem.Properties.Resources.trends;
            this.btnTrend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrend.Location = new System.Drawing.Point(62, 389);
            this.btnTrend.Name = "btnTrend";
            this.btnTrend.Size = new System.Drawing.Size(72, 72);
            this.btnTrend.TabIndex = 2;
            this.btnTrend.UseVisualStyleBackColor = false;
            this.btnTrend.Click += new System.EventHandler(this.btnTrend_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlarm.Image = global::BathMonitorSystem.Properties.Resources.bolt;
            this.btnAlarm.Location = new System.Drawing.Point(62, 297);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(72, 72);
            this.btnAlarm.TabIndex = 2;
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnParamSet
            // 
            this.btnParamSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnParamSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParamSet.Image = global::BathMonitorSystem.Properties.Resources.set;
            this.btnParamSet.Location = new System.Drawing.Point(62, 205);
            this.btnParamSet.Name = "btnParamSet";
            this.btnParamSet.Size = new System.Drawing.Size(72, 72);
            this.btnParamSet.TabIndex = 2;
            this.btnParamSet.UseVisualStyleBackColor = false;
            this.btnParamSet.Click += new System.EventHandler(this.btnParamSet_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnProcess.BackgroundImage = global::BathMonitorSystem.Properties.Resources.controls;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcess.Location = new System.Drawing.Point(62, 113);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(72, 72);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.Image = global::BathMonitorSystem.Properties.Resources.desktop;
            this.btnView.Location = new System.Drawing.Point(62, 21);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(72, 72);
            this.btnView.TabIndex = 2;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblTrend
            // 
            this.lblTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblTrend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTrend.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTrend.Location = new System.Drawing.Point(8, 374);
            this.lblTrend.Name = "lblTrend";
            this.lblTrend.Size = new System.Drawing.Size(39, 88);
            this.lblTrend.TabIndex = 2;
            this.lblTrend.Text = "趋势曲线";
            this.lblTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReport
            // 
            this.lblReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblReport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReport.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblReport.Location = new System.Drawing.Point(8, 466);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(39, 88);
            this.lblReport.TabIndex = 3;
            this.lblReport.Text = "数据报表";
            this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(8, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 88);
            this.label10.TabIndex = 0;
            this.label10.Text = "退出";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarm
            // 
            this.lblAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblAlarm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAlarm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAlarm.Location = new System.Drawing.Point(8, 282);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(39, 88);
            this.lblAlarm.TabIndex = 0;
            this.lblAlarm.Text = "故障报警";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParamSet
            // 
            this.lblParamSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblParamSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblParamSet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblParamSet.Location = new System.Drawing.Point(8, 190);
            this.lblParamSet.Name = "lblParamSet";
            this.lblParamSet.Size = new System.Drawing.Size(39, 88);
            this.lblParamSet.TabIndex = 0;
            this.lblParamSet.Text = "参数设置";
            this.lblParamSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcess
            // 
            this.lblProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblProcess.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProcess.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProcess.Location = new System.Drawing.Point(8, 98);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(39, 88);
            this.lblProcess.TabIndex = 0;
            this.lblProcess.Text = "控制流程";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblView
            // 
            this.lblView.BackColor = System.Drawing.Color.Green;
            this.lblView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblView.Location = new System.Drawing.Point(8, 6);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(39, 88);
            this.lblView.TabIndex = 0;
            this.lblView.Text = "集中监控";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_Right
            // 
            this.pl_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.pl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Right.Location = new System.Drawing.Point(0, 0);
            this.pl_Right.Name = "pl_Right";
            this.pl_Right.Size = new System.Drawing.Size(1132, 654);
            this.pl_Right.TabIndex = 0;
            // 
            // pl_Bottom
            // 
            this.pl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pl_Bottom.Controls.Add(this.label5);
            this.pl_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Bottom.Location = new System.Drawing.Point(0, 0);
            this.pl_Bottom.Name = "pl_Bottom";
            this.pl_Bottom.Size = new System.Drawing.Size(1280, 47);
            this.pl_Bottom.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1280, 47);
            this.label5.TabIndex = 0;
            this.label5.Text = "LL版权所有";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1222, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pl_Top.ResumeLayout(false);
            this.pl_Top.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.pl_Left.ResumeLayout(false);
            this.pl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pl_Top;
        private System.Windows.Forms.Label lbl_CurrentUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_CurrentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel pl_Left;
        private System.Windows.Forms.Panel pl_Right;
        private System.Windows.Forms.Panel pl_Bottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblParamSet;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblTrend;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTrend;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnParamSet;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClose;
    }
}

