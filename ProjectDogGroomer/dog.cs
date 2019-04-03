using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDogGroomer
{
    class dog
    {
        private string dogname;
        public string Dogname
        {
            get { return dogname; }
        }
        private Stack<Dogservices> services;
        public dog(string dogname)
        {
            this.dogname = dogname;
            services = new Stack<Dogservices>();
        }
        public void provideserv(Dogservices typeofgroom)
        {
            for (int i = 0; i > services.Count; i++)
                services.Push(typeofgroom);
        }
        public void Beinggroom()
        {
            Console.WriteLine(dogname + " is getting groom right now");
            while (services.Count > 0)
            {
                Console.WriteLine(dogname + " is getting a" + services.Pop
                ().ToString().ToLower());
            }
        }
    }
}

