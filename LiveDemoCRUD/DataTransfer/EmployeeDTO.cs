using System.Runtime.Serialization;

namespace DataTransfer
{
    [DataContract]
  public  class EmployeeDTO
    {
        [DataMember]
      public string Name { get; set; }
          [DataMember]
      public string Id { get; set; }
          [DataMember]
      public string city { get; set; }
           
    }
}
