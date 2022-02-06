using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Servicos
    {

        public int ID_Item { get; set; }
        public int ID_Usuario { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

    }
}
