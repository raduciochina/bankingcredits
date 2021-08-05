using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AplicatieBanking
{
    public class Clienti
    {
        public Dictionary<int, Client> clienti = new Dictionary<int, Client>();
        public Clienti()
        {
        }
        public Clienti(Dictionary<int, Client> clienti)
        {
            this.clienti = clienti;
        }

        public override string ToString()
        {
            string rezultat = "" ;
            foreach(Client aux in clienti.Values)
            {
                rezultat += aux.ToString()+Environment.NewLine;
            }
            return rezultat;
        }

        public int GetNrClienti() 
        {
            return clienti.Count();
        }
        
        public void addClient(Client aux)
        {
            
            clienti.Add(aux.Id, aux);
        }
        public void getClient(int id)
        {
            var c = clienti.GetEnumerator();
            Client aux = new Client();
            do
            {
                c.MoveNext();
            }
            while (!c.Current.Key.Equals(id));
            aux = c.Current.Value;
        }
        public bool Contains(Client item)
        {
            return clienti.ContainsValue(item);
        }

    }
}
