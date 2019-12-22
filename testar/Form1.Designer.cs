namespace testar
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RoomIDTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.TokenTextBox = new System.Windows.Forms.TextBox();
            this.TokenLabel = new System.Windows.Forms.Label();
            this.ProtocolLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.MTypeLabel = new System.Windows.Forms.Label();
            this.MVLabel = new System.Windows.Forms.Label();
            this.MCListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.MCLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OCLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.RoomIDTextBox);
            this.groupBox1.Controls.Add(this.RoomLabel);
            this.groupBox1.Controls.Add(this.TokenTextBox);
            this.groupBox1.Controls.Add(this.TokenLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(6, 131);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(78, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.Location = new System.Drawing.Point(6, 102);
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(124, 23);
            this.RoomIDTextBox.TabIndex = 3;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(6, 84);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(53, 15);
            this.RoomLabel.TabIndex = 2;
            this.RoomLabel.Text = "RoomID:";
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.Location = new System.Drawing.Point(6, 49);
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.Size = new System.Drawing.Size(124, 23);
            this.TokenTextBox.TabIndex = 1;
            this.TokenTextBox.UseSystemPasswordChar = true;
            // 
            // TokenLabel
            // 
            this.TokenLabel.AutoSize = true;
            this.TokenLabel.Location = new System.Drawing.Point(6, 31);
            this.TokenLabel.Name = "TokenLabel";
            this.TokenLabel.Size = new System.Drawing.Size(41, 15);
            this.TokenLabel.TabIndex = 0;
            this.TokenLabel.Text = "Token:";
            // 
            // ProtocolLabel
            // 
            this.ProtocolLabel.AutoSize = true;
            this.ProtocolLabel.Location = new System.Drawing.Point(12, 206);
            this.ProtocolLabel.Name = "ProtocolLabel";
            this.ProtocolLabel.Size = new System.Drawing.Size(64, 15);
            this.ProtocolLabel.TabIndex = 1;
            this.ProtocolLabel.Text = "Protocol: 0";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(319, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(154, 244);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // MTypeLabel
            // 
            this.MTypeLabel.AutoSize = true;
            this.MTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MTypeLabel.Location = new System.Drawing.Point(164, 26);
            this.MTypeLabel.Name = "MTypeLabel";
            this.MTypeLabel.Size = new System.Drawing.Size(87, 15);
            this.MTypeLabel.TabIndex = 4;
            this.MTypeLabel.Text = "Message Type:";
            // 
            // MVLabel
            // 
            this.MVLabel.AutoSize = true;
            this.MVLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MVLabel.Location = new System.Drawing.Point(319, 26);
            this.MVLabel.Name = "MVLabel";
            this.MVLabel.Size = new System.Drawing.Size(102, 15);
            this.MVLabel.TabIndex = 5;
            this.MVLabel.Text = "Message Version:";
            // 
            // MCListView
            // 
            this.MCListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.MCListView.FullRowSelect = true;
            this.MCListView.HideSelection = false;
            this.MCListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.MCListView.Location = new System.Drawing.Point(479, 44);
            this.MCListView.MultiSelect = false;
            this.MCListView.Name = "MCListView";
            this.MCListView.Size = new System.Drawing.Size(202, 244);
            this.MCListView.TabIndex = 6;
            this.MCListView.UseCompatibleStateImageBehavior = false;
            this.MCListView.View = System.Windows.Forms.View.Details;
            this.MCListView.SelectedIndexChanged += new System.EventHandler(this.MCListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // MCLabel
            // 
            this.MCLabel.AutoSize = true;
            this.MCLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MCLabel.Location = new System.Drawing.Point(479, 26);
            this.MCLabel.Name = "MCLabel";
            this.MCLabel.Size = new System.Drawing.Size(106, 15);
            this.MCLabel.TabIndex = 7;
            this.MCLabel.Text = "Message Content:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 244);
            this.textBox1.TabIndex = 8;
            // 
            // OCLabel
            // 
            this.OCLabel.AutoSize = true;
            this.OCLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OCLabel.Location = new System.Drawing.Point(687, 26);
            this.OCLabel.Name = "OCLabel";
            this.OCLabel.Size = new System.Drawing.Size(100, 15);
            this.OCLabel.TabIndex = 9;
            this.OCLabel.Text = "Object Contents:";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(164, 44);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(149, 244);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 302);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.OCLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MCLabel);
            this.Controls.Add(this.MCListView);
            this.Controls.Add(this.MVLabel);
            this.Controls.Add(this.MTypeLabel);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ProtocolLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox RoomIDTextBox;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.TextBox TokenTextBox;
        private System.Windows.Forms.Label TokenLabel;
        private System.Windows.Forms.Label ProtocolLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label MTypeLabel;
        private System.Windows.Forms.Label MVLabel;
        private System.Windows.Forms.ListView MCListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label MCLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label OCLabel;
        private System.Windows.Forms.ListView listView1;
    }
}

