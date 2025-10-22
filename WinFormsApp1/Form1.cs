using MiniApp;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Cronometro cronometro;
        private bool corriendo = false;
        public Form1()
        {
            InitializeComponent();

            cronometro = new Cronometro(label1, label2, label3);
            cronometro.TiempoActualizado += ActualizarEtiqueta;
        }

        private void ActualizarEtiqueta(int minutos, int segundos, int milisegundos)
        {
            label1.Text = minutos.ToString("00");
            label2.Text = segundos.ToString("00");
            label3.Text = milisegundos.ToString("000");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (!corriendo)
            {
                cronometro.Iniciar();
                boton_Iniciar.Text = "Pausar";
                corriendo = true;
            }
            else
            {
                cronometro.Pausar();
                boton_Iniciar.Text = "Iniciar";
                corriendo = false;
            }
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            boton_Iniciar.ForeColor = Color.YellowGreen;
        }

        private void boton_Iniciar_MouseLeave(object sender, EventArgs e)
        {
            boton_Iniciar.ForeColor = Color.Lime;
        }

        private void boton_Reinciciar_Click(object sender, EventArgs e)
        {
            cronometro.Reiniciar();
            corriendo = false;
            boton_Iniciar.Text = "Iniciar";
        }

        private void boton_Reinciciar_MouseHover(object sender, EventArgs e)
        {
            boton_Reinciciar.ForeColor = Color.YellowGreen;
        }

        private void boton_Reinciciar_MouseLeave(object sender, EventArgs e)
        {
            boton_Reinciciar.ForeColor = Color.Lime;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            boton_Reinciciar.ForeColor = Color.YellowGreen;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            boton_Reinciciar.ForeColor = Color.Lime;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            boton_Iniciar.ForeColor = Color.YellowGreen;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            boton_Iniciar.ForeColor = Color.Lime;
        }
    }
}
