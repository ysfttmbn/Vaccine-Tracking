﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KonfirmasiVaksin_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void InsertLaporan(Data_Pasien obj);
        [OperationContract]
        IEnumerable<Data_Pasien> GetPasien();
    }
    public class DataPasien
    {
        [DataMember]
        [Key]
        [Required]
        public int id_pasien { get; set; }
        [DataMember]
        [Required]
        public string id_vaksin { get; set; }
        [DataMember]
        [Required]
        public string no_rekam_medis { get; set; }
        [DataMember]
        [Required]
        public string nik_pasien { get; set; }
    }
}
