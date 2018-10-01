using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebAPI.Models.Master_Data
{
    public class Department : BaseModel
    {

        #region -- Variable Declarations --

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }

        public int BranchID { get; set; }

        [StringLength(15), Required]
        public string DepartmentName { get; set; }


        [ForeignKey("BranchID")]
        public Branch Branch { get; set; }

        #endregion

    }
}
