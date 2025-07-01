using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        private string soyad;
        private int id;
        private string numara;
        private string fotograf;
        private double bakiye;
        private string sifre;

        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }

        public string SOYAD {

            get { return soyad; }
            set { soyad = value; }
        }
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NUMARA
        {
            get { return numara; }
            set { numara = value; }
        }

        public string FOTOGRAF
        {
            get { return fotograf; }
            set { fotograf = value; }
        }

        public double BAKIYE
        {
            get { return bakiye; }
            set { bakiye = value; }
        }

        public string SIFRE {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
