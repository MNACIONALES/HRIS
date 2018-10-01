using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebAPI.Models
{
    public class BaseModel
    {

        #region -- Variable Declarations --

        [StringLength(15)]
        public string CreatedBy { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CreatedDate { get; set; }

        [StringLength(15)]
        public string ModifiedBy { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }
        #endregion

    }
}
