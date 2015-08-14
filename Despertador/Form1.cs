using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despertador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string inicioExpediente = "Horsssario dass Manha";
        string almoco = "Horario da Manha";
        string voltaAlmoco = "Horario da Manha";
        string fimExpediente = "Horario da Manha";

        #region Comportamento
        private void msgAlerta()
        {
            notifyIcon1.BalloonTipTitle = "Alerta de Ponto";
            notifyIcon1.BalloonTipText = "Esta na hora de baater o ponto";
            notifyIcon1.ShowBalloonTip(15000);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string horario = DateTime.Now.ToLongTimeString();
            lblresultadoOk.Text = horario;

            switch (horario)
            {
                case "08:10:00":
                    {
                        
                        msgAlerta();
                        SoundPlayer alertaSonoro = new SoundPlayer(@"C:\Users\paulo.gualter\Desktop\Despertador\Despertador\mensagem.mp3");
                        alertaSonoro.Play();

                        break;
                    }
                case "11:50:00":
                    {

                        msgAlerta();
                        SoundPlayer alertaSonoro = new SoundPlayer();
                        alertaSonoro.Play();

                        break;
                    }
                case "12:48:00":
                    {

                        msgAlerta();
                        SoundPlayer alertaSonoro = new SoundPlayer();
                        alertaSonoro.Play();

                        break;
                    }
                case "17:53:00":
                    {

                        msgAlerta();
                        SoundPlayer alertaSonoro = new SoundPlayer(@"C:\Suporte\mensagem.wav");
                        alertaSonoro.Play();

                        break;
                    }
            }
        }
        #endregion

        #region Menus

        private void menuRestaurar_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            frmsobre sobre = new frmsobre();
            sobre.Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        #endregion

        #region Formulario

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }
            else
            {
                notifyIcon1.Visible = false;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer alertaSonoro = new SoundPlayer();
            alertaSonoro.Play();
        }

        #endregion


    }
}
