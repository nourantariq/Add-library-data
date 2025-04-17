namespace Add_library_data
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
            insertButton = new Button();
            idtextBox = new TextBox();
            nametextBox = new TextBox();
            locationtextBox = new TextBox();
            categorytextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            searchbutton = new Button();
            updatebutton = new Button();
            deletebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // insertButton
            // 
            insertButton.Location = new Point(12, 239);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(96, 33);
            insertButton.TabIndex = 1;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click_1;
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(-2, 73);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(110, 23);
            idtextBox.TabIndex = 2;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(107, 73);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(215, 23);
            nametextBox.TabIndex = 3;
            // 
            // locationtextBox
            // 
            locationtextBox.Location = new Point(453, 73);
            locationtextBox.Name = "locationtextBox";
            locationtextBox.Size = new Size(203, 23);
            locationtextBox.TabIndex = 4;
            // 
            // categorytextBox
            // 
            categorytextBox.Location = new Point(318, 73);
            categorytextBox.Name = "categorytextBox";
            categorytextBox.Size = new Size(138, 23);
            categorytextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 55);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Location ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 8;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 55);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Category ";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { id });
            dataGridView.Location = new Point(-2, 301);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(658, 150);
            dataGridView.TabIndex = 11;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.HeaderText = "Column1";
            id.Name = "id";
            id.Visible = false;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(114, 239);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(96, 33);
            searchbutton.TabIndex = 12;
            searchbutton.Text = "Search ";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click_1;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(216, 239);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(96, 33);
            updatebutton.TabIndex = 13;
            updatebutton.Text = "Update ";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(318, 239);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(96, 33);
            deletebutton.TabIndex = 14;
            deletebutton.Text = "Delete ";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(deletebutton);
            Controls.Add(updatebutton);
            Controls.Add(searchbutton);
            Controls.Add(dataGridView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categorytextBox);
            Controls.Add(locationtextBox);
            Controls.Add(nametextBox);
            Controls.Add(idtextBox);
            Controls.Add(insertButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button insertButton;
        private TextBox idtextBox;
        private TextBox nametextBox;
        private TextBox locationtextBox;
        private TextBox categorytextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn id;
        private Button searchbutton;
        private Button updatebutton;
        private Button deletebutton;
    }
}
