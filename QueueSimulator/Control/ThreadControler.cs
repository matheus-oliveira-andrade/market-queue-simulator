using QueueSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace QueueSimulator.Control
{
    class ThreadControler
    {
        public List<Thread> ListThreads { get; set; } = new List<Thread>();
        public Fila<int> Queue { get; set; } = new Fila<int>();        

        public ThreadControler()
        {
        }
        public void ThreadFila(ProgressBar progressBar)
        {
            Random r = new Random();

            // Gera 5 valores iniciais na fila
            for (int i = 0; i < 5; i++)
            {
                int valor = r.Next(1, 251);
                // Seta o valor na barra de progresso
                SetPropertys.SetProgressBarUpdate(progressBar, valor);
                // Enfileira
                Queue.Enqueue(valor);
            }
            while (true)
            {
                // Faz a thread dormi por 3 segs
                Thread.Sleep(3000);
                // Gera um número aleatório entre 1 e 99
                int valor = r.Next(1, 251);
                if (progressBar.Value + valor >= progressBar.Maximum)
                {
                    Thread.Sleep(12000);
                }
                // Enfileira 
                Queue.Enqueue(valor);
                // Seta o valor na barra de progresso
                SetPropertys.SetProgressBarUpdate(progressBar, valor);

            }
        }
        public void Caixa(Label lbTot, Label lbRest, int sleep, ProgressBar progressBar)
        {
            Random r = new Random();
            int valorTot = 0, valor = 0;

            // Tempo para a thread dormir por N segs
            Thread.Sleep(sleep * 1000);

            while (true)
            {
                // Se o valor for menor ou igual a 0 
                if (valor <= 0)
                {
                    // Verifica se a fila esta vazia
                    if (Queue.EstaVazio)
                    {
                        // Seta o label total
                        SetPropertys.SetLbTot(lbTot, 0);
                        // Seta o label resto
                        SetPropertys.SetLbRest(lbRest, 0);
                        // Faz a thread dormi por 5 segs
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        // Pega o primeiro valor da fila, o que será retirado 
                        valorTot = Queue.Peek();
                        // Valor que será decrementado recebe o valor pegado da fila
                        valor = valorTot;
                        // Retira o valor da fila
                        Queue.Dequeue();
                        // Decrementa da barra de progresso
                        SetPropertys.SetProgressBarDecrement(progressBar, valor);
                    }
                }

                // Seta o label total
                SetPropertys.SetLbTot(lbTot, valorTot);
                // Seta o label resto
                SetPropertys.SetLbRest(lbRest, valor);
                // Decrementa o valor
                valor--;
                // Faz a thread dormi por 1 segs
                Thread.Sleep(1000);
                // Basicamente diz ao windows que o aplicativo não travou
                Application.DoEvents();
            }
        }

    }
}
