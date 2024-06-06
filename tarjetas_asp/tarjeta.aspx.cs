using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace tarjetas_asp
{
    public partial class tarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendXml_Click(object sender, EventArgs e)
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
    }
}