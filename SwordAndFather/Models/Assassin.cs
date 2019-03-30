using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordAndFather.Models
{
    public class Assassin
    {
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string Catchphrase { get; set; }
        public string PreferredWeapon { get; set; }
        public int Rating { get; set; }
        public decimal StandardFee { get; set; }

        public Assassin(string codeName, string catchphrase, string preferredWeapon)
        {
            CodeName = codeName;
            Catchphrase = catchphrase;
            PreferredWeapon = preferredWeapon;
        }
    }
}
