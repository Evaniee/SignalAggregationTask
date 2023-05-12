using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalAggregationTask
{
    public class SignalBox
    {
        private Lamp _redLamp;          // Red lamp of signal box
        private Lamp _greenLamp;        // Green Lamp of signal box
        private int _state;             // Which state is the signal box in (See changeLights)

        public SignalBox(int x, int y, int state)
        {
            // Create lamps
            _redLamp = new Lamp(Color.Red, x, y);
            _greenLamp = new Lamp(Color.LightGreen, x, y + 50); // Note: y is offset by 50 to draw lamp directly below red
            _state = state;
        }

        public int changeLights()
        {
            switch (_state)
            {
                case 0:
                    _redLamp.Status = true;
                    _greenLamp.Status = false;
                    _state = 1;
                    break;
                case 1:
                    _redLamp.Status = false;
                    _greenLamp.Status = true;
                    _state = 0;
                    break;
            }
            return _state;
        }

        public void displayLights(Graphics g)
        {
            _redLamp.display(g);
            _greenLamp.display(g);
        }
    }
}
