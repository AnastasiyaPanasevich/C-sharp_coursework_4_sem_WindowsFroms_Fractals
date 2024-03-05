namespace Fractals
{
    partial class FormGraph
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
            this.tabControlOutput = new System.Windows.Forms.TabControl();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.PanelDraw = new System.Windows.Forms.Panel();
            this.buttonAnimation = new System.Windows.Forms.Button();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.tabControlOutput.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOutput
            // 
            this.tabControlOutput.Controls.Add(this.tabPageGraph);
            this.tabControlOutput.Controls.Add(this.tabPageTable);
            this.tabControlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOutput.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlOutput.Location = new System.Drawing.Point(0, 0);
            this.tabControlOutput.Name = "tabControlOutput";
            this.tabControlOutput.SelectedIndex = 0;
            this.tabControlOutput.Size = new System.Drawing.Size(1174, 566);
            this.tabControlOutput.TabIndex = 0;
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.BackColor = System.Drawing.Color.Thistle;
            this.tabPageGraph.Controls.Add(this.label1);
            this.tabPageGraph.Controls.Add(this.textBoxScale);
            this.tabPageGraph.Controls.Add(this.PanelDraw);
            this.tabPageGraph.Controls.Add(this.buttonAnimation);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 30);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(1166, 532);
            this.tabPageGraph.TabIndex = 0;
            this.tabPageGraph.Text = "Анимация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1019, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Масштаб    ";
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(1023, 106);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(65, 28);
            this.textBoxScale.TabIndex = 2;
            this.textBoxScale.Text = "4,5";
            this.textBoxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelDraw
            // 
            this.PanelDraw.Location = new System.Drawing.Point(7, 8);
            this.PanelDraw.Name = "PanelDraw";
            this.PanelDraw.Size = new System.Drawing.Size(938, 516);
            this.PanelDraw.TabIndex = 1;
            // 
            // buttonAnimation
            // 
            this.buttonAnimation.BackColor = System.Drawing.Color.Indigo;
            this.buttonAnimation.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnimation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnimation.Location = new System.Drawing.Point(953, 205);
            this.buttonAnimation.Name = "buttonAnimation";
            this.buttonAnimation.Size = new System.Drawing.Size(207, 112);
            this.buttonAnimation.TabIndex = 0;
            this.buttonAnimation.Text = "Анимация";
            this.buttonAnimation.UseVisualStyleBackColor = false;
            this.buttonAnimation.Click += new System.EventHandler(this.buttonAnimation_Click);
            // 
            // tabPageTable
            // 
            this.tabPageTable.BackColor = System.Drawing.Color.Thistle;
            this.tabPageTable.Controls.Add(this.buttonWord);
            this.tabPageTable.Controls.Add(this.buttonExcel);
            this.tabPageTable.Location = new System.Drawing.Point(4, 30);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(1166, 532);
            this.tabPageTable.TabIndex = 1;
            this.tabPageTable.Text = "Таблица";
            // 
            // buttonWord
            // 
            this.buttonWord.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonWord.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWord.Location = new System.Drawing.Point(989, 313);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(124, 132);
            this.buttonWord.TabIndex = 2;
            this.buttonWord.Text = "экспорт в Word";
            this.buttonWord.UseVisualStyleBackColor = false;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonExcel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExcel.Location = new System.Drawing.Point(989, 63);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(124, 132);
            this.buttonExcel.TabIndex = 1;
            this.buttonExcel.Text = "экспорт в Excel";
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1174, 566);
            this.Controls.Add(this.tabControlOutput);
            this.Name = "FormGraph";
            this.Text = "Дополнительная информация";
            this.tabControlOutput.ResumeLayout(false);
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageGraph.PerformLayout();
            this.tabPageTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOutput;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonAnimation;
        private System.Windows.Forms.Panel PanelDraw;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWord;
    }
}