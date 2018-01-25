namespace kursach
{
    partial class Change_preferences
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
            this.mut_param = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_MAX_BOT_ACTIONS = new System.Windows.Forms.TextBox();
            this.tb_HARD_MUTATION = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_NORM_MUTATION = new System.Windows.Forms.TextBox();
            this.tb_SOFT_MUTATION = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Set_Default = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.tb_MAX_COMMAND_NUMBER = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_GENOM_LENGTH = new System.Windows.Forms.TextBox();
            this.resources = new System.Windows.Forms.GroupBox();
            this.ch_WRITEPATH_AVGAGES = new System.Windows.Forms.Button();
            this.ch_WRITEPATH_MAXAGES = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_WRITEPATH_AVGAGES = new System.Windows.Forms.TextBox();
            this.tb_WRITEPATH_MAXAGES = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_FIELD_WIDTH = new System.Windows.Forms.TextBox();
            this.other = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_DEFAULT_BOT_HEALTH = new System.Windows.Forms.TextBox();
            this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_TIME_TO_SLEEP_MS = new System.Windows.Forms.TextBox();
            this.tb_FIELD_HEIGHT = new System.Windows.Forms.TextBox();
            this.vol_things = new System.Windows.Forms.GroupBox();
            this.tb_WALL_ON_FIELD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_POIS_ON_FIELD = new System.Windows.Forms.TextBox();
            this.tb_LEN_OF_WALL = new System.Windows.Forms.TextBox();
            this.tb_FOOD_ON_FIELD = new System.Windows.Forms.TextBox();
            this.tb_FOOD_VOLUME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_NUM_OF_BOTS = new System.Windows.Forms.TextBox();
            this.field_size = new System.Windows.Forms.GroupBox();
            this.gen_pref = new System.Windows.Forms.GroupBox();
            this.most_imp = new System.Windows.Forms.GroupBox();
            this.cb_ENABLE_TWISTS = new System.Windows.Forms.CheckBox();
            this.cb_ENABLE_WALLS = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.mut_param.SuspendLayout();
            this.resources.SuspendLayout();
            this.other.SuspendLayout();
            this.vol_things.SuspendLayout();
            this.field_size.SuspendLayout();
            this.gen_pref.SuspendLayout();
            this.most_imp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mut_param
            // 
            this.mut_param.Controls.Add(this.label17);
            this.mut_param.Controls.Add(this.label18);
            this.mut_param.Controls.Add(this.tb_MAX_BOT_ACTIONS);
            this.mut_param.Controls.Add(this.tb_HARD_MUTATION);
            this.mut_param.Controls.Add(this.label15);
            this.mut_param.Controls.Add(this.label16);
            this.mut_param.Controls.Add(this.tb_NORM_MUTATION);
            this.mut_param.Controls.Add(this.tb_SOFT_MUTATION);
            this.mut_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mut_param.Location = new System.Drawing.Point(19, 429);
            this.mut_param.Name = "mut_param";
            this.mut_param.Size = new System.Drawing.Size(699, 107);
            this.mut_param.TabIndex = 22;
            this.mut_param.TabStop = false;
            this.mut_param.Text = "Mutation parameters";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(377, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "MAX_BOT_ACTIONS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(115, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "HARD_MUTATION";
            // 
            // tb_MAX_BOT_ACTIONS
            // 
            this.tb_MAX_BOT_ACTIONS.Location = new System.Drawing.Point(531, 71);
            this.tb_MAX_BOT_ACTIONS.Name = "tb_MAX_BOT_ACTIONS";
            this.tb_MAX_BOT_ACTIONS.Size = new System.Drawing.Size(100, 22);
            this.tb_MAX_BOT_ACTIONS.TabIndex = 24;
            this.tb_MAX_BOT_ACTIONS.Validating += new System.ComponentModel.CancelEventHandler(this.tb_MAX_BOT_ACTIONS_Validating);
            // 
            // tb_HARD_MUTATION
            // 
            this.tb_HARD_MUTATION.Location = new System.Drawing.Point(246, 71);
            this.tb_HARD_MUTATION.Name = "tb_HARD_MUTATION";
            this.tb_HARD_MUTATION.Size = new System.Drawing.Size(100, 22);
            this.tb_HARD_MUTATION.TabIndex = 22;
            this.tb_HARD_MUTATION.Validating += new System.ComponentModel.CancelEventHandler(this.tb_HARD_MUTATION_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(387, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "NORM_MUTATION";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(114, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "SOFT_MUTATION";
            // 
            // tb_NORM_MUTATION
            // 
            this.tb_NORM_MUTATION.Location = new System.Drawing.Point(531, 28);
            this.tb_NORM_MUTATION.Name = "tb_NORM_MUTATION";
            this.tb_NORM_MUTATION.Size = new System.Drawing.Size(100, 22);
            this.tb_NORM_MUTATION.TabIndex = 20;
            this.tb_NORM_MUTATION.Validating += new System.ComponentModel.CancelEventHandler(this.tb_NORM_MUTATION_Validating);
            // 
            // tb_SOFT_MUTATION
            // 
            this.tb_SOFT_MUTATION.Location = new System.Drawing.Point(246, 28);
            this.tb_SOFT_MUTATION.Name = "tb_SOFT_MUTATION";
            this.tb_SOFT_MUTATION.Size = new System.Drawing.Size(100, 22);
            this.tb_SOFT_MUTATION.TabIndex = 18;
            this.tb_SOFT_MUTATION.Validating += new System.ComponentModel.CancelEventHandler(this.tb_SOFT_MUTATION_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(254, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "TIME_TO_SLEEP_BETWEEN_GEN_MS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "GENOM_LENGTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "FIELD_WIDTH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAX_COMMAND_NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "FIELD_HEIGHT";
            // 
            // btn_Set_Default
            // 
            this.btn_Set_Default.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Set_Default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Set_Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Set_Default.Location = new System.Drawing.Point(603, 678);
            this.btn_Set_Default.Name = "btn_Set_Default";
            this.btn_Set_Default.Size = new System.Drawing.Size(127, 46);
            this.btn_Set_Default.TabIndex = 26;
            this.btn_Set_Default.Text = "Set Default ";
            this.btn_Set_Default.UseVisualStyleBackColor = false;
            this.btn_Set_Default.Click += new System.EventHandler(this.btn_Set_Default_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Ok.Location = new System.Drawing.Point(19, 678);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(127, 46);
            this.btn_Ok.TabIndex = 24;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // tb_MAX_COMMAND_NUMBER
            // 
            this.tb_MAX_COMMAND_NUMBER.Location = new System.Drawing.Point(248, 21);
            this.tb_MAX_COMMAND_NUMBER.Name = "tb_MAX_COMMAND_NUMBER";
            this.tb_MAX_COMMAND_NUMBER.Size = new System.Drawing.Size(100, 22);
            this.tb_MAX_COMMAND_NUMBER.TabIndex = 2;
            this.tb_MAX_COMMAND_NUMBER.Validating += new System.ComponentModel.CancelEventHandler(this.tb_MAX_COMMAND_NUMBER_Validating);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.Location = new System.Drawing.Point(193, 678);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 46);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_GENOM_LENGTH
            // 
            this.tb_GENOM_LENGTH.Location = new System.Drawing.Point(531, 21);
            this.tb_GENOM_LENGTH.Name = "tb_GENOM_LENGTH";
            this.tb_GENOM_LENGTH.Size = new System.Drawing.Size(100, 22);
            this.tb_GENOM_LENGTH.TabIndex = 4;
            this.tb_GENOM_LENGTH.Validating += new System.ComponentModel.CancelEventHandler(this.tb_GENOM_LENGTH_Validating);
            // 
            // resources
            // 
            this.resources.Controls.Add(this.ch_WRITEPATH_AVGAGES);
            this.resources.Controls.Add(this.ch_WRITEPATH_MAXAGES);
            this.resources.Controls.Add(this.label19);
            this.resources.Controls.Add(this.label20);
            this.resources.Controls.Add(this.tb_WRITEPATH_AVGAGES);
            this.resources.Controls.Add(this.tb_WRITEPATH_MAXAGES);
            this.resources.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resources.Location = new System.Drawing.Point(19, 551);
            this.resources.Name = "resources";
            this.resources.Size = new System.Drawing.Size(699, 95);
            this.resources.TabIndex = 23;
            this.resources.TabStop = false;
            this.resources.Text = "Resources";
            // 
            // ch_WRITEPATH_AVGAGES
            // 
            this.ch_WRITEPATH_AVGAGES.Location = new System.Drawing.Point(662, 58);
            this.ch_WRITEPATH_AVGAGES.Name = "ch_WRITEPATH_AVGAGES";
            this.ch_WRITEPATH_AVGAGES.Size = new System.Drawing.Size(25, 23);
            this.ch_WRITEPATH_AVGAGES.TabIndex = 10;
            this.ch_WRITEPATH_AVGAGES.Text = "...";
            this.ch_WRITEPATH_AVGAGES.UseVisualStyleBackColor = true;
            this.ch_WRITEPATH_AVGAGES.Click += new System.EventHandler(this.ch_WRITEPATH_AVGAGES_Click);
            // 
            // ch_WRITEPATH_MAXAGES
            // 
            this.ch_WRITEPATH_MAXAGES.Location = new System.Drawing.Point(662, 14);
            this.ch_WRITEPATH_MAXAGES.Name = "ch_WRITEPATH_MAXAGES";
            this.ch_WRITEPATH_MAXAGES.Size = new System.Drawing.Size(25, 23);
            this.ch_WRITEPATH_MAXAGES.TabIndex = 9;
            this.ch_WRITEPATH_MAXAGES.Text = "...";
            this.ch_WRITEPATH_MAXAGES.UseVisualStyleBackColor = true;
            this.ch_WRITEPATH_MAXAGES.Click += new System.EventHandler(this.ch_WRITEPATH_MAXAGES_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(66, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 16);
            this.label19.TabIndex = 7;
            this.label19.Text = "WRITEPATH_AVGAGES";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(66, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 16);
            this.label20.TabIndex = 5;
            this.label20.Text = "WRITEPATH_MAXAGES";
            // 
            // tb_WRITEPATH_AVGAGES
            // 
            this.tb_WRITEPATH_AVGAGES.Location = new System.Drawing.Point(241, 59);
            this.tb_WRITEPATH_AVGAGES.Name = "tb_WRITEPATH_AVGAGES";
            this.tb_WRITEPATH_AVGAGES.Size = new System.Drawing.Size(421, 22);
            this.tb_WRITEPATH_AVGAGES.TabIndex = 8;
            this.tb_WRITEPATH_AVGAGES.Validating += new System.ComponentModel.CancelEventHandler(this.tb_WRITEPATH_AVGAGES_Validating);
            // 
            // tb_WRITEPATH_MAXAGES
            // 
            this.tb_WRITEPATH_MAXAGES.Location = new System.Drawing.Point(241, 15);
            this.tb_WRITEPATH_MAXAGES.Name = "tb_WRITEPATH_MAXAGES";
            this.tb_WRITEPATH_MAXAGES.Size = new System.Drawing.Size(421, 22);
            this.tb_WRITEPATH_MAXAGES.TabIndex = 6;
            this.tb_WRITEPATH_MAXAGES.Validating += new System.ComponentModel.CancelEventHandler(this.tb_WRITEPATH_MAXAGES_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "WALL_ON_FIELD";
            // 
            // tb_FIELD_WIDTH
            // 
            this.tb_FIELD_WIDTH.Location = new System.Drawing.Point(248, 21);
            this.tb_FIELD_WIDTH.Name = "tb_FIELD_WIDTH";
            this.tb_FIELD_WIDTH.Size = new System.Drawing.Size(100, 22);
            this.tb_FIELD_WIDTH.TabIndex = 6;
            this.tb_FIELD_WIDTH.Validating += new System.ComponentModel.CancelEventHandler(this.tb_FIELD_WIDTH_Validating);
            // 
            // other
            // 
            this.other.Controls.Add(this.label13);
            this.other.Controls.Add(this.label14);
            this.other.Controls.Add(this.tb_DEFAULT_BOT_HEALTH);
            this.other.Controls.Add(this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS);
            this.other.Controls.Add(this.label11);
            this.other.Controls.Add(this.tb_TIME_TO_SLEEP_MS);
            this.other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.other.Location = new System.Drawing.Point(19, 316);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(699, 107);
            this.other.TabIndex = 19;
            this.other.TabStop = false;
            this.other.Text = "Other";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "DEFAULT_BOT_HEALTH";
            // 
            // tb_DEFAULT_BOT_HEALTH
            // 
            this.tb_DEFAULT_BOT_HEALTH.Location = new System.Drawing.Point(562, 30);
            this.tb_DEFAULT_BOT_HEALTH.Name = "tb_DEFAULT_BOT_HEALTH";
            this.tb_DEFAULT_BOT_HEALTH.Size = new System.Drawing.Size(100, 22);
            this.tb_DEFAULT_BOT_HEALTH.TabIndex = 12;
            this.tb_DEFAULT_BOT_HEALTH.Validating += new System.ComponentModel.CancelEventHandler(this.tb_DEFAULT_BOT_HEALTH_Validating);
            // 
            // tb_TIME_TO_SLEEP_BETWEEN_GEN_MS
            // 
            this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Location = new System.Drawing.Point(414, 67);
            this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Name = "tb_TIME_TO_SLEEP_BETWEEN_GEN_MS";
            this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Size = new System.Drawing.Size(100, 22);
            this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.TabIndex = 10;
            this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS.Validating += new System.ComponentModel.CancelEventHandler(this.tb_TIME_TO_SLEEP_BETWEEN_GEN_MS_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "TIME_TO_SLEEP_MS";
            // 
            // tb_TIME_TO_SLEEP_MS
            // 
            this.tb_TIME_TO_SLEEP_MS.Location = new System.Drawing.Point(242, 30);
            this.tb_TIME_TO_SLEEP_MS.Name = "tb_TIME_TO_SLEEP_MS";
            this.tb_TIME_TO_SLEEP_MS.Size = new System.Drawing.Size(100, 22);
            this.tb_TIME_TO_SLEEP_MS.TabIndex = 8;
            this.tb_TIME_TO_SLEEP_MS.Validating += new System.ComponentModel.CancelEventHandler(this.tb_TIME_TO_SLEEP_MS_Validating);
            // 
            // tb_FIELD_HEIGHT
            // 
            this.tb_FIELD_HEIGHT.Location = new System.Drawing.Point(531, 21);
            this.tb_FIELD_HEIGHT.Name = "tb_FIELD_HEIGHT";
            this.tb_FIELD_HEIGHT.Size = new System.Drawing.Size(100, 22);
            this.tb_FIELD_HEIGHT.TabIndex = 8;
            this.tb_FIELD_HEIGHT.Validating += new System.ComponentModel.CancelEventHandler(this.tb_FIELD_HEIGHT_Validating);
            // 
            // vol_things
            // 
            this.vol_things.Controls.Add(this.label10);
            this.vol_things.Controls.Add(this.tb_WALL_ON_FIELD);
            this.vol_things.Controls.Add(this.label9);
            this.vol_things.Controls.Add(this.label7);
            this.vol_things.Controls.Add(this.label8);
            this.vol_things.Controls.Add(this.label12);
            this.vol_things.Controls.Add(this.tb_POIS_ON_FIELD);
            this.vol_things.Controls.Add(this.tb_LEN_OF_WALL);
            this.vol_things.Controls.Add(this.tb_FOOD_ON_FIELD);
            this.vol_things.Controls.Add(this.tb_FOOD_VOLUME);
            this.vol_things.Controls.Add(this.label5);
            this.vol_things.Controls.Add(this.tb_NUM_OF_BOTS);
            this.vol_things.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vol_things.Location = new System.Drawing.Point(19, 203);
            this.vol_things.Name = "vol_things";
            this.vol_things.Size = new System.Drawing.Size(699, 107);
            this.vol_things.TabIndex = 20;
            this.vol_things.TabStop = false;
            this.vol_things.Text = "Volume of things on the field";
            // 
            // tb_WALL_ON_FIELD
            // 
            this.tb_WALL_ON_FIELD.Location = new System.Drawing.Point(353, 66);
            this.tb_WALL_ON_FIELD.Name = "tb_WALL_ON_FIELD";
            this.tb_WALL_ON_FIELD.Size = new System.Drawing.Size(100, 22);
            this.tb_WALL_ON_FIELD.TabIndex = 18;
            this.tb_WALL_ON_FIELD.Validating += new System.ComponentModel.CancelEventHandler(this.tb_WALL_ON_FIELD_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "POIS_ON_FIELD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "FOOD_VOLUME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "FOOD_ON_FIELD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "LEN_OF_WALL";
            // 
            // tb_POIS_ON_FIELD
            // 
            this.tb_POIS_ON_FIELD.Location = new System.Drawing.Point(124, 66);
            this.tb_POIS_ON_FIELD.Name = "tb_POIS_ON_FIELD";
            this.tb_POIS_ON_FIELD.Size = new System.Drawing.Size(100, 22);
            this.tb_POIS_ON_FIELD.TabIndex = 16;
            this.tb_POIS_ON_FIELD.Validating += new System.ComponentModel.CancelEventHandler(this.tb_POIS_ON_FIELD_Validating);
            // 
            // tb_LEN_OF_WALL
            // 
            this.tb_LEN_OF_WALL.Location = new System.Drawing.Point(593, 66);
            this.tb_LEN_OF_WALL.Name = "tb_LEN_OF_WALL";
            this.tb_LEN_OF_WALL.Size = new System.Drawing.Size(100, 22);
            this.tb_LEN_OF_WALL.TabIndex = 6;
            this.tb_LEN_OF_WALL.Validating += new System.ComponentModel.CancelEventHandler(this.tb_LEN_OF_WALL_Validating);
            // 
            // tb_FOOD_ON_FIELD
            // 
            this.tb_FOOD_ON_FIELD.Location = new System.Drawing.Point(593, 30);
            this.tb_FOOD_ON_FIELD.Name = "tb_FOOD_ON_FIELD";
            this.tb_FOOD_ON_FIELD.Size = new System.Drawing.Size(100, 22);
            this.tb_FOOD_ON_FIELD.TabIndex = 14;
            this.tb_FOOD_ON_FIELD.Validating += new System.ComponentModel.CancelEventHandler(this.tb_FOOD_ON_FIELD_Validating);
            // 
            // tb_FOOD_VOLUME
            // 
            this.tb_FOOD_VOLUME.Location = new System.Drawing.Point(353, 30);
            this.tb_FOOD_VOLUME.Name = "tb_FOOD_VOLUME";
            this.tb_FOOD_VOLUME.Size = new System.Drawing.Size(100, 22);
            this.tb_FOOD_VOLUME.TabIndex = 16;
            this.tb_FOOD_VOLUME.Validating += new System.ComponentModel.CancelEventHandler(this.tb_FOOD_VOLUME_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "NUM_OF_BOTS";
            // 
            // tb_NUM_OF_BOTS
            // 
            this.tb_NUM_OF_BOTS.Location = new System.Drawing.Point(126, 30);
            this.tb_NUM_OF_BOTS.Name = "tb_NUM_OF_BOTS";
            this.tb_NUM_OF_BOTS.Size = new System.Drawing.Size(100, 22);
            this.tb_NUM_OF_BOTS.TabIndex = 12;
            this.tb_NUM_OF_BOTS.Validating += new System.ComponentModel.CancelEventHandler(this.tb_NUM_OF_BOTS_Validating);
            // 
            // field_size
            // 
            this.field_size.Controls.Add(this.label3);
            this.field_size.Controls.Add(this.label4);
            this.field_size.Controls.Add(this.tb_FIELD_WIDTH);
            this.field_size.Controls.Add(this.tb_FIELD_HEIGHT);
            this.field_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_size.Location = new System.Drawing.Point(19, 142);
            this.field_size.Name = "field_size";
            this.field_size.Size = new System.Drawing.Size(699, 55);
            this.field_size.TabIndex = 21;
            this.field_size.TabStop = false;
            this.field_size.Text = "Field size";
            // 
            // gen_pref
            // 
            this.gen_pref.Controls.Add(this.label2);
            this.gen_pref.Controls.Add(this.label1);
            this.gen_pref.Controls.Add(this.tb_GENOM_LENGTH);
            this.gen_pref.Controls.Add(this.tb_MAX_COMMAND_NUMBER);
            this.gen_pref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gen_pref.Location = new System.Drawing.Point(19, 81);
            this.gen_pref.Name = "gen_pref";
            this.gen_pref.Size = new System.Drawing.Size(699, 55);
            this.gen_pref.TabIndex = 18;
            this.gen_pref.TabStop = false;
            this.gen_pref.Text = "Genom preferences";
            // 
            // most_imp
            // 
            this.most_imp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.most_imp.Controls.Add(this.cb_ENABLE_TWISTS);
            this.most_imp.Controls.Add(this.cb_ENABLE_WALLS);
            this.most_imp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.most_imp.Location = new System.Drawing.Point(153, 16);
            this.most_imp.Name = "most_imp";
            this.most_imp.Size = new System.Drawing.Size(413, 43);
            this.most_imp.TabIndex = 17;
            this.most_imp.TabStop = false;
            this.most_imp.Text = "Most important";
            // 
            // cb_ENABLE_TWISTS
            // 
            this.cb_ENABLE_TWISTS.AutoSize = true;
            this.cb_ENABLE_TWISTS.Location = new System.Drawing.Point(219, 17);
            this.cb_ENABLE_TWISTS.Name = "cb_ENABLE_TWISTS";
            this.cb_ENABLE_TWISTS.Size = new System.Drawing.Size(139, 20);
            this.cb_ENABLE_TWISTS.TabIndex = 3;
            this.cb_ENABLE_TWISTS.Text = "ENABLE_TWISTS";
            this.cb_ENABLE_TWISTS.UseVisualStyleBackColor = true;
            this.cb_ENABLE_TWISTS.CheckedChanged += new System.EventHandler(this.cb_ENABLE_TWISTS_CheckedChanged);
           
            // 
            // cb_ENABLE_WALLS
            // 
            this.cb_ENABLE_WALLS.AutoSize = true;
            this.cb_ENABLE_WALLS.Location = new System.Drawing.Point(76, 17);
            this.cb_ENABLE_WALLS.Name = "cb_ENABLE_WALLS";
            this.cb_ENABLE_WALLS.Size = new System.Drawing.Size(132, 20);
            this.cb_ENABLE_WALLS.TabIndex = 2;
            this.cb_ENABLE_WALLS.Text = "ENABLE_WALLS";
            this.cb_ENABLE_WALLS.UseVisualStyleBackColor = true;
            this.cb_ENABLE_WALLS.CheckedChanged += new System.EventHandler(this.cb_ENABLE_WALLS_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Change_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 741);
            this.Controls.Add(this.mut_param);
            this.Controls.Add(this.btn_Set_Default);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.resources);
            this.Controls.Add(this.other);
            this.Controls.Add(this.vol_things);
            this.Controls.Add(this.field_size);
            this.Controls.Add(this.gen_pref);
            this.Controls.Add(this.most_imp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change_options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Change_options_Load);
            this.mut_param.ResumeLayout(false);
            this.mut_param.PerformLayout();
            this.resources.ResumeLayout(false);
            this.resources.PerformLayout();
            this.other.ResumeLayout(false);
            this.other.PerformLayout();
            this.vol_things.ResumeLayout(false);
            this.vol_things.PerformLayout();
            this.field_size.ResumeLayout(false);
            this.field_size.PerformLayout();
            this.gen_pref.ResumeLayout(false);
            this.gen_pref.PerformLayout();
            this.most_imp.ResumeLayout(false);
            this.most_imp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mut_param;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_MAX_BOT_ACTIONS;
        private System.Windows.Forms.TextBox tb_HARD_MUTATION;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_NORM_MUTATION;
        private System.Windows.Forms.TextBox tb_SOFT_MUTATION;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Set_Default;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TextBox tb_MAX_COMMAND_NUMBER;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_GENOM_LENGTH;
        private System.Windows.Forms.GroupBox resources;
        private System.Windows.Forms.Button ch_WRITEPATH_AVGAGES;
        private System.Windows.Forms.Button ch_WRITEPATH_MAXAGES;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_WRITEPATH_AVGAGES;
        private System.Windows.Forms.TextBox tb_WRITEPATH_MAXAGES;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_FIELD_WIDTH;
        private System.Windows.Forms.GroupBox other;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_DEFAULT_BOT_HEALTH;
        private System.Windows.Forms.TextBox tb_TIME_TO_SLEEP_BETWEEN_GEN_MS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_TIME_TO_SLEEP_MS;
        private System.Windows.Forms.TextBox tb_FIELD_HEIGHT;
        private System.Windows.Forms.GroupBox vol_things;
        private System.Windows.Forms.TextBox tb_WALL_ON_FIELD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_POIS_ON_FIELD;
        private System.Windows.Forms.TextBox tb_LEN_OF_WALL;
        private System.Windows.Forms.TextBox tb_FOOD_ON_FIELD;
        private System.Windows.Forms.TextBox tb_FOOD_VOLUME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_NUM_OF_BOTS;
        private System.Windows.Forms.GroupBox field_size;
        private System.Windows.Forms.GroupBox gen_pref;
        private System.Windows.Forms.GroupBox most_imp;
        private System.Windows.Forms.CheckBox cb_ENABLE_TWISTS;
        private System.Windows.Forms.CheckBox cb_ENABLE_WALLS;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;

    }
}