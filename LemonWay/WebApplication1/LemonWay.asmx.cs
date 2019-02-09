using System.Web.Services;
using System.Xml;
using System.Threading;
using Newtonsoft.Json;

namespace WebApplication1
{
    /// <summary>
    /// Description résumée de LemonWay
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]
    public class LemonWay : System.Web.Services.WebService
    {
        /// <summary>
        /// Fibonacci sequence. n must be between 1 and 100. It returns -1 otherwise
        /// </summary>
        /// <param name="n">nth value of sequence</param>
        /// <returns>fibonacci value for n</returns>
        [WebMethod]
        public int Fibonacci(int n)
        {
            if (n < 1 || n > 100)
            {
                return -1;
            }
            else if (n <= 2)
            {
                return 1;
            }
            Thread.Sleep(100);
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// Convert an xml format string to a json format string
        /// </summary>
        /// <param name="xml">xml format string to convert</param>
        /// <returns>json format string in try, "Bad Xml format" in catch</returns>
        [WebMethod]
        public string XmlToJson(string xml)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml(xml);
                return JsonConvert.SerializeXmlNode(document, Newtonsoft.Json.Formatting.Indented);
            }
            catch
            {
                return ("Bad Xml format");
            }
        }
    }
}
