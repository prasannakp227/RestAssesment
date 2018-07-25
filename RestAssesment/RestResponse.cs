using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RestAssesment
{
    [DataContract]
    public class RestResponse
    {
        [DataMember]
        public List<string> Messages { get; set; }

        [DataMember]
        public List<Model> Result { get; set; }
    }


    [DataContract]
    public class Response
    {
        [DataMember]
        public RestResponse RestResponse { get; set; }
    }
}
