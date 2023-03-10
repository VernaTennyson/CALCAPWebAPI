using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SnapObjects.Data;
using DWNet.Data;

namespace WebCalCAP.Models
{
	[DataWindow("d_sq_gr_department", DwStyle.Grid)]
    [Table("Department", Schema = "HumanResources")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"HumanResources.Department\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"HumanResources.Department.DepartmentID\"   OP =\"=\"    EXP2 =\":departmentid\" ) ) ARG(NAME = \"departmentid\" TYPE = number)")]
    #endregion
    [DwParameter("departmentid", typeof(decimal?))]
    public class D_Department
	{
        [Key]
        [Identity]
        [DwColumn("Department", "DepartmentID")]
        public short Departmentid { get; set; }

        [DwColumn("Department", "Name")]
        public string Name { get; set; }

        [DwColumn("Department", "GroupName")]
        public string Groupname { get; set; }

        [SqlDefaultValue("(getdate())")]
        [DwColumn("Department", "ModifiedDate")]
        public DateTime Modifieddate { get; set; }
    }
}
