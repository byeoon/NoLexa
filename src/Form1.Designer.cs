namespace NoLexa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            lblADBWarning = new Label();
            groupBox1 = new GroupBox();
            btnDismiss = new Button();
            btnADBYes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NoLexa_large_1_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 32, 32);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(251, 135);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 32, 32);
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 2;
            label2.Text = "Initial Setup";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(32, 32, 32);
            linkLabel1.LinkColor = Color.FromArgb(100, 100, 200);
            linkLabel1.Location = new Point(80, 201);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click me!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 32, 32);
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(16, 225);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 5;
            label3.Text = "Devices";
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(32, 32, 32);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Location = new Point(16, 245);
            listView1.Name = "listView1";
            listView1.Size = new Size(247, 183);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(169, 434);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(207, 219);
            button2.Name = "button2";
            button2.Size = new Size(56, 23);
            button2.TabIndex = 8;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblADBWarning
            // 
            lblADBWarning.AutoSize = true;
            lblADBWarning.BackColor = Color.FromArgb(30, 10, 10);
            lblADBWarning.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblADBWarning.ForeColor = Color.Red;
            lblADBWarning.Location = new Point(6, 19);
            lblADBWarning.Name = "lblADBWarning";
            lblADBWarning.Size = new Size(203, 45);
            lblADBWarning.TabIndex = 9;
            lblADBWarning.Text = "ADB is not installed on your device! \r\nNoLexa can automatically install this \r\nfor you, do you want to do this?\r\n";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(20, 10, 10);
            groupBox1.Controls.Add(btnDismiss);
            groupBox1.Controls.Add(btnADBYes);
            groupBox1.Controls.Add(lblADBWarning);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(269, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 99);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alert!";
            // 
            // btnDismiss
            // 
            btnDismiss.ForeColor = Color.Black;
            btnDismiss.Location = new Point(6, 70);
            btnDismiss.Name = "btnDismiss";
            btnDismiss.Size = new Size(75, 23);
            btnDismiss.TabIndex = 11;
            btnDismiss.Text = "Dismiss";
            btnDismiss.UseVisualStyleBackColor = true;
            btnDismiss.Click += btnDismiss_Click;
            // 
            // btnADBYes
            // 
            btnADBYes.ForeColor = Color.Black;
            btnADBYes.Location = new Point(134, 70);
            btnADBYes.Name = "btnADBYes";
            btnADBYes.Size = new Size(75, 23);
            btnADBYes.TabIndex = 10;
            btnADBYes.Text = "Yes";
            btnADBYes.UseVisualStyleBackColor = true;
            btnADBYes.Click += btnADBYes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(490, 469);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "NoLexa Setup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Label lblADBWarning;
        private GroupBox groupBox1;
        private Button btnDismiss;
        private Button btnADBYes;
    }
}
