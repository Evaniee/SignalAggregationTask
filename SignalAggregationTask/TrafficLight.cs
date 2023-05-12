using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalAggregationTask
{
    // NOTE: Modified version of SignalBox all SignalBox has become TrafficLight
    public class TrafficLight
    {
        private Lamp _redLamp;          // Red lamp of traffic light
        private Lamp _yellowLamp;       // ADDED: Yellow lamp of Traffic Light
        private Lamp _greenLamp;        // Green Lamp of traffic light

        private int _state;             // Which state is the traffic light in (See changeLights)

        // MODIFIED
        public TrafficLight(int x, int y, int state)
        {
            // Create lamps
            _redLamp = new Lamp(Color.Red, x, y);                       
            _yellowLamp = new Lamp(Color.Yellow, x, y + 50);            // ADDED: y is now offset by 50 to draw lamp directly below red
            _greenLamp = new Lamp(Color.LightGreen, x, y + 100);        // MOFIDIED: y is now offset by 100 to draw lamp directly below yellow
            _state = state;
        }

        // MODIFIED, changed states to reflect traffic light, added 2 more
        public int changeLights()
        {
            switch (_state)
            {
                case 0:     // MODIFIED
                    _redLamp.Status = true;
                    _yellowLamp.Status = false;
                    _greenLamp.Status = false;
                    _state = 1;
                    break;
                case 1:     // MODIFIED
                    _redLamp.Status = true;
                    _yellowLamp.Status = true;
                    _greenLamp.Status = false;
                    _state = 2;
                    break;
                case 2:     // ADDED
                    _redLamp.Status = false;
                    _yellowLamp.Status = false;
                    _greenLamp.Status = true;
                    _state = 3;
                    break;
                case 3:     // ADDED
                    _redLamp.Status = false;
                    _yellowLamp.Status = true;
                    _greenLamp.Status = false;
                    _state = 0;
                    break;
            }
            return _state;
        }

        // MODIFIED
        public void displayLights(Graphics g)
        {
            _redLamp.display(g);
            _yellowLamp.display(g);     // ADDED
            _greenLamp.display(g);
        }
    }
}
