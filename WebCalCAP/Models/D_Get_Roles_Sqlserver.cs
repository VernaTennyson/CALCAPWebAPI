using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace WebCalCAP.Models
{
    [DataWindow("d_get_roles_sqlserver", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT      @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM        sys.database_principals AS dp1 \r\n "
                  +"LEFT  JOIN  sys.database_role_members AS drm \r\n "
                  +"ON    drm.role_principal_id = dp1.principal_id \r\n "
                  +"LEFT  JOIN  sys.database_principals AS dp2 \r\n "
                  +"ON    dp2.principal_id = drm.member_principal_id \r\n "
                  +"WHERE       dp1.type = 'R' and dp2.name = 'Test1' \r\n "
                  +"ORDER BY    dp1.name")]
    #endregion
    public class D_Get_Roles_Sqlserver
    {
        [SqlCompute("dp1.name AS DatabaseRoleName")]
        public string Database_Principals_Databaserolename { get; set; }

    }

}