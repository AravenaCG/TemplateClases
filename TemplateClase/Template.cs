using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail.MailAddress;
namespace TemplateClase
{
    class Template
    {
      
            
            #region Atributos
            protected String atributo1;
            protected String atributo2;
            protected String atributo3;
            protected String atributo4;
            protected String atributo5;
            protected String atributo6;
            protected String atributo7;
            protected String atributo8;
            protected List<atributo>;
        MailAddres.MailAddres(atributo1);





            #endregion


            #region Propiedades
            
            
            public int MyProperty { get; set; }
            public int MyProperty { get; set; }
            public int MyProperty { get; set; }
            public int MyProperty { get; set; }

            #endregion




            #region Constructores
            
            private Template
            {


            }
            

            private Template(string atributo222, int atributo333)
            {

            }


            public Template ( string atributo, int atributo11, char atributo22, float atributo33):this(atributo,atributo11)
            {


            }

       /*      private Changuito()
        {
            this._productos = new List<Producto>(_espacioDisponible);
          //  _productos.Capacity= _espacioDisponible;
        }
        public Changuito(int espacioDisponible):this()
        { 
            this._espacioDisponible = espacioDisponible;
            
        }*/

            #endregion


            #region Metodos

            /*lic  string Mostrar(Changuito c, ETipo tipo) //quitar static
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", c._productos.Count, c._espacioDisponible);
            sb.AppendLine("");
            foreach (Producto v in c._productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if (v is Snacks)
                        {
                            sb.AppendLine(((Snacks)v).Mostrar());
                        }
                        break;
                    case ETipo.Dulce:
                        if (v is Dulce)
                        {
                            sb.AppendLine(((Dulce)v).Mostrar());
                        }
                        break;
                    case ETipo.Leche:
                        if (v is Leche)
                        {
                            sb.AppendLine(((Leche)v).Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }*/





            #endregion


            #region Sobrecargas
            
            public static implicit operator string (Template a)
            {




            }


        /*    public static Changuito operator +(Changuito c, Producto p)
        {

            bool existe = false;
            foreach (Producto v in c._productos)
            {
                
                if (v == p)
                {
                    existe = true;
                    break;
                }
            }
                if(existe == false)
                {
                    if (c._productos.Count < c._espacioDisponible)
                    {
                        c._productos.Add(p);
                    }
                }
                if (c._productos.Count > c._espacioDisponible)
                {
                    c._productos.TrimExcess();
                }
            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto v in c._productos)
            {
                if (v == p)
                {
                    break;
                }
            }
            c._productos.Remove(p);
            return c;
        }
        #endregion
    }*/
            

    /*public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: " + p._codigoDeBarras);
            sb.AppendLine("MARCA          :" + p._marca.ToString());
            sb.AppendLine("COLOR EMPAQUE  :" + p._colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            bool answ = false;
            if (v1._codigoDeBarras == v2._codigoDeBarras)
            {
                answ = true;

            }

            return answ;
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            bool answ = false;
            if (v1._codigoDeBarras == v2._codigoDeBarras)
            {
                answ = true;

            }

            return answ;
        }*/
            

            
            #endregion



            #region NestedTypes

            enum TipoEnum { uno,dos,tres,cuatro}
	
	         



            #endregion





        
    }



/* Valida FORMATO FECHA
 * 
 * public static bool IsDate(string inputDate)
{
bool isDate = true;
try{
    DateTime dateValue;
    dateValue = DateTime.ParseExact(inputDate,"yyyy-MM-dd",null);
}
catch{
    isDate = false;
}
return isDate;
}
 
 validar formato
 * 
 * 
 * public static bool TryFormat(string format, out string result, params Object[] args)
{
   try
   {
      result = String.Format(format, args);
      return true;
   }
   catch(FormatException)
   {
      return false;
   }
}
 * 
 * 
 * var r = new Regex("^\\d(\\d|(?<!-)-)*\\d$|^\\d$");
Console.WriteLine(r.IsMatch("1-2-3"));
Console.WriteLine(r.IsMatch("1-222-3333"));
Console.WriteLine(r.IsMatch("123"));
Console.WriteLine(r.IsMatch("1-2-3-"));
Console.WriteLine(r.IsMatch("1"));
Console.WriteLine(r.IsMatch("-11-2-3-"));
 */



}







    

