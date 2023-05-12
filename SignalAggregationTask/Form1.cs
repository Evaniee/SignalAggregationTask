namespace SignalAggregationTask
{
    public partial class Form1 : Form
    {
        private SignalBox _signalBox;       // Signal Box

        public Form1()
        {
            InitializeComponent();

            _signalBox = new SignalBox(10, 10, 0);      // New signal box drawn at X10 Y10 in state 0
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _signalBox.displayLights(g);
        }

        private void tmr_changeLights_Tick(object sender, EventArgs e)
        {
            // Change the light to the next state
            _signalBox.changeLights();
            pictureBox1.Invalidate();
        }
    }
}