using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmXa
{
    public int IdXa { get; set; }

    public string? TenXa { get; set; }

    public int? IdHuyen { get; set; }

    public  DmHuyen? IdHuyenNavigation { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();

    public  ICollection<TbHocVien> TbHocViens { get; set; } = new List<TbHocVien>();
}
