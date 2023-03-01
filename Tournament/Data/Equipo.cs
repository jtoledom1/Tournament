using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Data
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ciudad { get; set; }
        public string SitioWeb { get; set;}
        public DateTime Fecha { get; set; }

    }
}
