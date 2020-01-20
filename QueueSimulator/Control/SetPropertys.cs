using System.Windows.Forms;

namespace QueueSimulator.Model
{
    class SetPropertys
    {
        private static void UpdateLabelTot(Label lbTot, int valorTot)
        {
            lbTot.Text = valorTot.ToString();
        }
        private static void UpdateLabelRest(Label lbRest, int valor)
        {
            lbRest.Text = valor.ToString();
        }
        private static void UpdateProgressBar(ProgressBar progressBar, int valor)
        {
            progressBar.Value += valor;
        }
        private static void DecrementProgressBar(ProgressBar progressBar, int valor)
        {
            progressBar.Value -= valor;
        }
        public static void SetProgressBarDecrement(ProgressBar pb, int valor)
        {
            if (pb.InvokeRequired)
            {
                MethodInvoker m = new MethodInvoker(() => DecrementProgressBar(pb, valor));
                pb.Invoke(m);
            }
            else
            {
                DecrementProgressBar(pb, valor);
            }
        }
        public static void SetProgressBarUpdate(ProgressBar pb, int valor)
        {
            if (pb.InvokeRequired)
            {
                MethodInvoker m = new MethodInvoker(() => UpdateProgressBar(pb, valor));
                pb.Invoke(m);
            }
            else
            {
                UpdateProgressBar(pb, valor);
            }
        }
        public static void SetLbTot(Label lbTot, int valorTot)
        {
            if (lbTot.InvokeRequired)
            {
                MethodInvoker m = new MethodInvoker(() => UpdateLabelTot(lbTot, valorTot));
                lbTot.Invoke(m);
            }
            else
            {
                UpdateLabelTot(lbTot, valorTot);
            }
        }
        public static void SetLbRest(Label lbRest, int valor)
        {
            if (lbRest.InvokeRequired)
            {
                MethodInvoker m = new MethodInvoker(() => UpdateLabelRest(lbRest, valor));
                lbRest.Invoke(m);
            }
            else
            {
                UpdateLabelRest(lbRest, valor);
            }
        }
    }
}
