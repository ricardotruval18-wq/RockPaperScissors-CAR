namespace Proyecto.UI
{
    partial class Form3
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

            tableLayoutPanel1 = new TableLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            button3 = new Button();
            button1 = new Button();
            lblResultado = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.jugar;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0000076F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6666813F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.66662F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6666813F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0000076F));
            tableLayoutPanel1.Controls.Add(radioButton3, 3, 1);
            tableLayoutPanel1.Controls.Add(button3, 4, 6);
            tableLayoutPanel1.Controls.Add(radioButton1, 1, 1);
            tableLayoutPanel1.Controls.Add(radioButton2, 2, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 4);
            tableLayoutPanel1.Controls.Add(lblResultado, 2, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.Appearance = Appearance.Button;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.BackgroundImage = Properties.Resources.piedra2;
            radioButton1.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(110, 68);
            radioButton1.Name = "radioButton1";
            tableLayoutPanel1.SetRowSpan(radioButton1, 2);
            radioButton1.Size = new Size(153, 120);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "\r\nPiedra\r\n";
            radioButton1.TextAlign = ContentAlignment.BottomCenter;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.Appearance = Appearance.Button;
            radioButton3.AutoSize = true;
            radioButton3.BackgroundImage = Properties.Resources.nigga;
            radioButton3.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton3.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold);
            radioButton3.Location = new Point(536, 68);
            radioButton3.Name = "radioButton3";
            tableLayoutPanel1.SetRowSpan(radioButton3, 2);
            radioButton3.Size = new Size(152, 120);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "\r\nTijera";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top;
            radioButton2.Appearance = Appearance.Button;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = Properties.Resources.papel3;
            radioButton2.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold);
            radioButton2.Location = new Point(334, 67);
            radioButton2.Name = "radioButton2";
            tableLayoutPanel1.SetRowSpan(radioButton2, 2);
            radioButton2.Size = new Size(131, 120);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "\r\nPapel";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.IndianRed;
            button3.BackgroundImage = Properties.Resources.salir;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            button3.Location = new Point(733, 393);
            button3.Name = "button3";
            button3.Size = new Size(52, 48);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(296, 260);
            button1.Name = "button1";
            button1.Size = new Size(207, 55);
            button1.TabIndex = 4;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(296, 320);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(207, 64);
            lblResultado.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form3";
            Text = "Form3";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button3;
        private Button button1;
        private Label lblResultado;
    }
}