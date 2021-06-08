using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO2;

namespace BL1
{
    public static class ServicesMEM
    {
        static public MEM REchMEM(int MEM_ID)
        {
            return DAL.AccesMEM.SelectMEM(MEM_ID);
        }

        static public List<MEM> RechMEMByDebNom(string DEB_NOM)
        {
            return DAL.AccesMEM.SelectMEMByDebNom(DEB_NOM);
        }
        static public List<MEM> LireMEM()
        {
            return DAL.AccesMEM.SelectMEM();
        }



    }
}
