using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CekDataNIK_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        IEnumerable<Data_Penduduk> GetNik();
        [OperationContract]
        bool CekNik(string search);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class DataPenduduk
    {
        [DataMember]
        [Key]
        [Required]
        public int id { get; set; }
        [DataMember]
        [Required]
        public string nik { get; set; }
        [DataMember]
        [Required]
        public string nama { get; set; }
        [DataMember]
        public string alamat { get; set; }
        [DataMember]
        public string jenis_kelamin { get; set; }
    }
}
