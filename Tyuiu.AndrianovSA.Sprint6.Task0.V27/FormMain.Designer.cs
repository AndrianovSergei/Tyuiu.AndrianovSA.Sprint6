namespace Tyuiu.AndrianovSA.Sprint6.Task0.V27
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBoxTask_ASA = new GroupBox();
            pictureBoxFormula_ASA = new PictureBox();
            labelTask_ASA = new Label();
            groupBoxInPut_ASA = new GroupBox();
            textBoxVarX_ASA = new TextBox();
            labelVarX_ASA = new Label();
            groupBoxOutPut_ASA = new GroupBox();
            textBoxResult_ASA = new TextBox();
            labelResult_ASA = new Label();
            buttonDone_ASA = new Button();
            buttonHelp_ASA = new Button();
            groupBoxTask_ASA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ASA).BeginInit();
            groupBoxInPut_ASA.SuspendLayout();
            groupBoxOutPut_ASA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ASA
            // 
            groupBoxTask_ASA.Controls.Add(pictureBoxFormula_ASA);
            groupBoxTask_ASA.Controls.Add(labelTask_ASA);
            groupBoxTask_ASA.Location = new Point(12, 12);
            groupBoxTask_ASA.Name = "groupBoxTask_ASA";
            groupBoxTask_ASA.Size = new Size(496, 150);
            groupBoxTask_ASA.TabIndex = 0;
            groupBoxTask_ASA.TabStop = false;
            groupBoxTask_ASA.Text = "Условие";
            // 
            // pictureBoxFormula_ASA
            // 
            pictureBoxFormula_ASA.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFormula_ASA.Location = new Point(280, 25);
            pictureBoxFormula_ASA.Name = "pictureBoxFormula_ASA";
            pictureBoxFormula_ASA.Size = new Size(200, 105);
            pictureBoxFormula_ASA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_ASA.TabIndex = 1;
            pictureBoxFormula_ASA.TabStop = false;
            // 
            // labelTask_ASA
            // 
            labelTask_ASA.Location = new Point(12, 28);
            labelTask_ASA.Name = "labelTask_ASA";
            labelTask_ASA.Size = new Size(260, 102);
            labelTask_ASA.TabIndex = 0;
            labelTask_ASA.Text = "Дано выражение F(x) = -x^3 + 4x^2 - (3/2)x, вычислить его значение при x = 4, результат вывести в TextBox. Округлить до трёх знаков после запятой.";
            // 
            // groupBoxInPut_ASA
            // 
            groupBoxInPut_ASA.Controls.Add(textBoxVarX_ASA);
            groupBoxInPut_ASA.Controls.Add(labelVarX_ASA);
            groupBoxInPut_ASA.Location = new Point(12, 175);
            groupBoxInPut_ASA.Name = "groupBoxInPut_ASA";
            groupBoxInPut_ASA.Size = new Size(240, 110);
            groupBoxInPut_ASA.TabIndex = 1;
            groupBoxInPut_ASA.TabStop = false;
            groupBoxInPut_ASA.Text = "Ввод данных";
            // 
            // textBoxVarX_ASA
            // 
            textBoxVarX_ASA.Location = new Point(15, 55);
            textBoxVarX_ASA.Name = "textBoxVarX_ASA";
            textBoxVarX_ASA.Size = new Size(120, 27);
            textBoxVarX_ASA.TabIndex = 1;
            textBoxVarX_ASA.Text = "4";
            textBoxVarX_ASA.KeyPress += textBoxVarX_ASA_KeyPress;
            // 
            // labelVarX_ASA
            // 
            labelVarX_ASA.AutoSize = true;
            labelVarX_ASA.Location = new Point(15, 30);
            labelVarX_ASA.Name = "labelVarX_ASA";
            labelVarX_ASA.Size = new Size(105, 20);
            labelVarX_ASA.TabIndex = 0;
            labelVarX_ASA.Text = "Переменная X:";
            // 
            // groupBoxOutPut_ASA
            // 
            groupBoxOutPut_ASA.Controls.Add(textBoxResult_ASA);
            groupBoxOutPut_ASA.Controls.Add(labelResult_ASA);
            groupBoxOutPut_ASA.Location = new Point(268, 175);
            groupBoxOutPut_ASA.Name = "groupBoxOutPut_ASA";
            groupBoxOutPut_ASA.Size = new Size(240, 110);
            groupBoxOutPut_ASA.TabIndex = 2;
            groupBoxOutPut_ASA.TabStop = false;
            groupBoxOutPut_ASA.Text = "Вывод данных";
            // 
            // textBoxResult_ASA
            // 
            textBoxResult_ASA.Location = new Point(15, 55);
            textBoxResult_ASA.Name = "textBoxResult_ASA";
            textBoxResult_ASA.ReadOnly = true;
            textBoxResult_ASA.Size = new Size(210, 27);
            textBoxResult_ASA.TabIndex = 1;
            // 
            // labelResult_ASA
            // 
            labelResult_ASA.AutoSize = true;
            labelResult_ASA.Location = new Point(15, 30);
            labelResult_ASA.Name = "labelResult_ASA";
            labelResult_ASA.Size = new Size(81, 20);
            labelResult_ASA.TabIndex = 0;
            labelResult_ASA.Text = "Результат:";
            // 
            // buttonDone_ASA
            // 
            buttonDone_ASA.Location = new Point(320, 295);
            buttonDone_ASA.Name = "buttonDone_ASA";
            buttonDone_ASA.Size = new Size(188, 38);
            buttonDone_ASA.TabIndex = 3;
            buttonDone_ASA.Text = "Выполнить";
            buttonDone_ASA.UseVisualStyleBackColor = true;
            buttonDone_ASA.Click += buttonDone_ASA_Click;
            // 
            // buttonHelp_ASA
            // 
            buttonHelp_ASA.Location = new Point(268, 295);
            buttonHelp_ASA.Name = "buttonHelp_ASA";
            buttonHelp_ASA.Size = new Size(44, 38);
            buttonHelp_ASA.TabIndex = 4;
            buttonHelp_ASA.Text = "?";
            buttonHelp_ASA.UseVisualStyleBackColor = true;
            buttonHelp_ASA.Click += buttonHelp_ASA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 345);
            Controls.Add(buttonHelp_ASA);
            Controls.Add(buttonDone_ASA);
            Controls.Add(groupBoxOutPut_ASA);
            Controls.Add(groupBoxInPut_ASA);
            Controls.Add(groupBoxTask_ASA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 27 | Андрианов С. А.";
            groupBoxTask_ASA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ASA).EndInit();
            groupBoxInPut_ASA.ResumeLayout(false);
            groupBoxInPut_ASA.PerformLayout();
            groupBoxOutPut_ASA.ResumeLayout(false);
            groupBoxOutPut_ASA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ASA;
        private PictureBox pictureBoxFormula_ASA;
        private Label labelTask_ASA;
        private GroupBox groupBoxInPut_ASA;
        private TextBox textBoxVarX_ASA;
        private Label labelVarX_ASA;
        private GroupBox groupBoxOutPut_ASA;
        private TextBox textBoxResult_ASA;
        private Label labelResult_ASA;
        private Button buttonDone_ASA;
        private Button buttonHelp_ASA;
    }
}