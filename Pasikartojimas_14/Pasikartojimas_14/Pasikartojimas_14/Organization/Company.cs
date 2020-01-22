using Pasikartojimas_14.LiveObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasikartojimas_14.Organization
{
    class Company : IPrintable
    {
        private Human boss;
        private readonly string name;
        private List<Client> clientList = new List<Client>();
        private List<Worker> workerList = new List<Worker>();
        public Pet OfficePet { get; set; }

        public void AddClient(Client client)
        {
            clientList.Add(client);
            client.ClientId = clientList.Count()-1;
        }
        public Company(Human boss, string name)
        {
            this.boss = boss;
            this.name = name;
        }
        public void FireWorker(Worker worker)
        {
            if (workerList.Contains(worker))
            {
                workerList.Remove(worker);
            }
        }
        public void HireWorker(Worker worker)
        {
            workerList.Add(worker);
        }
        public void PrintAllClients()
        {
            foreach (Client client in clientList)
            {
                client.PrintInfo();
            }
        }
        public void PrintAllWorkers()
        {
            foreach (Worker worker in workerList)
            {
                worker.PrintInfo();
            }
        }

        public void PrintInfo()
        {
            Console.Write("BOSS: ");
            boss.PrintInfo();
            Console.WriteLine();
            OfficePet.PrintInfo();
            Console.WriteLine("Workers:");
            PrintAllWorkers();
            Console.WriteLine("Clients:");
            PrintAllClients();
        }
    }
}
