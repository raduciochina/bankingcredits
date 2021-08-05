using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieBanking
{
   public  class Client: Persoana, ICloneable,IComparable
    {
        private string nume;
        private string stareCivila;
        private double salariu;
        public static int contor = 0;
       
        public Client()
        {
            this.id = -1;
            this.nume = "Default";
            this.dataNasterii = DateTime.Now;
            this.sex = 'M';
            this.stareCivila = "Necasatorit";
            this.salariu = 0;
        }
        public Client(string nume, DateTime dataNasterii, char sex, string stareCivila, double salariu)
        {
            this.id = (contor++);
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.sex = sex;
            this.stareCivila = stareCivila;
            this.salariu = salariu;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public char Sex { get => sex; set => sex = value; }
        public string StareCivila { get => stareCivila; set => stareCivila = value; }
        public double Salariu { get => salariu; set => salariu = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            return this.CompareTo(obj);
        }

        public override string ToString()
        {
            return this.Id + " " + this.Nume + " "  + this.SpuneVarsta() + " ani " + this.Salariu + " " + this.Sex + " " + this.StareCivila;
        }

        public override int SpuneVarsta()
        {
            return (System.Convert.ToInt32((System.DateTime.Now.Date - this.dataNasterii.Date).TotalDays) / 365);
        }


    }
}
