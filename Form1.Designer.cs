namespace HSE_Graphic_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.btMakeLine = new System.Windows.Forms.Button();
            this.btDeleteSelectLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox1
            // 
            this.pBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pBox1.Location = new System.Drawing.Point(12, 72);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(763, 333);
            this.pBox1.TabIndex = 0;
            this.pBox1.TabStop = false;
            this.pBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBox1_MouseDown);
            this.pBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBox1_MouseMove);
            this.pBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PBox1_MouseUp);
            // 
            // btMakeLine
            // 
            this.btMakeLine.Location = new System.Drawing.Point(12, 28);
            this.btMakeLine.Name = "btMakeLine";
            this.btMakeLine.Size = new System.Drawing.Size(66, 24);
            this.btMakeLine.TabIndex = 1;
            this.btMakeLine.Text = "Line";
            this.btMakeLine.UseVisualStyleBackColor = true;
            // 
            // btDeleteSelectLine
            // 
            this.btDeleteSelectLine.Location = new System.Drawing.Point(84, 29);
            this.btDeleteSelectLine.Name = "btDeleteSelectLine";
            this.btDeleteSelectLine.Size = new System.Drawing.Size(75, 23);
            this.btDeleteSelectLine.TabIndex = 2;
            this.btDeleteSelectLine.Text = "Delete";
            this.btDeleteSelectLine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDeleteSelectLine);
            this.Controls.Add(this.btMakeLine);
            this.Controls.Add(this.pBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Button btMakeLine;
        private System.Windows.Forms.Button btDeleteSelectLine;
    }
}

