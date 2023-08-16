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
            boltCountTextBox = new TextBox();
            label2 = new Label();
            rariTextBox = new TextBox();
            label3 = new Label();
            savePositionButton = new Button();
            loadPositionButton = new Button();
            savedPositionComboBox = new ComboBox();
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
            gameSpeedTextBox = new TextBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            trainerTab = new TabPage();
            modsTab = new TabPage();
            addZipButton = new Button();
            label6 = new Label();
            label5 = new Label();
            openFolderButton = new Button();
            refreshButton = new Button();
            modListBox = new CheckedListBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            trainerTab.SuspendLayout();
            modsTab.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Bolt Count:";
            // 
            // boltCountTextBox
            // 
            boltCountTextBox.Location = new Point(351, 6);
            boltCountTextBox.Name = "boltCountTextBox";
            boltCountTextBox.Size = new Size(82, 23);
            boltCountTextBox.TabIndex = 1;
            boltCountTextBox.KeyDown += boltCountTextBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 169);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // rariTextBox
            // 
            rariTextBox.Enabled = false;
            rariTextBox.Location = new Point(351, 35);
            rariTextBox.Name = "rariTextBox";
            rariTextBox.Size = new Size(82, 23);
            rariTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 38);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "Raritanium:";
            // 
            // savePositionButton
            // 
            savePositionButton.Enabled = false;
            savePositionButton.Location = new Point(6, 6);
            savePositionButton.Name = "savePositionButton";
            savePositionButton.Size = new Size(111, 26);
            savePositionButton.TabIndex = 5;
            savePositionButton.Text = "Save Position";
            savePositionButton.UseVisualStyleBackColor = true;
            // 
            // loadPositionButton
            // 
            loadPositionButton.Enabled = false;
            loadPositionButton.Location = new Point(6, 38);
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
            savedPositionComboBox.Location = new Point(123, 6);
            savedPositionComboBox.Name = "savedPositionComboBox";
            savedPositionComboBox.Size = new Size(57, 23);
            savedPositionComboBox.TabIndex = 7;
            // 
            // killYourselfButton
            // 
            killYourselfButton.Enabled = false;
            killYourselfButton.Location = new Point(6, 70);
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
            groupBox1.Location = new Point(-3, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 46);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Load Planet";
            // 
            // unlocksButton
            // 
            unlocksButton.Enabled = false;
            unlocksButton.Location = new Point(351, 93);
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
            infiniteHealthCheckbox.Location = new Point(6, 154);
            infiniteHealthCheckbox.Name = "infiniteHealthCheckbox";
            infiniteHealthCheckbox.Size = new Size(101, 19);
            infiniteHealthCheckbox.TabIndex = 13;
            infiniteHealthCheckbox.Text = "Infinite Health";
            infiniteHealthCheckbox.UseVisualStyleBackColor = true;
            infiniteHealthCheckbox.CheckedChanged += infiniteHealthCheckbox_CheckedChanged;
            // 
            // infiniteAmmoCheckbox
            // 
            infiniteAmmoCheckbox.AutoSize = true;
            infiniteAmmoCheckbox.Enabled = false;
            infiniteAmmoCheckbox.Location = new Point(6, 179);
            infiniteAmmoCheckbox.Name = "infiniteAmmoCheckbox";
            infiniteAmmoCheckbox.Size = new Size(103, 19);
            infiniteAmmoCheckbox.TabIndex = 14;
            infiniteAmmoCheckbox.Text = "Infinite Ammo";
            infiniteAmmoCheckbox.UseVisualStyleBackColor = true;
            infiniteAmmoCheckbox.CheckedChanged += infiniteAmmoCheckbox_CheckedChanged;
            // 
            // coordsCheckbox
            // 
            coordsCheckbox.AutoSize = true;
            coordsCheckbox.Enabled = false;
            coordsCheckbox.Location = new Point(6, 204);
            coordsCheckbox.Name = "coordsCheckbox";
            coordsCheckbox.Size = new Size(122, 19);
            coordsCheckbox.TabIndex = 15;
            coordsCheckbox.Text = "Show Coordinates";
            coordsCheckbox.UseVisualStyleBackColor = true;
            // 
            // hotkeysButton
            // 
            hotkeysButton.Enabled = false;
            hotkeysButton.Location = new Point(326, 269);
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
            coordsLabel.Location = new Point(6, 226);
            coordsLabel.Name = "coordsLabel";
            coordsLabel.Size = new Size(30, 66);
            coordsLabel.TabIndex = 17;
            coordsLabel.Text = "X:\r\nY:\r\nZ:";
            // 
            // gameSpeedTextBox
            // 
            gameSpeedTextBox.Enabled = false;
            gameSpeedTextBox.Location = new Point(351, 64);
            gameSpeedTextBox.Name = "gameSpeedTextBox";
            gameSpeedTextBox.Size = new Size(82, 23);
            gameSpeedTextBox.TabIndex = 19;
            gameSpeedTextBox.KeyDown += gameSpeedTextBox_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 67);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 18;
            label4.Text = "Game Speed:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(trainerTab);
            tabControl1.Controls.Add(modsTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(446, 348);
            tabControl1.TabIndex = 20;
            // 
            // trainerTab
            // 
            trainerTab.Controls.Add(savePositionButton);
            trainerTab.Controls.Add(gameSpeedTextBox);
            trainerTab.Controls.Add(label1);
            trainerTab.Controls.Add(label4);
            trainerTab.Controls.Add(boltCountTextBox);
            trainerTab.Controls.Add(coordsLabel);
            trainerTab.Controls.Add(label2);
            trainerTab.Controls.Add(hotkeysButton);
            trainerTab.Controls.Add(label3);
            trainerTab.Controls.Add(coordsCheckbox);
            trainerTab.Controls.Add(rariTextBox);
            trainerTab.Controls.Add(infiniteAmmoCheckbox);
            trainerTab.Controls.Add(loadPositionButton);
            trainerTab.Controls.Add(infiniteHealthCheckbox);
            trainerTab.Controls.Add(savedPositionComboBox);
            trainerTab.Controls.Add(unlocksButton);
            trainerTab.Controls.Add(killYourselfButton);
            trainerTab.Controls.Add(groupBox1);
            trainerTab.Location = new Point(4, 24);
            trainerTab.Name = "trainerTab";
            trainerTab.Padding = new Padding(3);
            trainerTab.Size = new Size(438, 320);
            trainerTab.TabIndex = 0;
            trainerTab.Text = "Trainer";
            trainerTab.UseVisualStyleBackColor = true;
            // 
            // modsTab
            // 
            modsTab.Controls.Add(addZipButton);
            modsTab.Controls.Add(label6);
            modsTab.Controls.Add(label5);
            modsTab.Controls.Add(openFolderButton);
            modsTab.Controls.Add(refreshButton);
            modsTab.Controls.Add(modListBox);
            modsTab.Location = new Point(4, 24);
            modsTab.Name = "modsTab";
            modsTab.Padding = new Padding(3);
            modsTab.Size = new Size(438, 320);
            modsTab.TabIndex = 1;
            modsTab.Text = "Mods";
            modsTab.UseVisualStyleBackColor = true;
            // 
            // addZipButton
            // 
            addZipButton.Location = new Point(306, 6);
            addZipButton.Name = "addZipButton";
            addZipButton.Size = new Size(60, 29);
            addZipButton.TabIndex = 5;
            addZipButton.Text = "Add ZIP";
            addZipButton.UseVisualStyleBackColor = true;
            addZipButton.Click += addZipButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 227);
            label6.Name = "label6";
            label6.Size = new Size(98, 75);
            label6.TabIndex = 4;
            label6.Text = "Name: \r\nDescription: \r\nMod Version: \r\nAuthor: \r\nGame Version(s): ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 15);
            label5.Name = "label5";
            label5.Size = new Size(227, 40);
            label5.TabIndex = 3;
            label5.Text = "Available Mods";
            // 
            // openFolderButton
            // 
            openFolderButton.Location = new Point(306, 41);
            openFolderButton.Name = "openFolderButton";
            openFolderButton.Size = new Size(124, 29);
            openFolderButton.TabIndex = 2;
            openFolderButton.Text = "Open Mods Folder...";
            openFolderButton.UseVisualStyleBackColor = true;
            openFolderButton.Click += openFolderButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(372, 6);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(58, 29);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // modListBox
            // 
            modListBox.BackColor = SystemColors.Menu;
            modListBox.BorderStyle = BorderStyle.FixedSingle;
            modListBox.FormattingEnabled = true;
            modListBox.Location = new Point(8, 83);
            modListBox.Name = "modListBox";
            modListBox.Size = new Size(422, 128);
            modListBox.TabIndex = 0;
            modListBox.ItemCheck += modListBox_ItemCheck;
            modListBox.SelectedIndexChanged += modListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(446, 348);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "RiftMAN";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            trainerTab.ResumeLayout(false);
            trainerTab.PerformLayout();
            modsTab.ResumeLayout(false);
            modsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox boltCountTextBox;
        private Label label2;
        private TextBox rariTextBox;
        private Label label3;
        private Button savePositionButton;
        private Button loadPositionButton;
        private ComboBox savedPositionComboBox;
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
        private TextBox gameSpeedTextBox;
        private Label label4;
        private TabControl tabControl1;
        private TabPage trainerTab;
        private TabPage modsTab;
        private CheckedListBox modListBox;
        private Label label5;
        private Button openFolderButton;
        private Button refreshButton;
        private Label label6;
        private Button addZipButton;
    }
}