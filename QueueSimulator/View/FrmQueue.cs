using QueueSimulator.Control;
using System;
using System.Threading;
using System.Windows.Forms;

namespace QueueSimulator
{
    public partial class FrmQueue : Form
    {
        private ThreadControler tc = new ThreadControler();

        public FrmQueue()
        {
            InitializeComponent();
        }
        
        
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Inicia todas as threads
            tc.ListThreads.ForEach(t => t.Start());
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            // Para o que a thread esta fazendo
            tc.ListThreads.ForEach(t => t.Abort());
            // Fecha a aplicação
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        
            Random r = new Random();
           
            tc.ListThreads.Add(new Thread(() => { tc.ThreadFila(progressBarFila); }));
            // Threads Caixas
            tc.ListThreads.Add(new Thread(() => { tc.Caixa(lblCx1Tot, lblCx1Rest, r.Next(1, 15), progressBarFila); }));
            tc.ListThreads.Add(new Thread(() => { tc.Caixa(lblCx2Tot, lblCx2Rest, r.Next(1, 15), progressBarFila); }));
            tc.ListThreads.Add(new Thread(() => { tc.Caixa(lblCx3Tot, lblCx3Rest, r.Next(1, 15), progressBarFila); }));
            tc.ListThreads.Add(new Thread(() => { tc.Caixa(lblCx4Tot, lblCx4Rest, r.Next(1, 15), progressBarFila); }));
            tc.ListThreads.Add(new Thread(() => { tc.Caixa(lblCx5Tot, lblCx5Rest, r.Next(1, 15), progressBarFila); }));            
        }
    }
}
