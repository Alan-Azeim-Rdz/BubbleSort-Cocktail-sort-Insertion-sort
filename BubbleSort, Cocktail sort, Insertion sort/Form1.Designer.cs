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
            LsBoxOrder = new ListBox();
            SuspendLayout();
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(123, 78);
            BtnInsert.Margin = new Padding(3, 2, 3, 2);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(82, 22);
            BtnInsert.TabIndex = 0;
            BtnInsert.Text = "Insertar";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // LblInstructurs
            // 
            LblInstructurs.AutoSize = true;
            LblInstructurs.Location = new Point(41, 20);
            LblInstructurs.Name = "LblInstructurs";
            LblInstructurs.Size = new Size(241, 15);
            LblInstructurs.TabIndex = 1;
            LblInstructurs.Text = "Ingresa 10 numeros seprados por un espacio";
            // 
            // TxtDataNum
            // 
            TxtDataNum.Location = new Point(65, 44);
            TxtDataNum.Margin = new Padding(3, 2, 3, 2);
            TxtDataNum.Name = "TxtDataNum";
            TxtDataNum.Size = new Size(217, 23);
            TxtDataNum.TabIndex = 3;
            // 
            // LsBoxOrder
            // 
            LsBoxOrder.FormattingEnabled = true;
            LsBoxOrder.ItemHeight = 15;
            LsBoxOrder.Location = new Point(319, 20);
            LsBoxOrder.Name = "LsBoxOrder";
            LsBoxOrder.Size = new Size(754, 304);
            LsBoxOrder.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 370);
            Controls.Add(LsBoxOrder);
            Controls.Add(TxtDataNum);
            Controls.Add(LblInstructurs);
            Controls.Add(BtnInsert);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnInsert;
        private Label LblInstructurs;
        private TextBox TxtDataNum;
        private ListBox LsBoxOrder;
    }
}
