using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmHinhThucChuyenGiaoCongNghe
{
    public int IdHinhThucChuyenGiaoCongNghe { get; set; }

    public string? HinhThucChuyenGiaoCongNghe { get; set; }

    public  ICollection<TbChuyenGiaoCongNgheVaDaoTao> TbChuyenGiaoCongNgheVaDaoTaos { get; set; } = new List<TbChuyenGiaoCongNgheVaDaoTao>();
}
