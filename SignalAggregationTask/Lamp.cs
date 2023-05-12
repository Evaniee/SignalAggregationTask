using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalAggregationTask
{
    class Lamp
    {
        private Color _colour;              // Lamp's colour
        private bool _status;               // true = ON, false = OFF
        private Rectangle _position;        // Lamp's position

        public Lamp(Color colour, int x, int y)
        {
            _status = false;                                // Initially off
            _colour = colour;                               // Sets lamp's colour
            _position = new Rectangle(x, y, 50, 50);        // Lamp's position
        }

        public bool Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public void display(Graphics g)
        {
            SolidBrush myBrush;
            if (_status)
            {
                myBrush = new SolidBrush(_colour);
            }
            else
            {
                myBrush = new SolidBrush(Color.Gray);
            }
            g.FillEllipse(myBrush, _position);
        }
    }
}
