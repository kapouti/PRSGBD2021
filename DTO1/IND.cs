using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO

{
    class IND
    {
        public int IND_ID { get; set; }
        public DateTime IND_DTE_DEB { get; set; }
        public DateTime IND_DTE_FIN { get; set; }
        public DateTime IND_HEU_DEB { get; set; }
        public DateTime IND_HEU_FIN { get; set; }
        public string IND_DES { get; set; }
        public int IND_FK_AER { get; set; }
    }
}
