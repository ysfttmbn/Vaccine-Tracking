using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RegistrasiVaksin_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<VaksinData> GetVaksin();
        [OperationContract]
        void InsertVaksin(VaksinData obj);
        [OperationContract]
        void UpdateVaksin(VaksinData obj);
        [OperationContract]
        void DeleteVaksin(string id);
        [OperationContract]
        VaksinData GetDataById(string id);
        [OperationContract]
        void GetData();
    }
    [DataContract]
    public class Vaksin_Data
    {
        [DataMember]
        [Key]
        [Required]
        public string no_register { get; set; }
        [DataMember]
        [Required]
        public System.DateTime tanggal_dibuat { get; set; }
    }
}
