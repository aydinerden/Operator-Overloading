using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Complex
    {
        private float _real;
        private float _img;

        public float Real
        {
            get
            {
                return _real;
            }
            set
            {
                _real = value;
            }
        }

        public float Imaginary
        {
            get
            {
                return _img;
            }
            set
            {
                _img = value;
            }
        }

        public Complex(float real,float img)
        {
            this._real = real;
            this._img = img;
        }

        public override string ToString()
        {
            string temp = "";

            if (_img >= 0)
            {
                temp = $"{this._real} + i{this._img}";
            }
            else
            {
                temp = $"{this._real} - i{Math.Abs(this._img)}";

            }

            return temp;
        }

        public static Complex operator +(Complex lhs, Complex rhs)
        {
            return new Complex((lhs.Real+rhs.Real), (lhs.Imaginary+rhs.Imaginary));
        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            return new Complex((lhs.Real-rhs.Real),(lhs.Imaginary-rhs.Imaginary));
        }

        public static explicit operator Complex(float from)
        {
            return new Complex(from, 0.0f);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Real == rhs.Real;
        }

        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.Real!= rhs.Real;
        }

        public static Complex operator ++(Complex x)
        {
            x.Real++;
            x.Imaginary+=20;
            return x;
        }
    }
}
