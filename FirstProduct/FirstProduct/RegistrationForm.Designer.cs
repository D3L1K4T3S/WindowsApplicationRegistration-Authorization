
namespace FirstProduct
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.PasswordField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.EmailField);
            this.panel1.Location = new System.Drawing.Point(275, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 171);
            this.panel1.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Swis721 Blk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(28, 111);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(214, 39);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.TabStop = false;
            this.CreateButton.Text = "Create Account";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProduct.Properties.Resources.key1;
            this.pictureBox2.Location = new System.Drawing.Point(28, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // PasswordField
            // 
            this.PasswordField.AllowDrop = true;
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(85, 60);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(157, 31);
            this.PasswordField.TabIndex = 11;
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProduct.Properties.Resources.mail1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.Location = new System.Drawing.Point(85, 23);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(157, 31);
            this.EmailField.TabIndex = 9;
            this.EmailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 450);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::FirstProduct.Properties.Resources.back_button;
            this.pictureBox3.Location = new System.Drawing.Point(7, 407);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitLabel.Location = new System.Drawing.Point(759, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(29, 27);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FirstProduct.Properties.Resources.ProgBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

