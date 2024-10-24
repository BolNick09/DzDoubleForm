namespace DzDoubleForm
{
    partial class FrmRead
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
            tbFileText = new TextBox();
            btnDir = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // tbFileText
            // 
            tbFileText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbFileText.Location = new Point(12, 12);
            tbFileText.Multiline = true;
            tbFileText.Name = "tbFileText";
            tbFileText.ReadOnly = true;
            tbFileText.Size = new Size(340, 283);
            tbFileText.TabIndex = 0;
            // 
            // btnDir
            // 
            btnDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDir.Location = new Point(258, 301);
            btnDir.Name = "btnDir";
            btnDir.Size = new Size(94, 29);
            btnDir.TabIndex = 1;
            btnDir.Text = "Обзор";
            btnDir.UseVisualStyleBackColor = true;
            btnDir.Click += btnDir_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(12, 301);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmRead
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 338);
            Controls.Add(btnEdit);
            Controls.Add(btnDir);
            Controls.Add(tbFileText);
            Name = "FrmRead";
            Text = "Форма чтения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFileText;
        private Button btnDir;
        private Button btnEdit;
    }
}
