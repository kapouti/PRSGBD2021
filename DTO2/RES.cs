using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO2
{
   public  class RES
    {
        public int RES_ID { get; set; }
        public DateTime RES_DTE { get; set; }
        public DateTime RES_HEU_DEB { get; set; }
        public DateTime RES_HEU_FIN { get; set; }
        public int RES_FK_MBR { get; set; }
        public int RES_FK_AER { get; set; }
    }
}
