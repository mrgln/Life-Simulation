
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.nupdDensity = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            this.nupdScale = new System.Windows.Forms.NumericUpDown();
            this.labelScale = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel1.Controls.Add(this.nupdDensity);
            this.splitContainer1.Panel1.Controls.Add(this.labelDensity);
            this.splitContainer1.Panel1.Controls.Add(this.nupdScale);
            this.splitContainer1.Panel1.Controls.Add(this.labelScale);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(787, 441);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 127);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 127);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(76, 32);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // nupdDensity
            // 
            this.nupdDensity.Location = new System.Drawing.Point(10, 92);
            this.nupdDensity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupdDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupdDensity.Name = "nupdDensity";
            this.nupdDensity.Size = new System.Drawing.Size(171, 20);
            this.nupdDensity.TabIndex = 3;
            this.nupdDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupdDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDensity.Location = new System.Drawing.Point(7, 66);
            this.labelDensity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(62, 17);
            this.labelDensity.TabIndex = 2;
            this.labelDensity.Text = "Density";
            // 
            // nupdScale
            // 
            this.nupdScale.Location = new System.Drawing.Point(10, 39);
            this.nupdScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupdScale.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nupdScale.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupdScale.Name = "nupdScale";
            this.nupdScale.Size = new System.Drawing.Size(171, 20);
            this.nupdScale.TabIndex = 1;
            this.nupdScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupdScale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(7, 13);
            this.labelScale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(48, 17);
            this.labelScale.TabIndex = 0;
            this.labelScale.Text = "Scale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 437);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 441);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupdDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nupdScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nupdDensity;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

