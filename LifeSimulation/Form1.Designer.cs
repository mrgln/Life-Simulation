
namespace LifeSimulation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelScale = new System.Windows.Forms.Label();
            this.nupdScale = new System.Windows.Forms.NumericUpDown();
            this.nupdDensity = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nupdDensity);
            this.splitContainer1.Panel1.Controls.Add(this.labelDensity);
            this.splitContainer1.Panel1.Controls.Add(this.nupdScale);
            this.splitContainer1.Panel1.Controls.Add(this.labelScale);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1073, 622);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(23, 26);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(67, 25);
            this.labelScale.TabIndex = 0;
            this.labelScale.Text = "Scale";
            // 
            // nupdScale
            // 
            this.nupdScale.Location = new System.Drawing.Point(28, 66);
            this.nupdScale.Name = "nupdScale";
            this.nupdScale.Size = new System.Drawing.Size(257, 26);
            this.nupdScale.TabIndex = 1;
            this.nupdScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nupdDensity
            // 
            this.nupdDensity.Location = new System.Drawing.Point(28, 148);
            this.nupdDensity.Name = "nupdDensity";
            this.nupdDensity.Size = new System.Drawing.Size(257, 26);
            this.nupdDensity.TabIndex = 3;
            this.nupdDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDensity.Location = new System.Drawing.Point(23, 108);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(84, 25);
            this.labelDensity.TabIndex = 2;
            this.labelDensity.Text = "Density";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 622);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDensity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nupdScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nupdDensity;
        private System.Windows.Forms.Label labelDensity;
    }
}

