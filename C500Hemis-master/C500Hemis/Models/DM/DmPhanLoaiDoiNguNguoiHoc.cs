using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmPhanLoaiDoiNguNguoiHoc
{
    public int IdPhanLoaiDoiNguNguoiHoc { get; set; }

    public string? PhanLoaiDoiNguNguoiHoc { get; set; }

    public  ICollection<TbDoiTuongThamGium> TbDoiTuongThamGia { get; set; } = new List<TbDoiTuongThamGium>();
}
