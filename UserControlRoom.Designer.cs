
namespace SystemeGestionHoteliere
{
    partial class UserControlRoom
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.comboBoxYesNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.textBoxPhN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.Updateanddeleteroom = new System.Windows.Forms.TabPage();
            this.textBoxfree = new System.Windows.Forms.TextBox();
            this.textBoxtype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxroomnb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttondeleteroom = new System.Windows.Forms.Button();
            this.buttonupdateroom = new System.Windows.Forms.Button();
            this.textBoxphoneNo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.Updateanddeleteroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.Updateanddeleteroom);
            this.tabControlRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRoom.Location = new System.Drawing.Point(47, 25);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1021, 364);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.comboBoxYesNo);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.buttonAddRoom);
            this.tabPageAddRoom.Controls.Add(this.textBoxPhN);
            this.tabPageAddRoom.Controls.Add(this.label5);
            this.tabPageAddRoom.Controls.Add(this.label6);
            this.tabPageAddRoom.Controls.Add(this.label7);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1013, 334);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Add Room";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            this.tabPageAddRoom.Leave += new System.EventHandler(this.tabPageAddRoom_Leave);
            // 
            // comboBoxYesNo
            // 
            this.comboBoxYesNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxYesNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxYesNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYesNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYesNo.FormattingEnabled = true;
            this.comboBoxYesNo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxYesNo.Location = new System.Drawing.Point(222, 154);
            this.comboBoxYesNo.Name = "comboBoxYesNo";
            this.comboBoxYesNo.Size = new System.Drawing.Size(225, 25);
            this.comboBoxYesNo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Free :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(168, 89);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(279, 25);
            this.comboBoxType.TabIndex = 10;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddRoom.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddRoom.FlatAppearance.BorderSize = 0;
            this.buttonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRoom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.Location = new System.Drawing.Point(168, 227);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(110, 40);
            this.buttonAddRoom.TabIndex = 14;
            this.buttonAddRoom.Text = "Add";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // textBoxPhN
            // 
            this.textBoxPhN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhN.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhN.Location = new System.Drawing.Point(532, 89);
            this.textBoxPhN.Name = "textBoxPhN";
            this.textBoxPhN.Size = new System.Drawing.Size(279, 25);
            this.textBoxPhN.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone No.:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Add Room";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageSearchRoom.Controls.Add(this.label9);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1013, 334);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search Room";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            this.tabPageSearchRoom.Leave += new System.EventHandler(this.tabPageSearchRoom_Leave);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewRoom.Location = new System.Drawing.Point(29, 48);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.Size = new System.Drawing.Size(948, 253);
            this.dataGridViewRoom.TabIndex = 0;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_number";
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_free";
            this.Column4.HeaderText = "Is free ?";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Search Room";
            // 
            // Updateanddeleteroom
            // 
            this.Updateanddeleteroom.Controls.Add(this.textBoxfree);
            this.Updateanddeleteroom.Controls.Add(this.textBoxtype);
            this.Updateanddeleteroom.Controls.Add(this.label2);
            this.Updateanddeleteroom.Controls.Add(this.textBoxroomnb);
            this.Updateanddeleteroom.Controls.Add(this.label11);
            this.Updateanddeleteroom.Controls.Add(this.buttondeleteroom);
            this.Updateanddeleteroom.Controls.Add(this.buttonupdateroom);
            this.Updateanddeleteroom.Controls.Add(this.textBoxphoneNo1);
            this.Updateanddeleteroom.Controls.Add(this.label3);
            this.Updateanddeleteroom.Controls.Add(this.label4);
            this.Updateanddeleteroom.Controls.Add(this.label10);
            this.Updateanddeleteroom.Location = new System.Drawing.Point(4, 4);
            this.Updateanddeleteroom.Name = "Updateanddeleteroom";
            this.Updateanddeleteroom.Padding = new System.Windows.Forms.Padding(3);
            this.Updateanddeleteroom.Size = new System.Drawing.Size(1013, 334);
            this.Updateanddeleteroom.TabIndex = 2;
            this.Updateanddeleteroom.Text = "Update and Delete Room";
            this.Updateanddeleteroom.UseVisualStyleBackColor = true;
            this.Updateanddeleteroom.Leave += new System.EventHandler(this.Updateanddeleteroom_Leave);
            // 
            // textBoxfree
            // 
            this.textBoxfree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxfree.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfree.Location = new System.Drawing.Point(200, 155);
            this.textBoxfree.Name = "textBoxfree";
            this.textBoxfree.Size = new System.Drawing.Size(279, 25);
            this.textBoxfree.TabIndex = 18;
            // 
            // textBoxtype
            // 
            this.textBoxtype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxtype.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtype.Location = new System.Drawing.Point(514, 155);
            this.textBoxtype.Name = "textBoxtype";
            this.textBoxtype.Size = new System.Drawing.Size(279, 25);
            this.textBoxtype.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Free :";
            // 
            // textBoxroomnb
            // 
            this.textBoxroomnb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxroomnb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxroomnb.Location = new System.Drawing.Point(200, 83);
            this.textBoxroomnb.Name = "textBoxroomnb";
            this.textBoxroomnb.Size = new System.Drawing.Size(279, 25);
            this.textBoxroomnb.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(197, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Room Number :";
            // 
            // buttondeleteroom
            // 
            this.buttondeleteroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttondeleteroom.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttondeleteroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondeleteroom.FlatAppearance.BorderSize = 0;
            this.buttondeleteroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondeleteroom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondeleteroom.Location = new System.Drawing.Point(514, 232);
            this.buttondeleteroom.Name = "buttondeleteroom";
            this.buttondeleteroom.Size = new System.Drawing.Size(110, 40);
            this.buttondeleteroom.TabIndex = 6;
            this.buttondeleteroom.Text = "Delete";
            this.buttondeleteroom.UseVisualStyleBackColor = false;
            this.buttondeleteroom.Click += new System.EventHandler(this.buttondeleteroom_Click);
            // 
            // buttonupdateroom
            // 
            this.buttonupdateroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonupdateroom.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonupdateroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonupdateroom.FlatAppearance.BorderSize = 0;
            this.buttonupdateroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdateroom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdateroom.Location = new System.Drawing.Point(362, 232);
            this.buttonupdateroom.Name = "buttonupdateroom";
            this.buttonupdateroom.Size = new System.Drawing.Size(110, 40);
            this.buttonupdateroom.TabIndex = 5;
            this.buttonupdateroom.Text = "Update";
            this.buttonupdateroom.UseVisualStyleBackColor = false;
            this.buttonupdateroom.Click += new System.EventHandler(this.buttonupdateroom_Click);
            // 
            // textBoxphoneNo1
            // 
            this.textBoxphoneNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxphoneNo1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxphoneNo1.Location = new System.Drawing.Point(514, 83);
            this.textBoxphoneNo1.Name = "textBoxphoneNo1";
            this.textBoxphoneNo1.Size = new System.Drawing.Size(279, 25);
            this.textBoxphoneNo1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone No.:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label10.Location = new System.Drawing.Point(1, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update and Delete Room";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 446);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.Updateanddeleteroom.ResumeLayout(false);
            this.Updateanddeleteroom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage Updateanddeleteroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.TextBox textBoxPhN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttondeleteroom;
        private System.Windows.Forms.Button buttonupdateroom;
        private System.Windows.Forms.TextBox textBoxphoneNo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxroomnb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxYesNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfree;
        private System.Windows.Forms.TextBox textBoxtype;
    }
}
