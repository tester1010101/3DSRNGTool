namespace Pk3DSRNGTool.Subforms
{
    partial class ThemePicker
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            trackBar1 = new System.Windows.Forms.TrackBar();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Red/Blue/Yellow", "Silver/Gold", "Diamond/Pearl", "Unova", "??", "Sunne/Moone", "Rainbow" });
            comboBox1.Location = new System.Drawing.Point(12, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(139, 46);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(118, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "flashing? / speed:";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 15);
            label1.TabIndex = 2;
            label1.Text = "current theme: colSetName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(192, 15);
            label2.TabIndex = 3;
            label2.Text = "set new theme below - counter2-V:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(130, 71);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(127, 45);
            trackBar1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 71);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 29);
            button1.TabIndex = 5;
            button1.Text = "Set/Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ThemePicker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(285, 112);
            Controls.Add(button1);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Name = "ThemePicker";
            Text = "ThemePicker";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
    }
}