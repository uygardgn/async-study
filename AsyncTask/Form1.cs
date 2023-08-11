using System.Diagnostics;

namespace AsyncTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;

            StartTheCar();
            SetGear();
            GasPedal();
            MoveForward();
            StopTheCar();
            SwitchOff();

            DateTime endtDate = DateTime.Now;

            listBox.Items.Add("Duration :"+(endtDate-startDate).TotalMilliseconds);
            listBox.Items.Add("****************");
        }

        // Button for ASYNC
        private async void btnCalistirASYNC_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;

            await StartTheCarAsync();
            await SetGearAsync();
            await GasPedalAsync();
            await MoveForwardAsync();
            await StopTheCarAsync();
            await SwitchOffAsync();

            DateTime endtDate = DateTime.Now;

            listBox.Items.Add("Duration :" + (endtDate - startDate).TotalMilliseconds);
            listBox.Items.Add("****************");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        #region Senkron Metotlar
        public void StartTheCar()
        {
            Task.Delay(1000).Wait();
            listBox.Items.Add("Engine has started.");
        }
        public void SetGear()
        {
            Task.Delay(1750).Wait();
            listBox.Items.Add("Gear adjusted.");
        }
        public void GasPedal()
        {
            Task.Delay(1500).Wait();
            listBox.Items.Add("Gas pedal has been pressed.");
        }
        public void MoveForward()
        {
            Task.Delay(1000).Wait();
            listBox.Items.Add("Car is moving.");
        }
        
        public void StopTheCar()
        {
            Task.Delay(1800).Wait();
            listBox.Items.Add("Engine has stopped.");
        }

        public void SwitchOff()
        {
            Task.Delay(1800).Wait();
            listBox.Items.Add("Ignition has switched off.");
        }
        #endregion

        #region ASYNC Metotlar

        public async Task StartTheCarAsync()
        {
            await Task.Delay(1000);
            listBox.Items.Add("Engine has started.");
        }
        public async Task SetGearAsync()
        {
            await Task.Delay(1750);
            listBox.Items.Add("Gear adjusted.");
        }
        public async Task GasPedalAsync()
        {
            await Task.Delay(1500);
            listBox.Items.Add("Gas pedal has been pressed.");
        }
        public async Task MoveForwardAsync()
        {
            await Task.Delay(1000);
            listBox.Items.Add("Car is moving.");
        }

        public async Task StopTheCarAsync()
        {
            await Task.Delay(1800);
            listBox.Items.Add("Engine has stopped.");
        }

        public async Task SwitchOffAsync()
        {
            await Task.Delay(1800);
            listBox.Items.Add("Ignition has switched off.");
        }
        #endregion
    }
}