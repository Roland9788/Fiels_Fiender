namespace Файловый_менеджер
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
            this.btCrserch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCrserch
            // 
            this.btCrserch.Location = new System.Drawing.Point(12, 105);
            this.btCrserch.Name = "btCrserch";
            this.btCrserch.Size = new System.Drawing.Size(251, 53);
            this.btCrserch.TabIndex = 0;
            this.btCrserch.Text = "Создать окно поиска файлов";
            this.btCrserch.UseVisualStyleBackColor = true;
            this.btCrserch.Click += new System.EventHandler(this.btCrserch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 236);
            this.Controls.Add(this.btCrserch);
            this.Name = "Form1";
            this.Text = "Файловый менеджер";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btCrserch;
    }
}