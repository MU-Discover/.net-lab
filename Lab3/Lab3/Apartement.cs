using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Apartement
    {
        protected int apart_NO;
        protected string apart_TYPE;

        //constructors
        public Apartement() { }

        public Apartement(int apart_NO, string apart_TYPE)
        {
            this.apart_NO = apart_NO;
            this.apart_TYPE = apart_TYPE;
        }
        public int getApartNo()
        {
            return this.apart_NO;
        }
        public string getAPartType()
        {
            return this.apart_TYPE;
        }
        public void setApartNO(int apart_NO)
        {
            this.apart_NO = apart_NO;
        }
        public void setApartType(string apart_TYPE)
        {
            this.apart_TYPE = apart_TYPE;
        }
        public void toString()
        {
            Console.WriteLine("Apartement NO: {0}, Apartement TYPE: {1}", this.apart_NO, this.apart_TYPE);
        }

    }
}
