namespace Struktury
{
    partial class Form1
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
            this.ArrayView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XValueEdit = new System.Windows.Forms.TextBox();
            this.YValueEdit = new System.Windows.Forms.TextBox();
            this.ZValueEdit = new System.Windows.Forms.TextBox();
            this.VariantGroup = new System.Windows.Forms.GroupBox();
            this.NumberOfPointsEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MorePointRadioButton = new System.Windows.Forms.RadioButton();
            this.OnePointRadioButton = new System.Windows.Forms.RadioButton();
            this.SourceGroup = new System.Windows.Forms.GroupBox();
            this.PointArrayRadioButton = new System.Windows.Forms.RadioButton();
            this.ObjectArrayRadioButton = new System.Windows.Forms.RadioButton();
            this.DisplayPointArrayButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveTime = new System.Windows.Forms.Label();
            this.DisplayObjectArrayButton = new System.Windows.Forms.Button();
            this.ClearPointArrayButton = new System.Windows.Forms.Button();
            this.ClearObjectArrayButton = new System.Windows.Forms.Button();
            this.ClearArrayView = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.VariantGroup.SuspendLayout();
            this.SourceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArrayView
            // 
            this.ArrayView.FormattingEnabled = true;
            this.ArrayView.ItemHeight = 16;
            this.ArrayView.Location = new System.Drawing.Point(12, 44);
            this.ArrayView.Name = "ArrayView";
            this.ArrayView.Size = new System.Drawing.Size(228, 452);
            this.ArrayView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Z";
            // 
            // XValueEdit
            // 
            this.XValueEdit.Location = new System.Drawing.Point(287, 55);
            this.XValueEdit.Name = "XValueEdit";
            this.XValueEdit.Size = new System.Drawing.Size(41, 22);
            this.XValueEdit.TabIndex = 5;
            this.XValueEdit.Text = "0";
            this.XValueEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YValueEdit
            // 
            this.YValueEdit.Location = new System.Drawing.Point(334, 55);
            this.YValueEdit.Name = "YValueEdit";
            this.YValueEdit.Size = new System.Drawing.Size(41, 22);
            this.YValueEdit.TabIndex = 6;
            this.YValueEdit.Text = "0";
            this.YValueEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ZValueEdit
            // 
            this.ZValueEdit.Location = new System.Drawing.Point(381, 55);
            this.ZValueEdit.Name = "ZValueEdit";
            this.ZValueEdit.Size = new System.Drawing.Size(41, 22);
            this.ZValueEdit.TabIndex = 7;
            this.ZValueEdit.Text = "0";
            this.ZValueEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VariantGroup
            // 
            this.VariantGroup.Controls.Add(this.NumberOfPointsEdit);
            this.VariantGroup.Controls.Add(this.label5);
            this.VariantGroup.Controls.Add(this.MorePointRadioButton);
            this.VariantGroup.Controls.Add(this.OnePointRadioButton);
            this.VariantGroup.Location = new System.Drawing.Point(287, 83);
            this.VariantGroup.Name = "VariantGroup";
            this.VariantGroup.Size = new System.Drawing.Size(356, 145);
            this.VariantGroup.TabIndex = 8;
            this.VariantGroup.TabStop = false;
            this.VariantGroup.Text = "Wariant";
            // 
            // NumberOfPointsEdit
            // 
            this.NumberOfPointsEdit.Location = new System.Drawing.Point(78, 109);
            this.NumberOfPointsEdit.Name = "NumberOfPointsEdit";
            this.NumberOfPointsEdit.Size = new System.Drawing.Size(272, 22);
            this.NumberOfPointsEdit.TabIndex = 3;
            this.NumberOfPointsEdit.Text = "1";
            this.NumberOfPointsEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "ilość";
            // 
            // MorePointRadioButton
            // 
            this.MorePointRadioButton.AutoSize = true;
            this.MorePointRadioButton.Location = new System.Drawing.Point(7, 65);
            this.MorePointRadioButton.Name = "MorePointRadioButton";
            this.MorePointRadioButton.Size = new System.Drawing.Size(232, 38);
            this.MorePointRadioButton.TabIndex = 1;
            this.MorePointRadioButton.Text = "Dodaj zdefiniowaną ilość\r\npunktów o losowych wartościach";
            this.MorePointRadioButton.UseVisualStyleBackColor = true;
            this.MorePointRadioButton.CheckedChanged += new System.EventHandler(this.MorePointRadioButton_CheckedChanged);
            // 
            // OnePointRadioButton
            // 
            this.OnePointRadioButton.AutoSize = true;
            this.OnePointRadioButton.Checked = true;
            this.OnePointRadioButton.Location = new System.Drawing.Point(7, 21);
            this.OnePointRadioButton.Name = "OnePointRadioButton";
            this.OnePointRadioButton.Size = new System.Drawing.Size(141, 38);
            this.OnePointRadioButton.TabIndex = 0;
            this.OnePointRadioButton.TabStop = true;
            this.OnePointRadioButton.Text = "Dodaj pojedynczy\r\npunkt";
            this.OnePointRadioButton.UseVisualStyleBackColor = true;
            this.OnePointRadioButton.CheckedChanged += new System.EventHandler(this.OnePointRadioButton_CheckedChanged);
            // 
            // SourceGroup
            // 
            this.SourceGroup.Controls.Add(this.PointArrayRadioButton);
            this.SourceGroup.Controls.Add(this.ObjectArrayRadioButton);
            this.SourceGroup.Location = new System.Drawing.Point(287, 236);
            this.SourceGroup.Name = "SourceGroup";
            this.SourceGroup.Size = new System.Drawing.Size(356, 100);
            this.SourceGroup.TabIndex = 9;
            this.SourceGroup.TabStop = false;
            this.SourceGroup.Text = "Tablica docelowa";
            // 
            // PointArrayRadioButton
            // 
            this.PointArrayRadioButton.AutoSize = true;
            this.PointArrayRadioButton.Checked = true;
            this.PointArrayRadioButton.Location = new System.Drawing.Point(7, 31);
            this.PointArrayRadioButton.Name = "PointArrayRadioButton";
            this.PointArrayRadioButton.Size = new System.Drawing.Size(132, 21);
            this.PointArrayRadioButton.TabIndex = 1;
            this.PointArrayRadioButton.TabStop = true;
            this.PointArrayRadioButton.Text = "Tablica Punktów";
            this.PointArrayRadioButton.UseVisualStyleBackColor = true;
            this.PointArrayRadioButton.CheckedChanged += new System.EventHandler(this.PointArrayRadioButton_CheckedChanged);
            // 
            // ObjectArrayRadioButton
            // 
            this.ObjectArrayRadioButton.AutoSize = true;
            this.ObjectArrayRadioButton.Location = new System.Drawing.Point(7, 58);
            this.ObjectArrayRadioButton.Name = "ObjectArrayRadioButton";
            this.ObjectArrayRadioButton.Size = new System.Drawing.Size(137, 21);
            this.ObjectArrayRadioButton.TabIndex = 0;
            this.ObjectArrayRadioButton.Text = "Tablica Obiektów";
            this.ObjectArrayRadioButton.UseVisualStyleBackColor = true;
            this.ObjectArrayRadioButton.CheckedChanged += new System.EventHandler(this.ObjectArrayRadioButton_CheckedChanged);
            // 
            // DisplayPointArrayButton
            // 
            this.DisplayPointArrayButton.Location = new System.Drawing.Point(287, 377);
            this.DisplayPointArrayButton.Name = "DisplayPointArrayButton";
            this.DisplayPointArrayButton.Size = new System.Drawing.Size(131, 59);
            this.DisplayPointArrayButton.TabIndex = 10;
            this.DisplayPointArrayButton.Text = "Wyświetl tablicę punktów";
            this.DisplayPointArrayButton.UseVisualStyleBackColor = true;
            this.DisplayPointArrayButton.Click += new System.EventHandler(this.DisplayPointArrayButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(549, 377);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 59);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Czas zapisu: ";
            // 
            // SaveTime
            // 
            this.SaveTime.AutoSize = true;
            this.SaveTime.Location = new System.Drawing.Point(378, 348);
            this.SaveTime.Name = "SaveTime";
            this.SaveTime.Size = new System.Drawing.Size(20, 17);
            this.SaveTime.TabIndex = 13;
            this.SaveTime.Text = " 0";
            // 
            // DisplayObjectArrayButton
            // 
            this.DisplayObjectArrayButton.Location = new System.Drawing.Point(424, 377);
            this.DisplayObjectArrayButton.Name = "DisplayObjectArrayButton";
            this.DisplayObjectArrayButton.Size = new System.Drawing.Size(119, 59);
            this.DisplayObjectArrayButton.TabIndex = 14;
            this.DisplayObjectArrayButton.Text = "Wyświetl tablicę obiektów";
            this.DisplayObjectArrayButton.UseVisualStyleBackColor = true;
            this.DisplayObjectArrayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearPointArrayButton
            // 
            this.ClearPointArrayButton.Location = new System.Drawing.Point(287, 442);
            this.ClearPointArrayButton.Name = "ClearPointArrayButton";
            this.ClearPointArrayButton.Size = new System.Drawing.Size(133, 59);
            this.ClearPointArrayButton.TabIndex = 15;
            this.ClearPointArrayButton.Text = "Wyczyść tablicę punktów";
            this.ClearPointArrayButton.UseVisualStyleBackColor = true;
            this.ClearPointArrayButton.Click += new System.EventHandler(this.ClearPointArrayButton_Click);
            // 
            // ClearObjectArrayButton
            // 
            this.ClearObjectArrayButton.Location = new System.Drawing.Point(424, 442);
            this.ClearObjectArrayButton.Name = "ClearObjectArrayButton";
            this.ClearObjectArrayButton.Size = new System.Drawing.Size(121, 59);
            this.ClearObjectArrayButton.TabIndex = 16;
            this.ClearObjectArrayButton.Text = "Wyczyść tablicę obiektów";
            this.ClearObjectArrayButton.UseVisualStyleBackColor = true;
            this.ClearObjectArrayButton.Click += new System.EventHandler(this.ClearObjectArrayButton_Click);
            // 
            // ClearArrayView
            // 
            this.ClearArrayView.Location = new System.Drawing.Point(549, 442);
            this.ClearArrayView.Name = "ClearArrayView";
            this.ClearArrayView.Size = new System.Drawing.Size(94, 59);
            this.ClearArrayView.TabIndex = 17;
            this.ClearArrayView.Text = "Wyczyść widok";
            this.ClearArrayView.UseVisualStyleBackColor = true;
            this.ClearArrayView.Click += new System.EventHandler(this.ClearArrayView_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(52, 17);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "Tabela";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 551);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ClearArrayView);
            this.Controls.Add(this.ClearObjectArrayButton);
            this.Controls.Add(this.ClearPointArrayButton);
            this.Controls.Add(this.DisplayObjectArrayButton);
            this.Controls.Add(this.SaveTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DisplayPointArrayButton);
            this.Controls.Add(this.SourceGroup);
            this.Controls.Add(this.VariantGroup);
            this.Controls.Add(this.ZValueEdit);
            this.Controls.Add(this.YValueEdit);
            this.Controls.Add(this.XValueEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrayView);
            this.Name = "Form1";
            this.Text = "Punkty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VariantGroup.ResumeLayout(false);
            this.VariantGroup.PerformLayout();
            this.SourceGroup.ResumeLayout(false);
            this.SourceGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ArrayView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox XValueEdit;
        private System.Windows.Forms.TextBox YValueEdit;
        private System.Windows.Forms.TextBox ZValueEdit;
        private System.Windows.Forms.GroupBox VariantGroup;
        private System.Windows.Forms.RadioButton MorePointRadioButton;
        private System.Windows.Forms.RadioButton OnePointRadioButton;
        private System.Windows.Forms.TextBox NumberOfPointsEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox SourceGroup;
        private System.Windows.Forms.RadioButton PointArrayRadioButton;
        private System.Windows.Forms.RadioButton ObjectArrayRadioButton;
        private System.Windows.Forms.Button DisplayPointArrayButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SaveTime;
        private System.Windows.Forms.Button DisplayObjectArrayButton;
        private System.Windows.Forms.Button ClearPointArrayButton;
        private System.Windows.Forms.Button ClearObjectArrayButton;
        private System.Windows.Forms.Button ClearArrayView;
        private System.Windows.Forms.Label TitleLabel;
    }
}

