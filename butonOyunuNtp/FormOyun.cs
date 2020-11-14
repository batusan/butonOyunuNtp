using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butonOyunuNtp
{
    public partial class FormOyun : Form
    {
        static int sonuc, sure = 15;

        Random rnd = new Random();
        public FormOyun()
        {
            InitializeComponent();
            label1.Text = "Puan";
            label2.Text = "Süre";
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Dispose();

            sonuc += int.Parse(b.Text);
            label1.Text = $"Puan = {sonuc}";

        }

        private void tmr_sure_Tick(object sender, EventArgs e)
        {
            if (sure == 0)
            {
                tmr_game.Stop();
                tmr_sure.Stop();

                MessageBox.Show($"Oyun bitti puanınız: {sonuc}");
                DialogResult popupMessage = MessageBox.Show("Tekrar Oynamak İster misiniz ?", "Tekrar Oyna", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (popupMessage == DialogResult.No)
                {

                    FileStream fs = new FileStream("D:\\rekorlar.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    using (StreamWriter wr = new StreamWriter(fs))
                    {
                        wr.WriteLine($"{DateTime.Now} tarihli elde ettiğiniz skor :  {sonuc}");
                        wr.Close();
                    }
                    this.Close();
                }
                else
                {
                    tmr_game.Stop();
                    tmr_game.Start();
                    tmr_sure.Stop();
                    tmr_sure.Start();
                    sure = 15;
                    sonuc = 0;
                    label1.Text = "Puan";
                    label2.Text = "Süre";
                }
            }
            else
            {
                sure--;
                label2.Text = sure.ToString();
            }
        }

        private void tmr_game_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(70, 35);
            btn.Text = rnd.Next(100).ToString();
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlPuan.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            this.Controls.Add(btn);
            btn.Click += btnClick;
        }

        private void FormOyun_Load(object sender, EventArgs e)
        {
            tmr_game.Start();
            tmr_sure.Start();
        }

    }
}
