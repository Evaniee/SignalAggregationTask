namespace SignalAggregationTask
{
    public partial class Form1 : Form
    {
        private TrafficLight _trafficLight1;        // MODIFIED: First traffic light
        private TrafficLight _trafficLight2;        // ADDED: Second traffic light

        public Form1()
        {
            InitializeComponent();

            _trafficLight1 = new TrafficLight(10, 10, 0);       // MODIFIED: New traffic light drawn at X10 Y10 in state 0 (RED)
            _trafficLight2 = new TrafficLight(110, 10, 2);      // ADDED: Second traffic light drawn at X60 Y10 in state 2 (GREEN)
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _trafficLight1.displayLights(g);
            _trafficLight2.displayLights(g);        // ADDED
        }

        private void tmr_changeLights_Tick(object sender, EventArgs e)
        {
            // Change the light to the next state
            _trafficLight1.changeLights();
            _trafficLight2.changeLights();      // ADDED
            pictureBox1.Invalidate();
        }
    }
}