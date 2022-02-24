using System.Runtime.Serialization;

namespace EmployeeS.ViewModel
{
    [DataContract]
    public class EmployeeViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public string Department { get; set; }
    }
}