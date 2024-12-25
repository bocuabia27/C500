using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDoiTuongThamGium
{
    public int IdDoiTuongThamGia { get; set; }

    public int? IdLoaiThamGia { get; set; }

    public string? MaLoaiThamGia { get; set; }

    public int? IdNguoi { get; set; }

    public int? IdVaiTro { get; set; }

    public int? IdPhanLoai { get; set; }

    public  DmLoaiThamGium? IdLoaiThamGiaNavigation { get; set; }

    public  TbNguoi? IdNguoiNavigation { get; set; }

    public  DmPhanLoaiDoiNguNguoiHoc? IdPhanLoaiNavigation { get; set; }

    public  DmVaiTroThamGium? IdVaiTroNavigation { get; set; }
}
