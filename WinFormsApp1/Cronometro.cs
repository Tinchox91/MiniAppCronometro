using System;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

public class Cronometro
{
    private Stopwatch stopwatch;
    private Timer timer;
    private Label lblSegundos;
    private Label lblMilisegundos;
    private Label lblMinutos;
    public event Action<int, int, int> TiempoActualizado; 

    public Cronometro(Label minutos, Label segundos, Label milisegundos)
    {
        lblMinutos = minutos;
        lblSegundos = segundos;
        lblMilisegundos = milisegundos;

        stopwatch = new Stopwatch();

        timer = new Timer();
        timer.Interval = 10; 
        timer.Tick += Timer_Tick;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        lblMinutos.Text = GetMinutos().ToString("00");
        lblSegundos.Text = GetSegundos().ToString("00");
        lblMilisegundos.Text = GetMilisegundos().ToString("000");
    }

   
    public void Iniciar()
    {
        stopwatch.Start();
        timer.Start();
    }

  
    public void Pausar()
    {
        stopwatch.Stop();
        timer.Stop();
    }

    
    public void Reiniciar()
    {
        stopwatch.Reset();
        lblMinutos.Text = "00";
        lblSegundos.Text = "00";
        lblMilisegundos.Text = "00";
    }

    public int GetMinutos()
    {
        return stopwatch.Elapsed.Minutes;
    }

  
    public int GetSegundos()
    {
        return stopwatch.Elapsed.Seconds;
    }

 
    public int GetMilisegundos()
    {
        return stopwatch.Elapsed.Milliseconds;
    }
}
