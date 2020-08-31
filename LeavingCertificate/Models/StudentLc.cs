
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LeavingCertificate.Models.Resources;

namespace LeavingCertificate.Models
{

    [MetadataType(typeof(StudentLCMetaData))]
    public partial class StudentLCData
    {
    }


    public class StudentLCMetaData
    {
        public int Id { get; set; }

        [Display(Name = "AdmissionNumber", ResourceType = typeof(SchoolLc))]
        public int AdmissionNo { get; set; }

        [Required]
        [Display(Name = "FullName", ResourceType = typeof(SchoolLc))]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Nationality", ResourceType = typeof(SchoolLc))]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "MotherTongue", ResourceType = typeof(SchoolLc))]
        public string MotherTongue { get; set; }

        [Required]
        [Display(Name = "Religion", ResourceType = typeof(SchoolLc))]
        public string Religion { get; set; }

        [Required]
        [Display(Name = "Caste", ResourceType = typeof(SchoolLc))]
        public string Caste { get; set; }

        [Display(Name = "SubCaste", ResourceType = typeof(SchoolLc))]
        public string SubCaste { get; set; }

        [Required]
        [Display(Name = "BirthPlace", ResourceType = typeof(SchoolLc))]
        public string BirthPlace { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "DOBInDigits", ResourceType = typeof(SchoolLc))]
        public DateTime? DOBInDigits { get; set; }

        [Display(Name = "DOBInWords", ResourceType = typeof(SchoolLc))]
        public string DOBInWords { get; set; }

        [Display(Name = "PrevSchlName", ResourceType = typeof(SchoolLc))]
        public string PrevSchlName { get; set; }

        [Display(Name = "AdmittedInClass", ResourceType = typeof(SchoolLc))]
        public string AdmittedInClass { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "AdmissionDate", ResourceType = typeof(SchoolLc))]
        public string AdmissionDate { get; set; }

        [Required]
        [Display(Name = "Progress", ResourceType = typeof(SchoolLc))]
        public string Progress { get; set; }

        [Display(Name = "ConductBehaviour", ResourceType = typeof(SchoolLc))]
        public string ConductBehaviour { get; set; }

        [Required]
        [Display(Name = "DateOfSchlLeaving", ResourceType = typeof(SchoolLc))]
        [DataType(DataType.Date)]
        public DateTime? DateOfSchlLeaving { get; set; }

        [Required]
        [Display(Name = "ClassFromLeft", ResourceType = typeof(SchoolLc))]
        public string ClassFromLeft { get; set; }

        [Required]
        [Display(Name = "ReasonForLeaving", ResourceType = typeof(SchoolLc))]
        public string ReasonForLeaving { get; set; }

        [Display(Name = "CertificateRcvdDate", ResourceType = typeof(SchoolLc))]
        [DataType(DataType.Date)]
        public DateTime? CertificateRcvdDate { get; set; }

        [Display(Name = "ReceivedByName", ResourceType = typeof(SchoolLc))]
        public string ReceivedByName { get; set; }


        [Display(Name = "Gender", ResourceType = typeof(SchoolLc))]
        public string Gender { get; set; }

    }
}