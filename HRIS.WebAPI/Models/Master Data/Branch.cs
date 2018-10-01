using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebAPI.Models.Master_Data
{
    public class Branch : BaseModel
    {

        #region -- Variable Declarations --

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BranchID { get; set; }

        [StringLength(15), Required]
        public string BranchName { get; set; }

        [StringLength(50), Required]
        public string Address { get; set; }

        [StringLength(20), Required]
        public string Email { get; set; }

        #endregion

    }
}
