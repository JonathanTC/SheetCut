using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetCut
{
    public class CollisionBox
    {
        private String _name;
        private int _value;
        private Rectangle _position;
        private Color _color;

        // *** ACCESSEURS ***
        public String Name
        {
            get { return _name; }
        }
        public Rectangle Position { get { return _position; } }
        public int Value
        {
            get { return _value; }
        }
        public Color Color { get { return _color; } set { _color = value; } }
        
        // *** CONSTUCTEURS ***
        public CollisionBox()
        {
            _name = "";
            _value = 0;
        }
        public CollisionBox(String pName, int pValue, Color color)
        {
            _name = pName;
            _value = pValue;
            _color = Color.FromArgb(128, color);
        }

        // *** METHODES ***
        public void setPosition(Point point, Size size)
        {
            _position.Location = point;
            _position.Size = size;
        }
        public String ToString()
        {
            return "name:" + _name + " value:" + _value + "\n\tposition => x:" + _position.X + " y:" + _position.Y + " Width:" + _position.Width + " Height:" + _position.Height;
        }
    }
}
