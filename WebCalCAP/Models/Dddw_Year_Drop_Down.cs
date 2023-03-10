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
    [DataWindow("dddw_year_drop_down", DwStyle.Default)]
    public class Dddw_Year_Drop_Down
    {
        [DwColumn("year")]
        public double? Year { get; set; }

    }

}