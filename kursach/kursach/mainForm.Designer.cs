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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.seeNextGenBtn);
            this.panel1.Controls.Add(this.pauseBtn);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Location = new System.Drawing.Point(326, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 101);
            this.panel1.TabIndex = 0;
            // 
            // seeNextGenBtn
            // 
            this.seeNextGenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seeNextGenBtn.Location = new System.Drawing.Point(413, 19);
            this.seeNextGenBtn.Name = "seeNextGenBtn";
            this.seeNextGenBtn.Size = new System.Drawing.Size(150, 53);
            this.seeNextGenBtn.TabIndex = 2;
            this.seeNextGenBtn.Text = "See next generation";
            this.seeNextGenBtn.UseVisualStyleBackColor = true;
            this.seeNextGenBtn.Click += new System.EventHandler(this.seeNextGenBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseBtn.Location = new System.Drawing.Point(225, 19);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(150, 53);
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueBtn.Location = new System.Drawing.Point(42, 19);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(150, 53);
            this.continueBtn.TabIndex = 0;
            this.continueBtn.Text = "Start";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // schedulePanel
            // 
            this.schedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedulePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.schedulePanel.Controls.Add(this.num1Lbl);
            this.schedulePanel.Controls.Add(this.generationLbl);
            this.schedulePanel.Controls.Add(this.generationHeaderLbl);
            this.schedulePanel.Controls.Add(this.num1HeaderLbl);
            this.schedulePanel.Location = new System.Drawing.Point(12, 524);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(308, 101);
            this.schedulePanel.TabIndex = 2;
            // 
            // num1Lbl
            // 
            this.num1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1Lbl.Location = new System.Drawing.Point(161, 66);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.Size = new System.Drawing.Size(100, 23);
            this.num1Lbl.TabIndex = 10;
            this.num1Lbl.Text = "unknown";
            // 
            // generationLbl
            // 
            this.generationLbl.AutoSize = true;
            this.generationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generationLbl.Location = new System.Drawing.Point(161, 29);
            this.generationLbl.Name = "generationLbl";
            this.generationLbl.Size = new System.Drawing.Size(65, 20);
            this.generationLbl.TabIndex = 9;
            this.generationLbl.Text = "default";
            // 
            // generationHeaderLbl
            // 
            this.generationHeaderLbl.AutoSize = true;
            this.generationHeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generationHeaderLbl.Location = new System.Drawing.Point(16, 29);
            this.generationHeaderLbl.Name = "generationHeaderLbl";
            this.generationHeaderLbl.Size = new System.Drawing.Size(93, 20);
            this.generationHeaderLbl.TabIndex = 8;
            this.generationHeaderLbl.Text = "Generation:";
            // 
            // num1HeaderLbl
            // 
            this.num1HeaderLbl.AutoSize = true;
            this.num1HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1HeaderLbl.Location = new System.Drawing.Point(16, 66);
            this.num1HeaderLbl.Name = "num1HeaderLbl";
            this.num1HeaderLbl.Size = new System.Drawing.Size(73, 20);
            this.num1HeaderLbl.TabIndex = 0;
            this.num1HeaderLbl.Text = "Max age:";
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
            this.fieldDataGridView.Size = new System.Drawing.Size(886, 479);
            this.fieldDataGridView.TabIndex = 0;
            // 
            // gridPanel
            // 
            this.gridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPanel.Controls.Add(this.fieldDataGridView);
            this.gridPanel.Location = new System.Drawing.Point(12, 13);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(914, 505);
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
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label num1HeaderLbl;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView fieldDataGridView;
        private System.Windows.Forms.Label generationHeaderLbl;
        private System.Windows.Forms.Label generationLbl;
        private System.Windows.Forms.Label num1Lbl;
    }
}