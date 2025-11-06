using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "姓名是必填项")]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "年龄是必填项")]
        [Range(0, 150, ErrorMessage = "年龄必须在0-150之间")]
        [Display(Name = "年龄")]
        public int Age { get; set; }

        [Required(ErrorMessage = "性别是必填项")]
        [Display(Name = "性别")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "入院日期是必填项")]
        [Display(Name = "入院日期")]
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "状态是必填项")]
        [Display(Name = "状态")]
        public string Status { get; set; }

        [Required(ErrorMessage = "诊断是必填项")]
        [Display(Name = "诊断")]
        public string Diagnosis { get; set; }

        [Required(ErrorMessage = "主治医生是必填项")]
        [Display(Name = "主治医生")]
        public string AttendingDoctor { get; set; }

        [Display(Name = "治疗方案")]
        public string TreatmentPlan { get; set; }

        [Display(Name = "备注")]
        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}