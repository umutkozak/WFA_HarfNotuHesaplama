namespace WFA_HarfNotuHesaplama
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
            txtVize1=new TextBox();
            txtVize2=new TextBox();
            txtFinal=new TextBox();
            btnHesapla=new Button();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            lblHarfnotu=new Label();
            SuspendLayout();
            // 
            // txtVize1
            // 
            txtVize1.Location=new Point(2, 29);
            txtVize1.Name="txtVize1";
            txtVize1.Size=new Size(125, 27);
            txtVize1.TabIndex=0;
            // 
            // txtVize2
            // 
            txtVize2.Location=new Point(159, 29);
            txtVize2.Name="txtVize2";
            txtVize2.Size=new Size(125, 27);
            txtVize2.TabIndex=0;
            // 
            // txtFinal
            // 
            txtFinal.Location=new Point(309, 29);
            txtFinal.Name="txtFinal";
            txtFinal.Size=new Size(125, 27);
            txtFinal.TabIndex=0;
            // 
            // btnHesapla
            // 
            btnHesapla.Location=new Point(2, 74);
            btnHesapla.Name="btnHesapla";
            btnHesapla.Size=new Size(432, 29);
            btnHesapla.TabIndex=1;
            btnHesapla.Text="Harf Notu Hesapla";
            btnHesapla.UseVisualStyleBackColor=true;
            btnHesapla.Click+=btnHesapla_Click;
            // 
            // label1
            // 
            label1.Location=new Point(31, 0);
            label1.Name="label1";
            label1.Size=new Size(62, 25);
            label1.TabIndex=2;
            label1.Text="1.Vize";
            // 
            // label2
            // 
            label2.Location=new Point(190, 0);
            label2.Name="label2";
            label2.Size=new Size(50, 20);
            label2.TabIndex=2;
            label2.Text="2.Vize";
            // 
            // label3
            // 
            label3.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(339, 0);
            label3.Name="label3";
            label3.Size=new Size(50, 20);
            label3.TabIndex=2;
            label3.Text="Final";
            // 
            // lblHarfnotu
            // 
            lblHarfnotu.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHarfnotu.Location=new Point(467, 28);
            lblHarfnotu.Name="lblHarfnotu";
            lblHarfnotu.Size=new Size(216, 75);
            lblHarfnotu.TabIndex=2;
            lblHarfnotu.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(718, 141);
            Controls.Add(lblHarfnotu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHesapla);
            Controls.Add(txtFinal);
            Controls.Add(txtVize2);
            Controls.Add(txtVize1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVize1;
        private TextBox txtVize2;
        private TextBox txtFinal;
        private Button btnHesapla;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblHarfnotu;
    }
}