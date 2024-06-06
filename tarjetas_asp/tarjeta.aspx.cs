using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using tarjetas_asp.ServiceReference1;

namespace tarjetas_asp
{
    public partial class tarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConsumeWebService(object sender, EventArgs e)
        {
            string soapRequest = @"
<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:cred=""http://example.com/creditcard"">
   <soapenv:Header/>
   <soapenv:Body>
      <cred:CreditCardInfo>
         <Sistema>
            <Nombre>Sistema1</Nombre>
            <Localizacion>Local</Localizacion>
         </Sistema>
         <Cliente>
            <ID>123456789</ID>
            <Nombre>Juan Pérez</Nombre>
            <Direccion>Calle Principal 123</Direccion>
            <Ciudad>Ciudad de Ejemplo</Ciudad>
            <CodigoPostal>12345</CodigoPostal>
            <Pais>País de Ejemplo</Pais>
         </Cliente>
         <Tarjeta>
            <Numero>1234567890123456</Numero>
            <Tipo>Visa</Tipo>
            <FechaExpiracion>12/24</FechaExpiracion>
            <CVV>123</CVV>
         </Tarjeta>
      </cred:CreditCardInfo>
   </soapenv:Body>
</soapenv:Envelope>";

            try
            {


                // Convertir el XmlDocument a XElement
                XmlDocument soapRequestXmlDoc = new XmlDocument();
                soapRequestXmlDoc.LoadXml(soapRequest);
                XElement soapRequestXElement = XElement.Parse(soapRequestXmlDoc.OuterXml);

                // Llamar al servicio web SOAP y pasar el XElement como parámetro
                ServiceReference1.tarjetaSoapClient tarjetaSoap = new ServiceReference1.tarjetaSoapClient();
                lblStatus.Text = tarjetaSoap.CreditCardInfo(soapRequestXElement);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }


        protected void btnSendXml_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del cliente del servicio
                tarjetaSoapClient client = new tarjetaSoapClient();


                // Crear objetos para representar la información de la tarjeta de crédito
                Sistema sistema = new Sistema { Nombre = "Sistema1", Localizacion = "Local" };
                Cliente cliente = new Cliente
                {
                    ID = "123456789",
                    Nombre = "Juan Pérez",
                    Direccion = "Calle Principal 123",
                    Ciudad = "Ciudad de Ejemplo",
                    CodigoPostal = "12345",
                    Pais = "País de Ejemplo"
                };
                Tarjeta tarjeta = new Tarjeta
                {
                    Numero = "1234567890123456",
                    Tipo = "Visa",
                    FechaExpiracion = "12/24",
                    CVV = "123"
                };

                // Crear objeto CreditCardInfo y asignar los objetos de información de tarjeta de crédito
                CreditCardInfo creditCardInfo = new CreditCardInfo
                {
                    Sistema = sistema,
                    Cliente = cliente,
                    Tarjeta = tarjeta
                };

                // Serializar los objetos a XML
                XmlSerializer serializer = new XmlSerializer(typeof(CreditCardInfo));
                StringWriter stringWriter = new StringWriter();
                serializer.Serialize(stringWriter, creditCardInfo);
                string xmlString = stringWriter.ToString();

                // Crear un objeto XmlElement a partir del XML
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);
                // Convertir el XML serializado a XElement
                XElement xmlElement = XElement.Parse(xmlString);

                // Llamar al método del servicio web
                string result = client.ProcessCreditCard(xmlElement);

                // Mostrar el resultado
                lblStatus2.Text = result;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                lblStatus2.Text = $"Error al consumir el servicio web: {ex.Message}";
            }
        }

        private XElement SerializeToXElement(Envelope envelope)
        {
            var xmlSerializer = new XmlSerializer(typeof(Envelope));
            using (var stream = new StringWriter())
            {
                xmlSerializer.Serialize(stream, envelope);
                return XElement.Parse(stream.ToString());
            }
        }
    }
}