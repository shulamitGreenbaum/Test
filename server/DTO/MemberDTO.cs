using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class MembersDTO
    {
        public int TableID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string City { get; set; }
        public string Steet { get; set; }
        public int Bildingnumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public DateTime ? AvaccinDate { get; set; }
        public string Atipevaccin { get; set; }
        public DateTime ? Sickdate { get; set; }
        public DateTime ? Recoverydate { get; set; }
        public DateTime ? BvaccindDate { get; set; }
        public DateTime ? CvaccinDate { get; set; }
        public DateTime ? DvaccinDate { get; set; }
        public string Btipevaccin { get; set; }
        public string Dtipevaccin { get; set; }
        public string Ctipevaccin { get; set; }
    }
}
