using System.Xml.Serialization;

namespace AC3GUIProgram.DTO
{
    public class Location
    {
        [XmlElement("Codi_comarca")]
        public int LocCode { get; set; }
        [XmlElement("Comarca")]
        public string LocName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Location)
            {
                return ((Location)obj).LocCode == LocCode && ((Location)obj).LocName == LocName; ;
            }
            return false;

        }
        public override int GetHashCode()
        {
            return LocCode;
        }
    }
}
