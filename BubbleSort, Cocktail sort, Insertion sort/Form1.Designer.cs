namespace BubbleSort__Cocktail_sort__Insertion_sort
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
            BtnInsert = new Button();
            LblInstructurs = new Label();
            TxtDataNum = new TextBox();
            DataGrideNumber = new DataGridView();
            Index_0 = new DataGridViewTextBoxColumn();
            Index_1 = new DataGridViewTextBoxColumn();
            Index_2 = new DataGridViewTextBoxColumn();
            Index_3 = new DataGridViewTextBoxColumn();
            Index_4 = new DataGridViewTextBoxColumn();
            Index_5 = new DataGridViewTextBoxColumn();
            Index_6 = new DataGridViewTextBoxColumn();
            Index_7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Index_8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGrideNumber).BeginInit();
            SuspendLayout();
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(141, 104);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(94, 29);
            BtnInsert.TabIndex = 0;
            BtnInsert.Text = "Insertar";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // LblInstructurs
            // 
            LblInstructurs.AutoSize = true;
            LblInstructurs.Location = new Point(47, 26);
            LblInstructurs.Name = "LblInstructurs";
            LblInstructurs.Size = new Size(304, 20);
            LblInstructurs.TabIndex = 1;
            LblInstructurs.Text = "Ingresa 10 numeros seprados por un espacio";
            // 
            // TxtDataNum
            // 
            TxtDataNum.Location = new Point(74, 59);
            TxtDataNum.Name = "TxtDataNum";
            TxtDataNum.Size = new Size(247, 27);
            TxtDataNum.TabIndex = 3;
            // 
            // DataGrideNumber
            // 
            DataGrideNumber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrideNumber.Columns.AddRange(new DataGridViewColumn[] { Index_0, Index_1, Index_2, Index_3, Index_4, Index_5, Index_6, Index_7, Column1, Index_8 });
            DataGrideNumber.Location = new Point(74, 139);
            DataGrideNumber.Name = "DataGrideNumber";
            DataGrideNumber.RowHeadersWidth = 51;
            DataGrideNumber.Size = new Size(1304, 568);
            DataGrideNumber.TabIndex = 4;
            // 
            // Index_0
            // 
            Index_0.HeaderText = "1";
            Index_0.MinimumWidth = 6;
            Index_0.Name = "Index_0";
            Index_0.Width = 125;
            // 
            // Index_1
            // 
            Index_1.HeaderText = "2";
            Index_1.MinimumWidth = 6;
            Index_1.Name = "Index_1";
            Index_1.Width = 125;
            // 
            // Index_2
            // 
            Index_2.HeaderText = "3";
            Index_2.MinimumWidth = 6;
            Index_2.Name = "Index_2";
            Index_2.Width = 125;
            // 
            // Index_3
            // 
            Index_3.HeaderText = "4";
            Index_3.MinimumWidth = 6;
            Index_3.Name = "Index_3";
            Index_3.Width = 125;
            // 
            // Index_4
            // 
            Index_4.HeaderText = "5";
            Index_4.MinimumWidth = 6;
            Index_4.Name = "Index_4";
            Index_4.Width = 125;
            // 
            // Index_5
            // 
            Index_5.HeaderText = "6";
            Index_5.MinimumWidth = 6;
            Index_5.Name = "Index_5";
            Index_5.Width = 125;
            // 
            // Index_6
            // 
            Index_6.HeaderText = "7";
            Index_6.MinimumWidth = 6;
            Index_6.Name = "Index_6";
            Index_6.Width = 125;
            // 
            // Index_7
            // 
            Index_7.HeaderText = "8";
            Index_7.MinimumWidth = 6;
            Index_7.Name = "Index_7";
            Index_7.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "9";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Index_8
            // 
            Index_8.HeaderText = "10";
            Index_8.MinimumWidth = 6;
            Index_8.Name = "Index_8";
            Index_8.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 729);
            Controls.Add(DataGrideNumber);
            Controls.Add(TxtDataNum);
            Controls.Add(LblInstructurs);
            Controls.Add(BtnInsert);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGrideNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnInsert;
        private Label LblInstructurs;
        private TextBox TxtDataNum;
        private DataGridView DataGrideNumber;
        private DataGridViewTextBoxColumn Index_0;
        private DataGridViewTextBoxColumn Index_1;
        private DataGridViewTextBoxColumn Index_2;
        private DataGridViewTextBoxColumn Index_3;
        private DataGridViewTextBoxColumn Index_4;
        private DataGridViewTextBoxColumn Index_5;
        private DataGridViewTextBoxColumn Index_6;
        private DataGridViewTextBoxColumn Index_7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Index_8;
    }
}
