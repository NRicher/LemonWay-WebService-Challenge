using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Option2
{
    public partial class Form_Main : Form
    {
        private localhost.LemonWay lemonWay = new localhost.LemonWay();
        private Form BusyForm = new Form()
        { Text = "Calculation Fibonacci", CancelButton = null, ControlBox = false };

        public Form_Main()
        {
            InitializeComponent();
        }            

        /// <summary>
        /// Event called when clicking on FibonacciButton
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arguments</param>
        private async void FibonacciButton_Clicked(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => BusyForm.ShowDialog()));
            string FibonacciResult = (await DoWork()).ToString();
            BusyForm.Hide();
            MessageBox.Show(FibonacciResult);
        }

        /// <summary>
        /// call the lemonWay.Fibonacci web method
        /// </summary>
        /// <returns>result of Fibonacci</returns>
        private async Task<int> DoWork()
        {
            return await Task.Run(() =>
             lemonWay.Fibonacci(10));
        }

    }
}
