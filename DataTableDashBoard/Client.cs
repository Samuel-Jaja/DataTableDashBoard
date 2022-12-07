using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableDashBoard
{
    public class Client
    {
        public bool Invoice  { get; set; }
        public string Status { get; set; }
        public string Customer { get; set; }
        public int Progress { get; set; }


        public static List<Client> LoadClientData()
        {
            List<Client> client = new List<Client>();
            client.Add(new Client()
            {
                Invoice = false,
                Status = "Paid",
                Customer = "Oliver Ryne",
                Progress = 60
            });
            client.Add(new Client()
            {
                Invoice = true,
                Status = "Paid",
                Customer = "kelly Osoba",
                Progress = 10
            });
            client.Add(new Client()
            {
                Invoice = true,
                Status = "Paid",
                Customer = "Gideon Ryne",
                Progress = 30
            });
            client.Add(new Client()
            {
                Invoice = false,
                Status = "Paid",
                Customer = "Oliver Ryne",
                Progress = 90
            });
            client.Add(new Client()
            {
                Invoice = true,
                Status = "Paid",
                Customer = "kelly Osoba",
                Progress = 80
            });
            client.Add(new Client()
            {
                Invoice = true,
                Status = "Paid",
                Customer = "Gideon Ryne",
                Progress = 60
            });
            client.Add(new Client()
            {
                Invoice = false,
                Status = "Paid",
                Customer = "Oliver Ryne",
                Progress = 70
            });
            client.Add(new Client()
            {
                Invoice = true,
                Status = "Paid",
                Customer = "kelly Osoba",
                Progress = 50
            });
            client.Add(new Client()
            {
                Invoice = true,
                Status = "Paid",
                Customer = "Samuel Jaja",
                Progress = 100
            });

            return client;
        }
    }

    
}
