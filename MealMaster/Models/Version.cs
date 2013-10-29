using System;
using System.Xml.Serialization;

namespace MealMaster.Models
{
    [Serializable()]
    public class Version
    {
        [XmlElement("Number")]
        public string Number { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }

    [Serializable()]
    [XmlRoot("VersionCollection")]
    public class VersionCollection
    {
        [XmlArray("Versions")]
        [XmlArrayItem("Version", typeof(Version))]
        public Version[] Version { get; set; }
    }
}
