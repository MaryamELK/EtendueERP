﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EtendueERP.Models.SageAPI
{
    public partial class F_LOTSERIE
    {
        public int cbMarq { get; set; }
        public string AR_Ref { get; set; }
        public string LS_NoSerie { get; set; }
        public DateTime? LS_Peremption { get; set; }
        public DateTime? LS_Fabrication { get; set; }
        public decimal? LS_Qte { get; set; }
        public decimal? LS_QteRestant { get; set; }
        public decimal? LS_QteRes { get; set; }
        public short? LS_LotEpuise { get; set; }
        public int DE_No { get; set; }
        public int? DL_NoIn { get; set; }
        public int? DL_NoOut { get; set; }
        public short? LS_MvtStock { get; set; }
        public string LS_Complement { get; set; }
    }
}