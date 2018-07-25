using System.Runtime.Serialization;

namespace RestAssesment
{
    [DataContract]
    public class Model
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Abbr { get; set; }

        [DataMember]
        public string Area { get; set; }

        [DataMember]
        public string Largest_City { get; set; }

        [DataMember]
        public string Capital { get; set; }
    }
}
