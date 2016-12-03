namespace kursach
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.seeNextGenBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.num1Lbl = new System.Windows.Forms.Label();
            this.generationLbl = new System.Windows.Forms.Label();
            this.generationHeaderLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1HeaderLbl = new System.Windows.Forms.Label();
            this.fieldDataGridView = new System.Windows.Forms.DataGridView();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDataGridView)).BeginInit();
            this.gridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.seeNextGenBtn);
            this.panel1.Controls.Add(this.pauseBtn);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Location = new System.Drawing.Point(681, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 167);
            this.panel1.TabIndex = 0;
            // 
            // seeNextGenBtn
            // 
            this.seeNextGenBtn.Location = new System.Drawing.Point(42, 105);
            this.seeNextGenBtn.Name = "seeNextGenBtn";
            this.seeNextGenBtn.Size = new System.Drawing.Size(150, 23);
            this.seeNextGenBtn.TabIndex = 2;
            this.seeNextGenBtn.Text = "See next generation";
            this.seeNextGenBtn.UseVisualStyleBackColor = true;
            this.seeNextGenBtn.Click += new System.EventHandler(this.seeNextGenBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(42, 66);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(150, 23);
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.Location = new System.Drawing.Point(42, 19);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(150, 23);
            this.continueBtn.TabIndex = 0;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // schedulePanel
            // 
            this.schedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedulePanel.Controls.Add(this.num1Lbl);
            this.schedulePanel.Controls.Add(this.generationLbl);
            this.schedulePanel.Controls.Add(this.generationHeaderLbl);
            this.schedulePanel.Controls.Add(this.label8);
            this.schedulePanel.Controls.Add(this.label7);
            this.schedulePanel.Controls.Add(this.label6);
            this.schedulePanel.Controls.Add(this.label5);
            this.schedulePanel.Controls.Add(this.label4);
            this.schedulePanel.Controls.Add(this.label3);
            this.schedulePanel.Controls.Add(this.label2);
            this.schedulePanel.Controls.Add(this.num1HeaderLbl);
            this.schedulePanel.Location = new System.Drawing.Point(12, 458);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(662, 167);
            this.schedulePanel.TabIndex = 2;
            // 
            // num1Lbl
            // 
            this.num1Lbl.Location = new System.Drawing.Point(148, 53);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.Size = new System.Drawing.Size(100, 23);
            this.num1Lbl.TabIndex = 10;
            this.num1Lbl.Text = "default";
            // 
            // generationLbl
            // 
            this.generationLbl.AutoSize = true;
            this.generationLbl.Location = new System.Drawing.Point(287, 19);
            this.generationLbl.Name = "generationLbl";
            this.generationLbl.Size = new System.Drawing.Size(39, 13);
            this.generationLbl.TabIndex = 9;
            this.generationLbl.Text = "default";
            // 
            // generationHeaderLbl
            // 
            this.generationHeaderLbl.AutoSize = true;
            this.generationHeaderLbl.Location = new System.Drawing.Point(202, 19);
            this.generationHeaderLbl.Name = "generationHeaderLbl";
            this.generationHeaderLbl.Size = new System.Drawing.Size(59, 13);
            this.generationHeaderLbl.TabIndex = 8;
            this.generationHeaderLbl.Text = "Generation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // num1HeaderLbl
            // 
            this.num1HeaderLbl.AutoSize = true;
            this.num1HeaderLbl.Location = new System.Drawing.Point(30, 53);
            this.num1HeaderLbl.Name = "num1HeaderLbl";
            this.num1HeaderLbl.Size = new System.Drawing.Size(59, 13);
            this.num1HeaderLbl.TabIndex = 0;
            this.num1HeaderLbl.Text = "Number 1 :";
            // 
            // fieldDataGridView
            // 
            this.fieldDataGridView.AllowUserToAddRows = false;
            this.fieldDataGridView.AllowUserToResizeColumns = false;
            this.fieldDataGridView.AllowUserToResizeRows = false;
            this.fieldDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldDataGridView.ColumnHeadersVisible = false;
            this.fieldDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fieldDataGridView.Location = new System.Drawing.Point(3, 3);
            this.fieldDataGridView.Name = "fieldDataGridView";
            this.fieldDataGridView.RowHeadersVisible = false;
            this.fieldDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fieldDataGridView.Size = new System.Drawing.Size(890, 417);
            this.fieldDataGridView.TabIndex = 0;
            // 
            // gridPanel
            // 
            this.gridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel.Controls.Add(this.fieldDataGridView);
            this.gridPanel.Location = new System.Drawing.Point(12, 13);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(914, 439);
            this.gridPanel.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 637);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDataGridView)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button seeNextGenBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label num1HeaderLbl;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView fieldDataGridView;
        private System.Windows.Forms.Label generationHeaderLbl;
        private System.Windows.Forms.Label generationLbl;
        private System.Windows.Forms.Label num1Lbl;
    }
}