using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Serialization;

namespace tarjeta_soap
{
    /// <summary>
    /// Descripción breve de tarjeta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class tarjeta : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string CreditCardInfo(XmlDocument soapRequest)
        {
            try
            {
                // Aquí puedes procesar la solicitud SOAP y extraer la información de la tarjeta de crédito
                // por ejemplo, podrías acceder a los elementos XML dentro del cuerpo de la solicitud
                XmlNodeList sistema = soapRequest.GetElementsByTagName("Sistema");
                string nombreSistema = sistema[0]["Nombre"].InnerText;
                string localizacion = sistema[0]["Localizacion"].InnerText;

                // Accede a los demás elementos XML de la misma manera y procesa la información de la tarjeta

                // Devuelve una respuesta (por ejemplo, un mensaje de éxito)
                return "La información de la tarjeta de crédito se ha recibido y procesado correctamente.";
            }
            catch (Exception ex)
            {
                // En caso de que ocurra un error durante el procesamiento
                return "Se produjo un error al procesar la solicitud: " + ex.Message;
            }
        }

        [WebMethod]
        public string ProcessCreditCard(XmlElement xml)
        {
            try
            {
                // Deserializar el XML a un objeto Envelope
                XmlSerializer serializer = new XmlSerializer(typeof(CreditCardInfo));
                using (StringReader reader = new StringReader(xml.OuterXml))
                {
                    CreditCardInfo tarjeta = (CreditCardInfo)serializer.Deserialize(reader);

                    // GUARDAR INFO

                    return "Información de la tarjeta de crédito procesada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return $"Error procesando la información de la tarjeta de crédito: {ex.Message}";
            }
        }

    }
}
