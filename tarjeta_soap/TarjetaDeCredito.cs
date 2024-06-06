using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace tarjeta_soap
{

    [XmlRoot("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement("Body")]
        public Body Body { get; set; }
    }

    public class Body
    {
        [XmlElement("CreditCardInfo", Namespace = "http://example.com/creditcard")]
        public CreditCardInfo CreditCardInfo { get; set; }
    }

    public class CreditCardInfo
    {
        [XmlElement("Sistema")]
        public Sistema Sistema { get; set; }

        [XmlElement("Cliente")]
        public Cliente Cliente { get; set; }

        [XmlElement("Tarjeta")]
        public Tarjeta Tarjeta { get; set; }
    }

    public class Sistema
    {
        [XmlElement("Nombre")]
        public string Nombre { get; set; }

        [XmlElement("Localizacion")]
        public string Localizacion { get; set; }
    }

    public class Cliente
    {
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("Nombre")]
        public string Nombre { get; set; }

        [XmlElement("Direccion")]
        public string Direccion { get; set; }

        [XmlElement("Ciudad")]
        public string Ciudad { get; set; }

        [XmlElement("CodigoPostal")]
        public string CodigoPostal { get; set; }

        [XmlElement("Pais")]
        public string Pais { get; set; }
    }

    public class Tarjeta
    {
        [XmlElement("Numero")]
        public string Numero { get; set; }

        [XmlElement("Tipo")]
        public string Tipo { get; set; }

        [XmlElement("FechaExpiracion")]
        public string FechaExpiracion { get; set; }

        [XmlElement("CVV")]
        public string CVV { get; set; }
    }
}