using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmPhanLoaiCoSo
{
    public int IdPhanLoaiCoSo { get; set; }

    public string? PhanLoaiCoSo { get; set; }

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();
}
