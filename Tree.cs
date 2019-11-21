using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSUTreeAdmin
{
    public class Tree
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private int _treetype;

        public int Treetype
        {
            get { return _treetype; }
            set { _treetype = value; }
        }
        private double _age;

        public double Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        private double _diameter;

        public double Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }
    }
}
