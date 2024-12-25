using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmHuyen
{
    public int IdHuyen { get; set; }

    public string? TenHuyen { get; set; }

    public int? IdTinh { get; set; }

    public  ICollection<DmXa> DmXas { get; set; } = new List<DmXa>();

    public  DmTinh? IdTinhNavigation { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();

    public  ICollection<TbHocVien> TbHocViens { get; set; } = new List<TbHocVien>();
}
