
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

        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "FullName", ResourceType = typeof(SchoolLc))]
        public string FullName { get; set; }

        [Required(ErrorMessageResourceName = "NationalityRequired", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "Nationality", ResourceType = typeof(SchoolLc))]
        public string Nationality { get; set; }

        [Required(ErrorMessageResourceName = "MotherTongueRequired", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "MotherTongue", ResourceType = typeof(SchoolLc))]
        public string MotherTongue { get; set; }

        [Required(ErrorMessageResourceName = "ReligionRequired", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "Religion", ResourceType = typeof(SchoolLc))]
        public string Religion { get; set; }

        [Required(ErrorMessageResourceName = "CasteRequired", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "Caste", ResourceType = typeof(SchoolLc))]
        public string Caste { get; set; }

        [Display(Name = "SubCaste", ResourceType = typeof(SchoolLc))]
        public string SubCaste { get; set; }

        [Required(ErrorMessageResourceName = "BirthPlaceReq", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "BirthPlace", ResourceType = typeof(SchoolLc))]
        public string BirthPlace { get; set; }

        [Required(ErrorMessageResourceName = "DOBInDigitsReq", ErrorMessageResourceType = typeof(Error))]
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

        [Required(ErrorMessageResourceName = "ProgressReq", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "Progress", ResourceType = typeof(SchoolLc))]
        public string Progress { get; set; }

        [Display(Name = "ConductBehaviour", ResourceType = typeof(SchoolLc))]
        public string ConductBehaviour { get; set; }

        [Required(ErrorMessageResourceName = "DateOfSchlLeavingReq", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "DateOfSchlLeaving", ResourceType = typeof(SchoolLc))]
        [DataType(DataType.Date)]
        public DateTime? DateOfSchlLeaving { get; set; }

        [Required(ErrorMessageResourceName = "ClassFromLeftReq", ErrorMessageResourceType = typeof(Error))]
        [Display(Name = "ClassFromLeft", ResourceType = typeof(SchoolLc))]
        public string ClassFromLeft { get; set; }

        [Required(ErrorMessageResourceName = "ReasonForLeaving", ErrorMessageResourceType = typeof(Error))]
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