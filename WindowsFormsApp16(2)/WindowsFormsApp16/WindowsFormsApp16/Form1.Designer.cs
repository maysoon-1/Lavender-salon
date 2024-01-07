namespace WindowsFormsApp16
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.class11 = new WindowsFormsApp16.Class1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.class11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(499, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(454, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 161);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 65);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lavender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // class11
            // 
            this.class11.Image = global::WindowsFormsApp16.Properties.Resources._285af290bbd6b2fc457f19d60e03dd7a;
            this.class11.Location = new System.Drawing.Point(428, 44);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(365, 303);
            this.class11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class11.TabIndex = 1;
            this.class11.TabStop = false;
            this.class11.Click += new System.EventHandler(this.class11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp16.Properties.Resources.WhatsApp_Image;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 740);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 715);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.class11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Class1 class11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

