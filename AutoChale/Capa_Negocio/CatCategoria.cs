using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace Capa_Negocio
{
    public class CatCategoria
    {
        public string TableName = "Categoria";
        public int CodigoCatcategoria { get; set; }
        char estado;
        int codigo;
        
        public object Save(CatCategoria inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("Raiko", "Akatsukinar0t0");
                {
                    if (inst.CodigoCatcategoria== -1)
                    {
                        return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                    }
                    else
                    {
                        return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "CodigoCategoria");
                    }
                }
                catch(Exception ex);
            }
        }
        throw ;
    }

}
