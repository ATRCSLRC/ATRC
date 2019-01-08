//using Checador.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Checador
{
    public partial class ChecadorEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetNoStore();
        }

        //[System.Web.Services.WebMethod]
        //public static string Checa(string Parameter)
        //{
        //    return Metodos.Checador(Parameter);
        //}
    
    }
}