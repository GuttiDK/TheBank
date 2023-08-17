using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }


        public Account(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.Balance = 0;
        }
    }
}
