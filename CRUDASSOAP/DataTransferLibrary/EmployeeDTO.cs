using System.Runtime.Serialization;
namespace DataTransferLibrary
{
    [DataContract]
    public class EmployeeDTO
    {
      [DataMember]
      public string Name { get; set; }
      [DataMember]
       public string Id { get ; set;}
        [DataMember]
        public string City { get;set;}
    }
}
