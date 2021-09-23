using System;

namespace CarApp
{
    public class Car
    {
        public Car(string color, int count, string body)
        {
            _color = color;
            _count = count;
            _body = body;
        }

        private string _color;
        private int _count;
        private string _body;

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value != "Black")
                {
                    _color = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 100)
                {
                    _count = value;
                }
            }
        }

        public string Body
        {
            get
            {
               
                return _body;
            }
            set
            {
                _body = value;
            }
        }
    }
}


