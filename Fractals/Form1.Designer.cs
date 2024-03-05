namespace Fractals
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
            this.glControl1 = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToExcelNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToExcelAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.colorDialogBackground = new System.Windows.Forms.ColorDialog();
            this.colorDialogDraw = new System.Windows.Forms.ColorDialog();
            this.buttonChooseBackgroundColor = new System.Windows.Forms.Button();
            this.buttonChooseDrawColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonKoch = new System.Windows.Forms.RadioButton();
            this.radioButtonSerpinsky = new System.Windows.Forms.RadioButton();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonDragon = new System.Windows.Forms.RadioButton();
            this.radioButtonPythagor = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBranchRatio = new System.Windows.Forms.TextBox();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Transparent;
            this.glControl1.Location = new System.Drawing.Point(36, 84);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1322, 581);
            this.glControl1.TabIndex = 5;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1546, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToExcelNew,
            this.ToExcelAdd});
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // ToExcelNew
            // 
            this.ToExcelNew.BackColor = System.Drawing.Color.LightYellow;
            this.ToExcelNew.Name = "ToExcelNew";
            this.ToExcelNew.Size = new System.Drawing.Size(264, 26);
            this.ToExcelNew.Text = "Create new file";
            this.ToExcelNew.Click += new System.EventHandler(this.ToExcelNew_Click);
            // 
            // ToExcelAdd
            // 
            this.ToExcelAdd.BackColor = System.Drawing.Color.Honeydew;
            this.ToExcelAdd.Name = "ToExcelAdd";
            this.ToExcelAdd.Size = new System.Drawing.Size(264, 26);
            this.ToExcelAdd.Text = "Add to existing file";
            this.ToExcelAdd.Click += new System.EventHandler(this.ToExcelAdd_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite;
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem,
            this.руководствоПользователяToolStripMenuItem});
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            this.руководствоПользователяToolStripMenuItem.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Indigo;
            this.buttonCreate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCreate.Location = new System.Drawing.Point(1388, 479);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(136, 72);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.GhostWhite;
            this.Clear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.Color.Indigo;
            this.Clear.Location = new System.Drawing.Point(1388, 592);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(145, 72);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Location = new System.Drawing.Point(1388, 289);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(41, 22);
            this.textBoxDepth.TabIndex = 16;
            this.textBoxDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(1387, 231);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(41, 22);
            this.textBoxAngle.TabIndex = 17;
            this.textBoxAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorDialogBackground
            // 
            this.colorDialogBackground.Color = System.Drawing.Color.Lavender;
            // 
            // buttonChooseBackgroundColor
            // 
            this.buttonChooseBackgroundColor.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseBackgroundColor.Location = new System.Drawing.Point(1359, 18);
            this.buttonChooseBackgroundColor.Name = "buttonChooseBackgroundColor";
            this.buttonChooseBackgroundColor.Size = new System.Drawing.Size(75, 53);
            this.buttonChooseBackgroundColor.TabIndex = 18;
            this.buttonChooseBackgroundColor.Text = "цвет фона";
            this.buttonChooseBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonChooseBackgroundColor.Click += new System.EventHandler(this.buttonChooseBackgroundColor_Click);
            // 
            // buttonChooseDrawColor
            // 
            this.buttonChooseDrawColor.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseDrawColor.Location = new System.Drawing.Point(1440, 18);
            this.buttonChooseDrawColor.Name = "buttonChooseDrawColor";
            this.buttonChooseDrawColor.Size = new System.Drawing.Size(90, 53);
            this.buttonChooseDrawColor.TabIndex = 19;
            this.buttonChooseDrawColor.Text = "цвет пера";
            this.buttonChooseDrawColor.UseVisualStyleBackColor = true;
            this.buttonChooseDrawColor.Click += new System.EventHandler(this.buttonChooseDrawColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1384, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Глубина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1384, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Угол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1434, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "°";
            // 
            // radioButtonKoch
            // 
            this.radioButtonKoch.AutoSize = true;
            this.radioButtonKoch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonKoch.Location = new System.Drawing.Point(529, 2);
            this.radioButtonKoch.Name = "radioButtonKoch";
            this.radioButtonKoch.Size = new System.Drawing.Size(168, 27);
            this.radioButtonKoch.TabIndex = 23;
            this.radioButtonKoch.TabStop = true;
            this.radioButtonKoch.Text = "Фрактал Коха";
            this.radioButtonKoch.UseVisualStyleBackColor = true;
            this.radioButtonKoch.CheckedChanged += new System.EventHandler(this.radioButtonKoch_CheckedChanged);
            // 
            // radioButtonSerpinsky
            // 
            this.radioButtonSerpinsky.AutoSize = true;
            this.radioButtonSerpinsky.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSerpinsky.Location = new System.Drawing.Point(529, 44);
            this.radioButtonSerpinsky.Name = "radioButtonSerpinsky";
            this.radioButtonSerpinsky.Size = new System.Drawing.Size(243, 27);
            this.radioButtonSerpinsky.TabIndex = 24;
            this.radioButtonSerpinsky.TabStop = true;
            this.radioButtonSerpinsky.Text = "Фрактал Серпинского";
            this.radioButtonSerpinsky.UseVisualStyleBackColor = true;
            this.radioButtonSerpinsky.CheckedChanged += new System.EventHandler(this.radioButtonSerpinsky_CheckedChanged);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(1425, 110);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(79, 22);
            this.textBoxX1.TabIndex = 25;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(1425, 144);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(79, 22);
            this.textBoxY1.TabIndex = 26;
            this.textBoxY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1384, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "X1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1384, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Y1";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(1387, 350);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(41, 22);
            this.textBoxSize.TabIndex = 29;
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1384, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Размер";
            // 
            // radioButtonDragon
            // 
            this.radioButtonDragon.AutoSize = true;
            this.radioButtonDragon.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDragon.Location = new System.Drawing.Point(787, 2);
            this.radioButtonDragon.Name = "radioButtonDragon";
            this.radioButtonDragon.Size = new System.Drawing.Size(205, 27);
            this.radioButtonDragon.TabIndex = 31;
            this.radioButtonDragon.TabStop = true;
            this.radioButtonDragon.Text = "Фрактал Дракона";
            this.radioButtonDragon.UseVisualStyleBackColor = true;
            this.radioButtonDragon.CheckedChanged += new System.EventHandler(this.radioButtonDragon_CheckedChanged);
            // 
            // radioButtonPythagor
            // 
            this.radioButtonPythagor.AutoSize = true;
            this.radioButtonPythagor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPythagor.Location = new System.Drawing.Point(787, 44);
            this.radioButtonPythagor.Name = "radioButtonPythagor";
            this.radioButtonPythagor.Size = new System.Drawing.Size(201, 27);
            this.radioButtonPythagor.TabIndex = 32;
            this.radioButtonPythagor.TabStop = true;
            this.radioButtonPythagor.Text = "Дерево Пифагора";
            this.radioButtonPythagor.UseVisualStyleBackColor = true;
            this.radioButtonPythagor.CheckedChanged += new System.EventHandler(this.radioButtonPythagor_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1384, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Разветвление";
            // 
            // textBoxBranchRatio
            // 
            this.textBoxBranchRatio.Location = new System.Drawing.Point(1388, 410);
            this.textBoxBranchRatio.Name = "textBoxBranchRatio";
            this.textBoxBranchRatio.Size = new System.Drawing.Size(41, 22);
            this.textBoxBranchRatio.TabIndex = 33;
            this.textBoxBranchRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(135, 48);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(78, 22);
            this.textBoxScale.TabIndex = 35;
            this.textBoxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(32, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Масштаб";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(253, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 27);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Дополнительно";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1546, 698);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBranchRatio);
            this.Controls.Add(this.radioButtonPythagor);
            this.Controls.Add(this.radioButtonDragon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.radioButtonSerpinsky);
            this.Controls.Add(this.radioButtonKoch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChooseDrawColor);
            this.Controls.Add(this.buttonChooseBackgroundColor);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Фрактал Панасевич А.А. 10701121";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToExcelNew;
        private System.Windows.Forms.ToolStripMenuItem ToExcelAdd;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.ColorDialog colorDialogBackground;
        private System.Windows.Forms.ColorDialog colorDialogDraw;
        private System.Windows.Forms.Button buttonChooseBackgroundColor;
        private System.Windows.Forms.Button buttonChooseDrawColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonKoch;
        private System.Windows.Forms.RadioButton radioButtonSerpinsky;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonDragon;
        private System.Windows.Forms.RadioButton radioButtonPythagor;
        public OpenTK.GLControl glControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBranchRatio;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

