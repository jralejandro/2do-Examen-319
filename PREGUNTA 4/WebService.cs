using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); Console.WriteLine("hola mundo");
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }
    [WebMethod]
    public string FiboEstructurado(int n)
    {
        ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
        return c.fibo(n);
    }
    [WebMethod]
    public int FiboRecursivo(int n)
    {
        ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
        return c.fiboRec(n);
    }
    [WebMethod]
    public string Final(int n)
    {
        ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
        return c.final(n);
    }
}