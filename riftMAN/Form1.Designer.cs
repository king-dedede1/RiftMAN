namespace riftMAN
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            savePositionButton = new Button();
            loadPositionButton = new Button();
            savedPositionComboBox = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            killYourselfButton = new Button();
            comboBox1 = new ComboBox();
            iThoughtItWouldBeFunnyToMakeThisSayGoButton = new Button();
            groupBox1 = new GroupBox();
            unlocksButton = new Button();
            infiniteHealthCheckbox = new CheckBox();
            infiniteAmmoCheckbox = new CheckBox();
            coordsCheckbox = new CheckBox();
            hotkeysButton = new Button();
            coordsLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Bolt Count:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(332, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(82, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 123);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(332, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(82, 23);
            textBox2.TabIndex = 4;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 44);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "Raritanium:";
            // 
            // savePositionButton
            // 
            savePositionButton.Enabled = false;
            savePositionButton.Location = new Point(12, 12);
            savePositionButton.Name = "savePositionButton";
            savePositionButton.Size = new Size(111, 26);
            savePositionButton.TabIndex = 5;
            savePositionButton.Text = "Save Position";
            savePositionButton.UseVisualStyleBackColor = true;
            // 
            // loadPositionButton
            // 
            loadPositionButton.Enabled = false;
            loadPositionButton.Location = new Point(12, 44);
            loadPositionButton.Name = "loadPositionButton";
            loadPositionButton.Size = new Size(111, 26);
            loadPositionButton.TabIndex = 6;
            loadPositionButton.Text = "Load Position";
            loadPositionButton.UseVisualStyleBackColor = true;
            // 
            // savedPositionComboBox
            // 
            savedPositionComboBox.Enabled = false;
            savedPositionComboBox.FormattingEnabled = true;
            savedPositionComboBox.Location = new Point(129, 12);
            savedPositionComboBox.Name = "savedPositionComboBox";
            savedPositionComboBox.Size = new Size(57, 23);
            savedPositionComboBox.TabIndex = 7;
            // 
            // killYourselfButton
            // 
            killYourselfButton.Enabled = false;
            killYourselfButton.Location = new Point(12, 76);
            killYourselfButton.Name = "killYourselfButton";
            killYourselfButton.Size = new Size(111, 26);
            killYourselfButton.TabIndex = 8;
            killYourselfButton.Text = "Die";
            killYourselfButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.TabIndex = 9;
            // 
            // iThoughtItWouldBeFunnyToMakeThisSayGoButton
            // 
            iThoughtItWouldBeFunnyToMakeThisSayGoButton.Enabled = false;
            iThoughtItWouldBeFunnyToMakeThisSayGoButton.Location = new Point(126, 14);
            iThoughtItWouldBeFunnyToMakeThisSayGoButton.Name = "iThoughtItWouldBeFunnyToMakeThisSayGoButton";
            iThoughtItWouldBeFunnyToMakeThisSayGoButton.Size = new Size(57, 24);
            iThoughtItWouldBeFunnyToMakeThisSayGoButton.TabIndex = 10;
            iThoughtItWouldBeFunnyToMakeThisSayGoButton.Text = "Go";
            iThoughtItWouldBeFunnyToMakeThisSayGoButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iThoughtItWouldBeFunnyToMakeThisSayGoButton);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(3, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 46);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Load Planet";
            // 
            // unlocksButton
            // 
            unlocksButton.Enabled = false;
            unlocksButton.Location = new Point(332, 76);
            unlocksButton.Name = "unlocksButton";
            unlocksButton.Size = new Size(82, 26);
            unlocksButton.TabIndex = 12;
            unlocksButton.Text = "Unlocks";
            unlocksButton.UseVisualStyleBackColor = true;
            // 
            // infiniteHealthCheckbox
            // 
            infiniteHealthCheckbox.AutoSize = true;
            infiniteHealthCheckbox.Enabled = false;
            infiniteHealthCheckbox.Location = new Point(12, 160);
            infiniteHealthCheckbox.Name = "infiniteHealthCheckbox";
            infiniteHealthCheckbox.Size = new Size(101, 19);
            infiniteHealthCheckbox.TabIndex = 13;
            infiniteHealthCheckbox.Text = "Infinite Health";
            infiniteHealthCheckbox.UseVisualStyleBackColor = true;
            // 
            // infiniteAmmoCheckbox
            // 
            infiniteAmmoCheckbox.AutoSize = true;
            infiniteAmmoCheckbox.Enabled = false;
            infiniteAmmoCheckbox.Location = new Point(12, 185);
            infiniteAmmoCheckbox.Name = "infiniteAmmoCheckbox";
            infiniteAmmoCheckbox.Size = new Size(103, 19);
            infiniteAmmoCheckbox.TabIndex = 14;
            infiniteAmmoCheckbox.Text = "Infinite Ammo";
            infiniteAmmoCheckbox.UseVisualStyleBackColor = true;
            // 
            // coordsCheckbox
            // 
            coordsCheckbox.AutoSize = true;
            coordsCheckbox.Enabled = false;
            coordsCheckbox.Location = new Point(12, 210);
            coordsCheckbox.Name = "coordsCheckbox";
            coordsCheckbox.Size = new Size(122, 19);
            coordsCheckbox.TabIndex = 15;
            coordsCheckbox.Text = "Show Coordinates";
            coordsCheckbox.UseVisualStyleBackColor = true;
            // 
            // hotkeysButton
            // 
            hotkeysButton.Enabled = false;
            hotkeysButton.Location = new Point(311, 247);
            hotkeysButton.Name = "hotkeysButton";
            hotkeysButton.Size = new Size(103, 44);
            hotkeysButton.TabIndex = 16;
            hotkeysButton.Text = "Configure Hotkeys";
            hotkeysButton.UseVisualStyleBackColor = true;
            // 
            // coordsLabel
            // 
            coordsLabel.AutoSize = true;
            coordsLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            coordsLabel.Location = new Point(12, 232);
            coordsLabel.Name = "coordsLabel";
            coordsLabel.Size = new Size(30, 66);
            coordsLabel.TabIndex = 17;
            coordsLabel.Text = "X:\r\nY:\r\nZ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 303);
            Controls.Add(coordsLabel);
            Controls.Add(hotkeysButton);
            Controls.Add(coordsCheckbox);
            Controls.Add(infiniteAmmoCheckbox);
            Controls.Add(infiniteHealthCheckbox);
            Controls.Add(unlocksButton);
            Controls.Add(groupBox1);
            Controls.Add(killYourselfButton);
            Controls.Add(savedPositionComboBox);
            Controls.Add(loadPositionButton);
            Controls.Add(savePositionButton);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RiftMAN";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button savePositionButton;
        private Button loadPositionButton;
        private ComboBox savedPositionComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button killYourselfButton;
        private ComboBox comboBox1;
        private Button iThoughtItWouldBeFunnyToMakeThisSayGoButton;
        private GroupBox groupBox1;
        private Button unlocksButton;
        private CheckBox infiniteHealthCheckbox;
        private CheckBox infiniteAmmoCheckbox;
        private CheckBox coordsCheckbox;
        private Button hotkeysButton;
        private Label coordsLabel;
    }
}