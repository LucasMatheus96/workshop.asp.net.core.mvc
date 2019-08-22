using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department

    {
        [Key]
        public int Iid { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Seller { get; set; } = new List<Seller>();


        public Department()
        {

        }

        public Department(int iid, string name)
        {
            Iid = iid;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Seller.Add(seller);
        }

        public double TotalSales(DateTime inicial, DateTime final)
        {
            return Seller.Sum(Seller => Seller.TotalSales(inicial, final));
        }

    }
}
