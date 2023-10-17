using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PM02NetMaui_Tarea1_2.Models
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
    }
}
