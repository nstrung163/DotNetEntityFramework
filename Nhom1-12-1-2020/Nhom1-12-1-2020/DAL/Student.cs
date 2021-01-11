namespace Nhom1_12_1_2020.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(250)]
        public string PlaceOfBirth { get; set; }

        public int? Gender { get; set; }
        // int? có thể bằng null, nếu chưa set
        [StringLength(50)]
        public string IDClassroom { get; set; }

        public virtual Classroom Classroom { get; set; }

        public string GenderString
        {
            get
            {
                if(Gender.HasValue) 
                {
                    if (Gender.Value == 0)
                        return "Nam";
                    if (Gender.Value == 1)
                        return "Nữ";
                    return "Khác";
                } else
                {
                    return "Không xác định";
                }
                  
            }
        }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
