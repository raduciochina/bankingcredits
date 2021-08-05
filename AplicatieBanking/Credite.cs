using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieBanking
{
    public class Credite
    {
            public Dictionary<int, Credit> credite = new Dictionary<int, Credit>();
        public Credite()
        {
            
        }
        public Credite(Dictionary<int, Credit> credite)
            {
                this.credite = credite;
            }

            public override string ToString()
            {
                string rezultat = "";
                foreach (Credit aux in credite.Values)
                {
                    rezultat += aux.ToString() + Environment.NewLine;
                }
                return rezultat;
            }

            public int GetNrCredite()
            {
                return credite.Count();
            }

            public void addCredit(int idClient,Credit aux)
            {
                
                credite.Add(idClient,aux);
            }
            public void getCredit(int id)
            {
                var c = credite.GetEnumerator();
                Credit aux = new Credit();
                do
                {
                    c.MoveNext();
                }
                while (!c.Current.Key.Equals(id));
                aux = c.Current.Value;
            }
        public bool Contains(Credit item)
        {
            return credite.ContainsValue(item);
        }

    }
 }

