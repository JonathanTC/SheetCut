namespace SheetCut
{
    partial class CollisionEditor
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeSelected = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listCollisionBox = new System.Windows.Forms.ListBox();
            this.remove = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.valueText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorViewer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(591, 488);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            this.image.Paint += new System.Windows.Forms.PaintEventHandler(this.image_Paint);
            this.image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            this.image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_MouseMove);
            this.image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(378, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 488);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeSelected);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 130);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Box Informations";
            // 
            // removeSelected
            // 
            this.removeSelected.Location = new System.Drawing.Point(9, 92);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(169, 23);
            this.removeSelected.TabIndex = 9;
            this.removeSelected.Text = "Remove";
            this.removeSelected.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Height : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Width : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listCollisionBox);
            this.groupBox2.Controls.Add(this.remove);
            this.groupBox2.Controls.Add(this.cut);
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 158);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Collision Box";
            // 
            // listCollisionBox
            // 
            this.listCollisionBox.FormattingEnabled = true;
            this.listCollisionBox.Location = new System.Drawing.Point(9, 21);
            this.listCollisionBox.Name = "listCollisionBox";
            this.listCollisionBox.Size = new System.Drawing.Size(169, 95);
            this.listCollisionBox.TabIndex = 3;
            // 
            // remove
            // 
            this.remove.Enabled = false;
            this.remove.Location = new System.Drawing.Point(98, 122);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(80, 25);
            this.remove.TabIndex = 5;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // cut
            // 
            this.cut.Enabled = false;
            this.cut.Location = new System.Drawing.Point(9, 122);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(83, 25);
            this.cut.TabIndex = 4;
            this.cut.Text = "Cut";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorViewer);
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.valueText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Collision Box";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(9, 104);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(83, 25);
            this.create.TabIndex = 6;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Select Color";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Value";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(98, 104);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(83, 25);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // valueText
            // 
            this.valueText.Location = new System.Drawing.Point(83, 49);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(95, 20);
            this.valueText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(47, 23);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(131, 20);
            this.nameText.TabIndex = 0;
            // 
            // colorViewer
            // 
            this.colorViewer.Location = new System.Drawing.Point(157, 76);
            this.colorViewer.Name = "colorViewer";
            this.colorViewer.Size = new System.Drawing.Size(21, 21);
            this.colorViewer.TabIndex = 10;
            // 
            // CollisionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(591, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollisionEditor";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editeur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CollisionEditor_FormClosed);
            this.Load += new System.EventHandler(this.CollisionEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.ListBox listCollisionBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel colorViewer;
    }
}