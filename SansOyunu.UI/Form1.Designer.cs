namespace SansOyunu.UI
{
    partial class Form1
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
            lblBaslik = new Label();
            cmbSecim = new ComboBox();
            btnOyna = new Button();
            btnTekrar = new Button();
            listBoxSonuclar = new ListBox();
            lblSonuc = new Label();
            groupBoxSecim = new GroupBox();
            pbZar = new PictureBox();
            groupBoxSecim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbZar).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.Gold;
            lblBaslik.Location = new Point(250, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(418, 50);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Büyük Şans Oyunu! 🎲";
            // 
            // cmbSecim
            // 
            cmbSecim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSecim.Font = new Font("Segoe UI", 12F);
            cmbSecim.Location = new Point(20, 40);
            cmbSecim.Name = "cmbSecim";
            cmbSecim.Size = new Size(200, 36);
            cmbSecim.TabIndex = 0;
            // 
            // btnOyna
            // 
            btnOyna.BackColor = Color.Gold;
            btnOyna.FlatStyle = FlatStyle.Flat;
            btnOyna.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOyna.Location = new Point(240, 40);
            btnOyna.Name = "btnOyna";
            btnOyna.Size = new Size(170, 40);
            btnOyna.TabIndex = 1;
            btnOyna.Text = "Hadi Oyna! 🎰";
            btnOyna.UseVisualStyleBackColor = false;
            btnOyna.Click += btnOyna_Click;
            // 
            // btnTekrar
            // 
            btnTekrar.BackColor = Color.Silver;
            btnTekrar.FlatStyle = FlatStyle.Flat;
            btnTekrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTekrar.Location = new Point(416, 40);
            btnTekrar.Name = "btnTekrar";
            btnTekrar.Size = new Size(204, 40);
            btnTekrar.TabIndex = 2;
            btnTekrar.Text = "Yeniden Dene 🔄";
            btnTekrar.UseVisualStyleBackColor = false;
            btnTekrar.Click += btnTekrar_Click;
            // 
            // listBoxSonuclar
            // 
            listBoxSonuclar.BackColor = Color.Navy;
            listBoxSonuclar.Font = new Font("Segoe UI", 12F);
            listBoxSonuclar.ForeColor = Color.White;
            listBoxSonuclar.ItemHeight = 28;
            listBoxSonuclar.Location = new Point(100, 177);
            listBoxSonuclar.Name = "listBoxSonuclar";
            listBoxSonuclar.Size = new Size(631, 116);
            listBoxSonuclar.TabIndex = 2;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSonuc.ForeColor = Color.Yellow;
            lblSonuc.Location = new Point(100, 350);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 41);
            lblSonuc.TabIndex = 3;
            // 
            // groupBoxSecim
            // 
            groupBoxSecim.Controls.Add(cmbSecim);
            groupBoxSecim.Controls.Add(btnOyna);
            groupBoxSecim.Controls.Add(btnTekrar);
            groupBoxSecim.Font = new Font("Segoe UI", 14F);
            groupBoxSecim.ForeColor = Color.White;
            groupBoxSecim.Location = new Point(100, 80);
            groupBoxSecim.Name = "groupBoxSecim";
            groupBoxSecim.Size = new Size(631, 91);
            groupBoxSecim.TabIndex = 1;
            groupBoxSecim.TabStop = false;
            groupBoxSecim.Text = "Seçimini Yap ve Şansını Dene!";
            // 
            // pbZar
            // 
            pbZar.Image = Properties.Resources.istockphoto_1336400835_612x612;
            pbZar.Location = new Point(611, 299);
            pbZar.Name = "pbZar";
            pbZar.Size = new Size(120, 120);
            pbZar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZar.TabIndex = 4;
            pbZar.TabStop = false;
            // 
            // Form1
            // 
            BackColor = Color.DarkBlue;
            ClientSize = new Size(742, 434);
            Controls.Add(lblBaslik);
            Controls.Add(groupBoxSecim);
            Controls.Add(listBoxSonuclar);
            Controls.Add(lblSonuc);
            Controls.Add(pbZar);
            Name = "Form1";
            Text = "Şans Oyunu";
            groupBoxSecim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbZar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private ComboBox cmbSecim;
        private Button btnOyna;
        private Button btnTekrar;
        private ListBox listBoxSonuclar;
        private Label lblSonuc;
        private GroupBox groupBoxSecim;
        private PictureBox pbZar;
    }
}
