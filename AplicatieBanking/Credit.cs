using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieBanking
{
    public class Credit
    {
        private int id;
        private int idClient;
        private double suma;
        private int durata;
        private double rataDobanda;
        private string tipCredit;
        public static int contor=0;

        public Credit()
        {
            this.id = -1;
            this.idClient = 0;
            this.suma = 0;
            this.durata = 0;
            this.rataDobanda = 0;
        }
        public Credit(int idClient,double suma, int durata, double rataDobanda,string tipCredit)
        {
            this.id = ++contor;
            this.idClient = idClient;
            this.suma = suma;
            this.durata = durata;
            this.rataDobanda = rataDobanda;
            this.tipCredit = tipCredit;
        }

        public double Suma { get => suma; set => suma = value; }
        public int Durata { get => durata; set => durata = value; }
        public double RataDobanda { get => rataDobanda; set => rataDobanda = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public string TipCredit { get => tipCredit; set => tipCredit = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Credit credit &&
                   suma == credit.suma &&
                   durata == credit.durata &&
                   idClient == credit.idClient&&
                   rataDobanda == credit.rataDobanda;
        }

        public override string ToString()
        {
            return suma + " " + durata + " " + rataDobanda;
        }
    }
}
