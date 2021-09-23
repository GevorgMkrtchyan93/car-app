using System;

namespace CarApp
{
    public class Bmw : Car
    {
        public Bmw(string color,int count,string body,string name, string audioSystem) : base("Blue", 75, "Crossover")
        {
            _color = color;
            _count = count;
            _body = body;
            _name = name;
            _audioSystem = audioSystem;
        }

        private string _name;
        public string _audioSystem;
        private int _count;
        public string _color;
        private string _body;
    }
}
