namespace ABKez_rest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_APIKey = new TextBox();
            btn_getall = new Button();
            btn_getlast = new Button();
            num_id = new NumericUpDown();
            btn_getone = new Button();
            btn_deleteone = new Button();
            btn_deleteall = new Button();
            num_intdata = new NumericUpDown();
            num_booldata = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_comment = new TextBox();
            label6 = new Label();
            btn_writeone = new Button();
            btn_updateone = new Button();
            btn_exit = new Button();
            memo = new RichTextBox();
            ss_Status = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lv_datas = new ListView();
            id = new ColumnHeader();
            intdata = new ColumnHeader();
            floatdata = new ColumnHeader();
            booldata = new ColumnHeader();
            datedata = new ColumnHeader();
            comment = new ColumnHeader();
            num_floatdata = new NumericUpDown();
            cbLinks = new ComboBox();
            cbWithApiKey = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)num_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_intdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_booldata).BeginInit();
            ss_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_floatdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Link:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 6);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "API Key:";
            // 
            // tb_APIKey
            // 
            tb_APIKey.Location = new Point(318, 24);
            tb_APIKey.Name = "tb_APIKey";
            tb_APIKey.PasswordChar = '*';
            tb_APIKey.Size = new Size(145, 23);
            tb_APIKey.TabIndex = 3;
            tb_APIKey.TextChanged += tb_APIKey_TextChanged;
            // 
            // btn_getall
            // 
            btn_getall.Location = new Point(12, 53);
            btn_getall.Name = "btn_getall";
            btn_getall.Size = new Size(75, 23);
            btn_getall.TabIndex = 4;
            btn_getall.Text = "getall";
            btn_getall.UseVisualStyleBackColor = true;
            btn_getall.Click += btn_getall_Click;
            // 
            // btn_getlast
            // 
            btn_getlast.Location = new Point(93, 53);
            btn_getlast.Name = "btn_getlast";
            btn_getlast.Size = new Size(75, 23);
            btn_getlast.TabIndex = 5;
            btn_getlast.Text = "getlast";
            btn_getlast.UseVisualStyleBackColor = true;
            btn_getlast.Click += btn_getlast_Click;
            // 
            // num_id
            // 
            num_id.Location = new Point(174, 53);
            num_id.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            num_id.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            num_id.Name = "num_id";
            num_id.Size = new Size(46, 23);
            num_id.TabIndex = 6;
            // 
            // btn_getone
            // 
            btn_getone.Location = new Point(226, 53);
            btn_getone.Name = "btn_getone";
            btn_getone.Size = new Size(75, 23);
            btn_getone.TabIndex = 7;
            btn_getone.Text = "getone";
            btn_getone.UseVisualStyleBackColor = true;
            btn_getone.Click += btn_getone_Click;
            // 
            // btn_deleteone
            // 
            btn_deleteone.Location = new Point(307, 53);
            btn_deleteone.Name = "btn_deleteone";
            btn_deleteone.Size = new Size(75, 23);
            btn_deleteone.TabIndex = 8;
            btn_deleteone.Text = "deleteone";
            btn_deleteone.UseVisualStyleBackColor = true;
            btn_deleteone.Click += btn_deleteone_Click;
            // 
            // btn_deleteall
            // 
            btn_deleteall.Location = new Point(388, 53);
            btn_deleteall.Name = "btn_deleteall";
            btn_deleteall.Size = new Size(75, 23);
            btn_deleteall.TabIndex = 9;
            btn_deleteall.Text = "deleteall";
            btn_deleteall.UseVisualStyleBackColor = true;
            btn_deleteall.Click += btn_deleteall_Click;
            // 
            // num_intdata
            // 
            num_intdata.Location = new Point(469, 51);
            num_intdata.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            num_intdata.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            num_intdata.Name = "num_intdata";
            num_intdata.Size = new Size(64, 23);
            num_intdata.TabIndex = 10;
            // 
            // num_booldata
            // 
            num_booldata.Location = new Point(638, 51);
            num_booldata.Name = "num_booldata";
            num_booldata.Size = new Size(55, 23);
            num_booldata.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 33);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 13;
            label3.Text = "intdata:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 33);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "floatdata:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(636, 33);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 15;
            label5.Text = "booldata:";
            // 
            // tb_comment
            // 
            tb_comment.Location = new Point(699, 50);
            tb_comment.Name = "tb_comment";
            tb_comment.Size = new Size(173, 23);
            tb_comment.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(699, 33);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 17;
            label6.Text = "comment:";
            // 
            // btn_writeone
            // 
            btn_writeone.Location = new Point(880, 33);
            btn_writeone.Name = "btn_writeone";
            btn_writeone.Size = new Size(75, 23);
            btn_writeone.TabIndex = 18;
            btn_writeone.Text = "writeone";
            btn_writeone.UseVisualStyleBackColor = true;
            btn_writeone.Click += btn_writeone_Click;
            // 
            // btn_updateone
            // 
            btn_updateone.Location = new Point(880, 53);
            btn_updateone.Name = "btn_updateone";
            btn_updateone.Size = new Size(75, 23);
            btn_updateone.TabIndex = 19;
            btn_updateone.Text = "updateone";
            btn_updateone.UseVisualStyleBackColor = true;
            btn_updateone.Click += btn_updateone_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(881, -1);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 20;
            btn_exit.Text = "Quit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // memo
            // 
            memo.HideSelection = false;
            memo.Location = new Point(11, 372);
            memo.Name = "memo";
            memo.ReadOnly = true;
            memo.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            memo.Size = new Size(944, 215);
            memo.TabIndex = 21;
            memo.Text = "";
            // 
            // ss_Status
            // 
            ss_Status.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            ss_Status.Location = new Point(0, 590);
            ss_Status.Name = "ss_Status";
            ss_Status.Size = new Size(967, 22);
            ss_Status.TabIndex = 22;
            ss_Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // lv_datas
            // 
            lv_datas.Activation = ItemActivation.OneClick;
            lv_datas.Columns.AddRange(new ColumnHeader[] { id, intdata, floatdata, booldata, datedata, comment });
            lv_datas.FullRowSelect = true;
            lv_datas.GridLines = true;
            lv_datas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_datas.Location = new Point(12, 82);
            lv_datas.Name = "lv_datas";
            lv_datas.Size = new Size(943, 284);
            lv_datas.TabIndex = 23;
            lv_datas.UseCompatibleStateImageBehavior = false;
            lv_datas.View = View.Details;
            lv_datas.SelectedIndexChanged += lv_datas_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 40;
            // 
            // intdata
            // 
            intdata.Text = "intdata";
            // 
            // floatdata
            // 
            floatdata.Text = "floatdata";
            floatdata.Width = 80;
            // 
            // booldata
            // 
            booldata.Text = "booldata";
            // 
            // datedata
            // 
            datedata.Text = "datedata";
            datedata.Width = 120;
            // 
            // comment
            // 
            comment.Text = "comment";
            comment.Width = 550;
            // 
            // num_floatdata
            // 
            num_floatdata.DecimalPlaces = 25;
            num_floatdata.Location = new Point(539, 51);
            num_floatdata.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            num_floatdata.Minimum = new decimal(new int[] { 1241513984, 370409800, 542101, int.MinValue });
            num_floatdata.Name = "num_floatdata";
            num_floatdata.Size = new Size(93, 23);
            num_floatdata.TabIndex = 24;
            // 
            // cbLinks
            // 
            cbLinks.DisplayMember = "0";
            cbLinks.FormattingEnabled = true;
            cbLinks.Items.AddRange(new object[] { "http://walaki.infora.hu/AB/api/v0.1/", "http://141.147.47.82/AB/api/v0.1/" });
            cbLinks.Location = new Point(13, 24);
            cbLinks.Name = "cbLinks";
            cbLinks.Size = new Size(299, 23);
            cbLinks.TabIndex = 25;
            cbLinks.TextChanged += cbLinks_TextChanged;
            // 
            // cbWithApiKey
            // 
            cbWithApiKey.AutoSize = true;
            cbWithApiKey.Location = new Point(469, 6);
            cbWithApiKey.Name = "cbWithApiKey";
            cbWithApiKey.Size = new Size(88, 19);
            cbWithApiKey.TabIndex = 26;
            cbWithApiKey.Text = "WithApiKey";
            cbWithApiKey.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 612);
            Controls.Add(cbWithApiKey);
            Controls.Add(cbLinks);
            Controls.Add(num_floatdata);
            Controls.Add(lv_datas);
            Controls.Add(ss_Status);
            Controls.Add(memo);
            Controls.Add(btn_exit);
            Controls.Add(btn_updateone);
            Controls.Add(btn_writeone);
            Controls.Add(label6);
            Controls.Add(tb_comment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(num_booldata);
            Controls.Add(num_intdata);
            Controls.Add(btn_deleteall);
            Controls.Add(btn_deleteone);
            Controls.Add(btn_getone);
            Controls.Add(num_id);
            Controls.Add(btn_getlast);
            Controls.Add(btn_getall);
            Controls.Add(tb_APIKey);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "AB kez rest v0.2";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)num_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_intdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_booldata).EndInit();
            ss_Status.ResumeLayout(false);
            ss_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_floatdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox tb_APIKey;
        private Button btn_getall;
        private Button btn_getlast;
        private NumericUpDown num_id;
        private Button btn_getone;
        private Button btn_deleteone;
        private Button btn_deleteall;
        private NumericUpDown num_intdata;
        private NumericUpDown num_booldata;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_comment;
        private Label label6;
        private Button btn_writeone;
        private Button btn_updateone;
        private Button btn_exit;
        private RichTextBox memo;
        private StatusStrip ss_Status;
        private ListView lv_datas;
        private ColumnHeader id;
        private ColumnHeader intdata;
        private ColumnHeader floatdata;
        private ColumnHeader booldata;
        private ColumnHeader comment;
        private ColumnHeader datedata;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private NumericUpDown num_floatdata;
        private ComboBox cbLinks;
        private CheckBox cbWithApiKey;
    }
}
