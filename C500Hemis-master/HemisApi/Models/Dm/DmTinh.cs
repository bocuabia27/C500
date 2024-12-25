using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTinh
{
    public int IdTinh { get; set; }

    public string? TenTinh { get; set; }

    public  ICollection<DmHuyen> DmHuyens { get; set; } = new List<DmHuyen>();

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();

    public  ICollection<TbHocVien> TbHocViens { get; set; } = new List<TbHocVien>();
}
