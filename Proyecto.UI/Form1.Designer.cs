namespace Proyecto.UI;

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
        button3 = new Button();
        button1 = new Button();
        button2 = new Button();
        label2 = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // button3
        // 
        button3.Anchor = AnchorStyles.None;
        button3.BackColor = Color.FromArgb(238, 82, 83);
        button3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
        button3.Location = new Point(399, 438);
        button3.Name = "button3";
        button3.Size = new Size(285, 81);
        button3.TabIndex = 2;
        button3.Text = "Salir";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.None;
        button1.BackColor = Color.FromArgb(243, 156, 18);
        button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(397, 264);
        button1.Name = "button1";
        button1.Size = new Size(288, 81);
        button1.TabIndex = 3;
        button1.Text = "Entrenar";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Anchor = AnchorStyles.None;
        button2.BackColor = Color.FromArgb(76, 209, 55);
        button2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
        button2.Location = new Point(399, 351);
        button2.Name = "button2";
        button2.Size = new Size(285, 81);
        button2.TabIndex = 4;
        button2.Text = "Jugar";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(label2, 3);
        label2.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(278, 54);
        label2.Name = "label2";
        tableLayoutPanel1.SetRowSpan(label2, 2);
        label2.Size = new Size(529, 65);
        label2.TabIndex = 6;
        label2.Text = "Piedra, Papel o Tijera";
        label2.Click += label2_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackgroundImage = Properties.Resources.fondo;
        tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel1.Controls.Add(label2, 0, 0);
        tableLayoutPanel1.Controls.Add(button3, 1, 5);
        tableLayoutPanel1.Controls.Add(button2, 1, 4);
        tableLayoutPanel1.Controls.Add(button1, 1, 3);
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
        tableLayoutPanel1.Size = new Size(1085, 614);
        tableLayoutPanel1.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.Fortnite;
        ClientSize = new Size(1085, 614);
        Controls.Add(tableLayoutPanel1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Button button3;
    private Button button1;
    private Button button2;
    private Label label2;
    private TableLayoutPanel tableLayoutPanel1;
}
