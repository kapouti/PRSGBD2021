using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using DTO2;
namespace DAL
{
   public class AccesMEM
    {
        static public MEM SelectMEM(int MEM_ID)
        {
            //- Déclarations ---------------------------------
            MEM retVal;
            List<MEM> liste;

            //- Traitement -----------------------------------
            retVal = null;
            liste = null;

            using (IDbConnection connexion = DAL.UtilitaireSGBD.GetConnection())
            {
                liste = connexion.Query<MEM>("sp_select_MEM_BY_ID",
                                             param: new { MEM_ID = MEM_ID },
                                             commandType: CommandType.StoredProcedure).AsList<MEM>();
                if (liste.Count == 1)
                    retVal = liste[0];

            }
            return retVal;
        }

        static public List<MEM> SelectMEMByDebNom(string DEB_NOM)
        {

            List<MEM> retval;

            retval = new List<MEM>();
            using(IDbConnection conn = DAL.UtilitaireSGBD.GetConnection())
            
                retval = conn.Query<MEM>("sp_select_MEM_BY_DEB_NOM",
                                          param: new { DEB_NOM = DEB_NOM },
                                          commandType: CommandType.StoredProcedure).AsList<MEM>();


            return retval;
        }
        public static List<DTO2.MEM> ChargerLesMEM()
        {
            SqlConnection connexion = UtilitaireSGBD.ObtenirConnexion();
            try
            {
                return connexion.Query<DTO2.MEM>("select * from dbo.MEM").ToList();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        static public List<MEM> SelectMEM()
        {
            //- Déclarations ---------------------------------
            List<MEM> retVal;

            //- Traitement -----------------------------------
            retVal = new List<MEM>();

            using (IDbConnection connexion = DAL.UtilitaireSGBD.GetConnection())
                retVal = connexion.Query<MEM>("sp_select_MEM",
                                     commandType: CommandType.StoredProcedure).AsList<MEM>();

            return retVal;
        }


    }
}
