
namespace TheQuest
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
            this.inventory_bowPictureBox = new System.Windows.Forms.PictureBox();
            this.inventory_macePictureBox = new System.Windows.Forms.PictureBox();
            this.inventory_bluePotionPictureBox = new System.Windows.Forms.PictureBox();
            this.inventory_redPotionPictureBox = new System.Windows.Forms.PictureBox();
            this.inventory_swordPictureBox = new System.Windows.Forms.PictureBox();
            this.moveGroupBox = new System.Windows.Forms.GroupBox();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.attackGroupBox = new System.Windows.Forms.GroupBox();
            this.rightAttackButton = new System.Windows.Forms.Button();
            this.leftAttackButton = new System.Windows.Forms.Button();
            this.upAttackButton = new System.Windows.Forms.Button();
            this.downAttackButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerLabel = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.ghostLabel = new System.Windows.Forms.Label();
            this.ghoulLabel = new System.Windows.Forms.Label();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.batHPLabel = new System.Windows.Forms.Label();
            this.ghostHPLabel = new System.Windows.Forms.Label();
            this.ghoulHPLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_bowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_macePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_bluePotionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_redPotionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_swordPictureBox)).BeginInit();
            this.moveGroupBox.SuspendLayout();
            this.attackGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventory_bowPictureBox
            // 
            this.inventory_bowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.inventory_bowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inventory_bowPictureBox.Image")));
            this.inventory_bowPictureBox.Location = new System.Drawing.Point(186, 319);
            this.inventory_bowPictureBox.Name = "inventory_bowPictureBox";
            this.inventory_bowPictureBox.Size = new System.Drawing.Size(50, 50);
            this.inventory_bowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventory_bowPictureBox.TabIndex = 27;
            this.inventory_bowPictureBox.TabStop = false;
            this.inventory_bowPictureBox.Visible = false;
            this.inventory_bowPictureBox.Click += new System.EventHandler(this.Inventory_bowPictureBox_Click);
            // 
            // inventory_macePictureBox
            // 
            this.inventory_macePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.inventory_macePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inventory_macePictureBox.Image")));
            this.inventory_macePictureBox.Location = new System.Drawing.Point(298, 319);
            this.inventory_macePictureBox.Name = "inventory_macePictureBox";
            this.inventory_macePictureBox.Size = new System.Drawing.Size(50, 50);
            this.inventory_macePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventory_macePictureBox.TabIndex = 26;
            this.inventory_macePictureBox.TabStop = false;
            this.inventory_macePictureBox.Visible = false;
            this.inventory_macePictureBox.Click += new System.EventHandler(this.Inventory_macePictureBox_Click);
            // 
            // inventory_bluePotionPictureBox
            // 
            this.inventory_bluePotionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.inventory_bluePotionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inventory_bluePotionPictureBox.Image")));
            this.inventory_bluePotionPictureBox.Location = new System.Drawing.Point(242, 319);
            this.inventory_bluePotionPictureBox.Name = "inventory_bluePotionPictureBox";
            this.inventory_bluePotionPictureBox.Size = new System.Drawing.Size(50, 50);
            this.inventory_bluePotionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventory_bluePotionPictureBox.TabIndex = 25;
            this.inventory_bluePotionPictureBox.TabStop = false;
            this.inventory_bluePotionPictureBox.Visible = false;
            this.inventory_bluePotionPictureBox.Click += new System.EventHandler(this.Inventory_bluePotionPictureBox_Click);
            // 
            // inventory_redPotionPictureBox
            // 
            this.inventory_redPotionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.inventory_redPotionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inventory_redPotionPictureBox.Image")));
            this.inventory_redPotionPictureBox.Location = new System.Drawing.Point(130, 319);
            this.inventory_redPotionPictureBox.Name = "inventory_redPotionPictureBox";
            this.inventory_redPotionPictureBox.Size = new System.Drawing.Size(50, 50);
            this.inventory_redPotionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventory_redPotionPictureBox.TabIndex = 24;
            this.inventory_redPotionPictureBox.TabStop = false;
            this.inventory_redPotionPictureBox.Visible = false;
            this.inventory_redPotionPictureBox.Click += new System.EventHandler(this.Inventory_redPotionPictureBox_Click);
            // 
            // inventory_swordPictureBox
            // 
            this.inventory_swordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.inventory_swordPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventory_swordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inventory_swordPictureBox.Image")));
            this.inventory_swordPictureBox.Location = new System.Drawing.Point(74, 319);
            this.inventory_swordPictureBox.Name = "inventory_swordPictureBox";
            this.inventory_swordPictureBox.Size = new System.Drawing.Size(52, 52);
            this.inventory_swordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventory_swordPictureBox.TabIndex = 23;
            this.inventory_swordPictureBox.TabStop = false;
            this.inventory_swordPictureBox.Visible = false;
            this.inventory_swordPictureBox.Click += new System.EventHandler(this.Inventory_swordPictureBox_Click);
            // 
            // moveGroupBox
            // 
            this.moveGroupBox.Controls.Add(this.downButton);
            this.moveGroupBox.Controls.Add(this.rightButton);
            this.moveGroupBox.Controls.Add(this.leftButton);
            this.moveGroupBox.Controls.Add(this.upButton);
            this.moveGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveGroupBox.Location = new System.Drawing.Point(604, 12);
            this.moveGroupBox.Name = "moveGroupBox";
            this.moveGroupBox.Size = new System.Drawing.Size(200, 113);
            this.moveGroupBox.TabIndex = 28;
            this.moveGroupBox.TabStop = false;
            this.moveGroupBox.Text = "Move";
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(63, 77);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 23);
            this.downButton.TabIndex = 3;
            this.downButton.TabStop = false;
            this.downButton.Text = "Down : S";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(100, 48);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 2;
            this.rightButton.TabStop = false;
            this.rightButton.Text = "Right : D";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(19, 48);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 1;
            this.leftButton.TabStop = false;
            this.leftButton.Text = "Left : A";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(63, 19);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 0;
            this.upButton.TabStop = false;
            this.upButton.Text = "Up : W";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // attackGroupBox
            // 
            this.attackGroupBox.Controls.Add(this.rightAttackButton);
            this.attackGroupBox.Controls.Add(this.leftAttackButton);
            this.attackGroupBox.Controls.Add(this.upAttackButton);
            this.attackGroupBox.Controls.Add(this.downAttackButton);
            this.attackGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackGroupBox.Location = new System.Drawing.Point(604, 131);
            this.attackGroupBox.Name = "attackGroupBox";
            this.attackGroupBox.Size = new System.Drawing.Size(200, 109);
            this.attackGroupBox.TabIndex = 29;
            this.attackGroupBox.TabStop = false;
            this.attackGroupBox.Text = "Attack";
            // 
            // rightAttackButton
            // 
            this.rightAttackButton.Location = new System.Drawing.Point(103, 43);
            this.rightAttackButton.Name = "rightAttackButton";
            this.rightAttackButton.Size = new System.Drawing.Size(75, 23);
            this.rightAttackButton.TabIndex = 6;
            this.rightAttackButton.TabStop = false;
            this.rightAttackButton.Text = "Right : →";
            this.rightAttackButton.UseVisualStyleBackColor = true;
            this.rightAttackButton.Click += new System.EventHandler(this.RightAttackButton_Click);
            // 
            // leftAttackButton
            // 
            this.leftAttackButton.Location = new System.Drawing.Point(22, 43);
            this.leftAttackButton.Name = "leftAttackButton";
            this.leftAttackButton.Size = new System.Drawing.Size(75, 23);
            this.leftAttackButton.TabIndex = 5;
            this.leftAttackButton.TabStop = false;
            this.leftAttackButton.Text = "Left : ←";
            this.leftAttackButton.UseVisualStyleBackColor = true;
            this.leftAttackButton.Click += new System.EventHandler(this.LeftAttackButton_Click);
            // 
            // upAttackButton
            // 
            this.upAttackButton.Location = new System.Drawing.Point(66, 14);
            this.upAttackButton.Name = "upAttackButton";
            this.upAttackButton.Size = new System.Drawing.Size(75, 23);
            this.upAttackButton.TabIndex = 4;
            this.upAttackButton.TabStop = false;
            this.upAttackButton.Text = "Up : ↑";
            this.upAttackButton.UseVisualStyleBackColor = true;
            this.upAttackButton.Click += new System.EventHandler(this.UpAttackButton_Click);
            // 
            // downAttackButton
            // 
            this.downAttackButton.Location = new System.Drawing.Point(66, 72);
            this.downAttackButton.Name = "downAttackButton";
            this.downAttackButton.Size = new System.Drawing.Size(75, 23);
            this.downAttackButton.TabIndex = 7;
            this.downAttackButton.TabStop = false;
            this.downAttackButton.Text = "Down : ↓";
            this.downAttackButton.UseVisualStyleBackColor = true;
            this.downAttackButton.Click += new System.EventHandler(this.DownAttackButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.Controls.Add(this.playerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.batLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHPLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHPLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHPLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHPLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(604, 246);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 149);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(3, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(41, 15);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player";
            // 
            // batLabel
            // 
            this.batLabel.AutoSize = true;
            this.batLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batLabel.Location = new System.Drawing.Point(3, 37);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(25, 15);
            this.batLabel.TabIndex = 1;
            this.batLabel.Text = "Bat";
            // 
            // ghostLabel
            // 
            this.ghostLabel.AutoSize = true;
            this.ghostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostLabel.Location = new System.Drawing.Point(3, 74);
            this.ghostLabel.Name = "ghostLabel";
            this.ghostLabel.Size = new System.Drawing.Size(39, 15);
            this.ghostLabel.TabIndex = 2;
            this.ghostLabel.Text = "Ghost";
            // 
            // ghoulLabel
            // 
            this.ghoulLabel.AutoSize = true;
            this.ghoulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghoulLabel.Location = new System.Drawing.Point(3, 111);
            this.ghoulLabel.Name = "ghoulLabel";
            this.ghoulLabel.Size = new System.Drawing.Size(40, 15);
            this.ghoulLabel.TabIndex = 3;
            this.ghoulLabel.Text = "Ghoul";
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.AutoSize = true;
            this.playerHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHPLabel.Location = new System.Drawing.Point(51, 0);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(14, 15);
            this.playerHPLabel.TabIndex = 4;
            this.playerHPLabel.Text = "6";
            // 
            // batHPLabel
            // 
            this.batHPLabel.AutoSize = true;
            this.batHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batHPLabel.Location = new System.Drawing.Point(51, 37);
            this.batHPLabel.Name = "batHPLabel";
            this.batHPLabel.Size = new System.Drawing.Size(14, 15);
            this.batHPLabel.TabIndex = 5;
            this.batHPLabel.Text = "6";
            // 
            // ghostHPLabel
            // 
            this.ghostHPLabel.AutoSize = true;
            this.ghostHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostHPLabel.Location = new System.Drawing.Point(51, 74);
            this.ghostHPLabel.Name = "ghostHPLabel";
            this.ghostHPLabel.Size = new System.Drawing.Size(14, 15);
            this.ghostHPLabel.TabIndex = 6;
            this.ghostHPLabel.Text = "8";
            // 
            // ghoulHPLabel
            // 
            this.ghoulHPLabel.AutoSize = true;
            this.ghoulHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghoulHPLabel.Location = new System.Drawing.Point(51, 111);
            this.ghoulHPLabel.Name = "ghoulHPLabel";
            this.ghoulHPLabel.Size = new System.Drawing.Size(21, 15);
            this.ghoulHPLabel.TabIndex = 7;
            this.ghoulHPLabel.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(812, 400);
            this.Controls.Add(this.inventory_swordPictureBox);
            this.Controls.Add(this.inventory_redPotionPictureBox);
            this.Controls.Add(this.inventory_bowPictureBox);
            this.Controls.Add(this.inventory_bluePotionPictureBox);
            this.Controls.Add(this.inventory_macePictureBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attackGroupBox);
            this.Controls.Add(this.moveGroupBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_bowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_macePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_bluePotionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_redPotionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_swordPictureBox)).EndInit();
            this.moveGroupBox.ResumeLayout(false);
            this.attackGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox inventory_bowPictureBox;
        private System.Windows.Forms.PictureBox inventory_macePictureBox;
        private System.Windows.Forms.PictureBox inventory_bluePotionPictureBox;
        private System.Windows.Forms.PictureBox inventory_redPotionPictureBox;
        private System.Windows.Forms.PictureBox inventory_swordPictureBox;
        private System.Windows.Forms.GroupBox moveGroupBox;
        private System.Windows.Forms.GroupBox attackGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label batLabel;
        private System.Windows.Forms.Label ghostLabel;
        private System.Windows.Forms.Label ghoulLabel;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.Label batHPLabel;
        private System.Windows.Forms.Label ghostHPLabel;
        private System.Windows.Forms.Label ghoulHPLabel;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downAttackButton;
        private System.Windows.Forms.Button rightAttackButton;
        private System.Windows.Forms.Button leftAttackButton;
        private System.Windows.Forms.Button upAttackButton;
        private System.Windows.Forms.Label label1;
    }
}

