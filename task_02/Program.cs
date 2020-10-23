using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    //XmlSerializer serializer = new XmlSerializer(typeof(current));
            //    //current steelSheet;
            //    //using (var sr = new StringReader("weather.xml"))
            //    //    steelSheet = (current)serializer.Deserialize(sr);

            //    //Console.WriteLine(steelSheet.clouds);

            //    XDocument doc;
            //    using (var sr = new StringReader("weather.xml"))
            //        doc = XDocument.Load(sr);

            //    Console.WriteLine((int)doc.Element("current").Element("city"));

            //    //Console.WriteLine((int)doc.Root.Element("temperature"));

            //    //using (FileStream fs = new FileStream("weather.xml", FileMode.Open))
            //    //{
            //    //    // byte[] buffer = new byte[fs.Length];


            //    //}
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("error");

            //}
            //string xml = "weather.xml";
            //XmlSerializer serializer = new XmlSerializer(typeof(current));
            //current weather;
            //using (var sr = new StringReader(xml))
            //    weather = (current)serializer.Deserialize(sr);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"\\Mac\Home\Desktop\ШАГ\C#\Project\Exam\task_02\weather.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }

                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("value");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }

                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("unit");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }

                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("timezone");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }




                //foreach (XmlNode childnode in xnode.ChildNodes)
                //{
                //    //if (childnode.Name == "company")
                //    //{
                //    //    Console.WriteLine($"Компания: {childnode.InnerText}");
                //    //}
                //    //if (childnode.Name == "age")
                //    //{
                //    //    Console.WriteLine($"Возраст: {childnode.InnerText}");
                //    //}
                //}
                //Console.WriteLine();
            }
            //Console.WriteLine(weather.Text);
        }

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class current
        {

            public currentCity cityField;

            public currentTemperature temperatureField;

            public currentFeels_like feels_likeField;

            public currentHumidity humidityField;

            public currentPressure pressureField;

            public currentWind windField;

            public currentClouds cloudsField;

            public currentVisibility visibilityField;

            public currentPrecipitation precipitationField;

            public currentWeather weatherField;

            public currentLastupdate lastupdateField;

            public string[] textField;

            public override string ToString()
            {
                return $"Current city:\t{city} {textField} {temperature}";
                //  return base.ToString();
            }
            /// <remarks/>
            public currentCity city
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public currentTemperature temperature
            {
                get
                {
                    return this.temperatureField;
                }
                set
                {
                    this.temperatureField = value;
                }
            }

            /// <remarks/>
            public currentFeels_like feels_like
            {
                get
                {
                    return this.feels_likeField;
                }
                set
                {
                    this.feels_likeField = value;
                }
            }

            /// <remarks/>
            public currentHumidity humidity
            {
                get
                {
                    return this.humidityField;
                }
                set
                {
                    this.humidityField = value;
                }
            }

            /// <remarks/>
            public currentPressure pressure
            {
                get
                {
                    return this.pressureField;
                }
                set
                {
                    this.pressureField = value;
                }
            }

            /// <remarks/>
            public currentWind wind
            {
                get
                {
                    return this.windField;
                }
                set
                {
                    this.windField = value;
                }
            }

            /// <remarks/>
            public currentClouds clouds
            {
                get
                {
                    return this.cloudsField;
                }
                set
                {
                    this.cloudsField = value;
                }
            }

            /// <remarks/>
            public currentVisibility visibility
            {
                get
                {
                    return this.visibilityField;
                }
                set
                {
                    this.visibilityField = value;
                }
            }

            /// <remarks/>
            public currentPrecipitation precipitation
            {
                get
                {
                    return this.precipitationField;
                }
                set
                {
                    this.precipitationField = value;
                }
            }

            /// <remarks/>
            public currentWeather weather
            {
                get
                {
                    return this.weatherField;
                }
                set
                {
                    this.weatherField = value;
                }
            }

            /// <remarks/>
            public currentLastupdate lastupdate
            {
                get
                {
                    return this.lastupdateField;
                }
                set
                {
                    this.lastupdateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentCity
        {

            private currentCityCoord coordField;

            private string countryField;

            private ushort timezoneField;

            private currentCitySun sunField;

            private string nameField;

            private uint idField;

            /// <remarks/>
            public currentCityCoord coord
            {
                get
                {
                    return this.coordField;
                }
                set
                {
                    this.coordField = value;
                }
            }

            /// <remarks/>
            public string country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            public ushort timezone
            {
                get
                {
                    return this.timezoneField;
                }
                set
                {
                    this.timezoneField = value;
                }
            }

            /// <remarks/>
            public currentCitySun sun
            {
                get
                {
                    return this.sunField;
                }
                set
                {
                    this.sunField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentCityCoord
        {

            private decimal latField;

            private decimal lonField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal lat
            {
                get
                {
                    return this.latField;
                }
                set
                {
                    this.latField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal lon
            {
                get
                {
                    return this.lonField;
                }
                set
                {
                    this.lonField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentCitySun
        {

            private System.DateTime setField;

            private System.DateTime riseField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentTemperature
        {

            private string unitField;

            private decimal maxField;

            private decimal minField;

            private decimal valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal max
            {
                get
                {
                    return this.maxField;
                }
                set
                {
                    this.maxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal min
            {
                get
                {
                    return this.minField;
                }
                set
                {
                    this.minField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentFeels_like
        {

            private string unitField;

            private decimal valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentHumidity
        {

            private string unitField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentPressure
        {

            private string unitField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentWind
        {

            private currentWindSpeed speedField;

            private object gustsField;

            private currentWindDirection directionField;

            /// <remarks/>
            public currentWindSpeed speed
            {
                get
                {
                    return this.speedField;
                }
                set
                {
                    this.speedField = value;
                }
            }

            /// <remarks/>
            public object gusts
            {
                get
                {
                    return this.gustsField;
                }
                set
                {
                    this.gustsField = value;
                }
            }

            /// <remarks/>
            public currentWindDirection direction
            {
                get
                {
                    return this.directionField;
                }
                set
                {
                    this.directionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentWindSpeed
        {

            private string nameField;

            private string unitField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentWindDirection
        {

            private string nameField;

            private byte valueField;

            private string codeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentClouds
        {

            private string nameField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentVisibility
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentPrecipitation
        {

            private string modeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string mode
            {
                get
                {
                    return this.modeField;
                }
                set
                {
                    this.modeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentWeather
        {

            private string valueField;

            private string iconField;

            private ushort numberField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string icon
            {
                get
                {
                    return this.iconField;
                }
                set
                {
                    this.iconField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class currentLastupdate
        {

            private System.DateTime valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }


    }
}

