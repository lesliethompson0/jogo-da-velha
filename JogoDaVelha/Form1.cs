using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        string simbolo = "X";
        string[,] dados = new string[3, 3];
        public Form1()
        {
            InitializeComponent();
            //    MessageBox.Show("Bem Vindo ao nosso jogo da velha");
        }

        private void btnLinha1Coluna1_Click(object sender, EventArgs e)
        {
            //só entra no botão se o botão estiver vazio
            if (btnLinha1Coluna1.Text == "")
            {

                //PREENCHE O SÍMBOLO
                btnLinha1Coluna1.Text = simbolo;

                //DEFINIR A POSIÇÃO DO SÍMBOLO NA MATRIZ
                dados[0, 0] = simbolo;

                //identificar vencedor (invocar vencedor)
                IdentificarVencedor();

                //preparar para o próximo jogador
                MudarJogador();
            }
        }

        private void btnLinha1Coluna2_Click(object sender, EventArgs e)
        {
            if (btnLinha1Coluna2.Text == "")
            {
                btnLinha1Coluna2.Text = simbolo;
                dados[0, 1] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }
        private void btnLinha1Coluna3_Click(object sender, EventArgs e)
        {
            if (btnLinha1Coluna3.Text == "")
            {
                btnLinha1Coluna3.Text = simbolo;
                dados[0, 2] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }

        private void btnLinha2Coluna1_Click(object sender, EventArgs e)
        {
            if (btnLinha2Coluna1.Text == "")
            {
                btnLinha2Coluna1.Text = simbolo;
                dados[1, 0] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }

        private void btnLinha2Coluna2_Click(object sender, EventArgs e)
        {
            if (btnLinha2Coluna2.Text == "")
            {

                btnLinha2Coluna2.Text = simbolo;
                dados[1, 1] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }

        private void btnLinha2Coluna3_Click(object sender, EventArgs e)
        {
            if (btnLinha2Coluna3.Text == "")
            {
                btnLinha2Coluna3.Text = simbolo;
                dados[1, 2] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }

        private void btnLinha3Coluna1_Click(object sender, EventArgs e)
        {
            if (btnLinha3Coluna1.Text == "")
            {
                btnLinha3Coluna1.Text = simbolo;
                dados[2, 0] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }

        private void btnLinha3Coluna2_Click(object sender, EventArgs e)
        {
            if (btnLinha3Coluna2.Text == "")
            {
                btnLinha3Coluna2.Text = simbolo;
                dados[2, 1] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }

        private void btnLinha3Coluna3_Click(object sender, EventArgs e)
        {
            if (btnLinha3Coluna3.Text == "")
            {
                btnLinha3Coluna3.Text = simbolo;
                dados[2, 2] = simbolo;
                IdentificarVencedor();
                MudarJogador();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            dados = new string[3, 3];
            lblJogador.Text = "Jogador 1";
            simbolo = "X";

            btnLinha1Coluna1.Text = btnLinha1Coluna2.Text = btnLinha1Coluna3.Text = "";
            btnLinha2Coluna1.Text = btnLinha2Coluna2.Text = btnLinha2Coluna3.Text = "";
            btnLinha3Coluna1.Text = btnLinha3Coluna2.Text = btnLinha3Coluna3.Text = "";
        }

        private bool IdentificarVencedor()
        {
            bool venceu;
            //horizontal
            if ((dados[0, 0] == dados[0, 1]) && (dados[0, 0] == dados[0, 2]) && !String.IsNullOrWhiteSpace(dados[0, 0]))
            {
                venceu = true;
            }
            else if ((dados[1, 0] == dados[1, 1]) && (dados[1, 0] == dados[1, 2]) && !String.IsNullOrWhiteSpace(dados[1, 0]))
            {
                venceu = true;
            }
            else if ((dados[2, 0] == dados[2, 1]) && (dados[2, 0] == dados[2, 2]) && !String.IsNullOrWhiteSpace(dados[2, 0]))
            {
                venceu = true;
            }

            //vertical
            else if ((dados[0, 0] == dados[1, 0]) && (dados[0, 0] == dados[2, 0]) && !String.IsNullOrWhiteSpace(dados[0, 0]))
            {
                venceu = true;
            }
            else if ((dados[0, 1] == dados[1, 1]) && (dados[0, 1] == dados[2, 1]) && !String.IsNullOrWhiteSpace(dados[0, 1]))
            {
                venceu = true;
            }
            else if ((dados[0, 2] == dados[1, 2]) && (dados[0, 2] == dados[2, 2]) && !String.IsNullOrWhiteSpace(dados[0, 2]))
            {
                venceu = true;
            }

            //diagonal esquerda para direita
            else if ((dados[0, 0] == dados[1, 1]) && (dados[0, 0] == dados[2, 2]) && !String.IsNullOrWhiteSpace(dados[0, 0]))
            {
                venceu = true;
            }
            //diagonal direita para esquerda
            else if ((dados[0, 2] == dados[1, 1]) && (dados[0, 2] == dados[2, 0]) && !String.IsNullOrWhiteSpace(dados[0, 2]))
            {
                venceu = true;
            }
            else
            {
                venceu = false;
            }


            if (venceu)
            {
                MessageBox.Show(lblJogador.Text + " é o vencedor.");
                btnRestart_Click(null, null);
            }
            else if (
                !String.IsNullOrWhiteSpace(dados[0, 0]) &&
                !String.IsNullOrWhiteSpace(dados[0, 1]) &&
                !String.IsNullOrWhiteSpace(dados[0, 2]) &&
                !String.IsNullOrWhiteSpace(dados[1, 0]) &&
                !String.IsNullOrWhiteSpace(dados[1, 1]) &&
                !String.IsNullOrWhiteSpace(dados[1, 2]) &&
                !String.IsNullOrWhiteSpace(dados[2, 0]) &&
                !String.IsNullOrWhiteSpace(dados[2, 1]) &&
                !String.IsNullOrWhiteSpace(dados[2, 2])
                )
            {
                MessageBox.Show("Deu velha!");
            }
            return venceu;
        }

        private void MudarJogador()
        {
            if (simbolo == "X")
            {
                simbolo = "O"; lblJogador.Text = "Jogador 2";
            }
            else
            {
                simbolo = "X"; lblJogador.Text = "Jogador 1";
            }
        }
    }
}