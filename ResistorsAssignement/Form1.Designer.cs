namespace ResistorsAssignement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1s = new System.Windows.Forms.Button();
            this.button2p = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the resistor calculator";
            // 
            // button1s
            // 
            this.button1s.BackColor = System.Drawing.Color.White;
            this.button1s.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1s.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1s.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1s.ForeColor = System.Drawing.Color.Black;
            this.button1s.Location = new System.Drawing.Point(55, 127);
            this.button1s.Name = "button1s";
            this.button1s.Size = new System.Drawing.Size(105, 65);
            this.button1s.TabIndex = 2;
            this.button1s.Text = "Series";
            this.button1s.UseVisualStyleBackColor = false;
            this.button1s.Click += new System.EventHandler(this.button1s_Click);
            // 
            // button2p
            // 
            this.button2p.BackColor = System.Drawing.Color.White;
            this.button2p.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2p.ForeColor = System.Drawing.Color.Black;
            this.button2p.Location = new System.Drawing.Point(298, 127);
            this.button2p.Name = "button2p";
            this.button2p.Size = new System.Drawing.Size(100, 65);
            this.button2p.TabIndex = 3;
            this.button2p.Text = "Parallel";
            this.button2p.UseVisualStyleBackColor = false;
            this.button2p.Click += new System.EventHandler(this.button2p_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResistorsAssignement.Properties.Resources.resistor_diagram;
            this.pictureBox1.Location = new System.Drawing.Point(12, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.button2p);
            this.Controls.Add(this.button1s);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Resistor Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1s;
        private System.Windows.Forms.Button button2p;
    }
}

