using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbLuuHocSinhSinhVienNn
{
    public int IdLuuHocSinhSinhVienNn { get; set; }

    public int? IdNguoiHoc { get; set; }

    public int? IdNguonKinhPhiLuuHocSinh { get; set; }

    public int? IdLoaiLuuHocSinh { get; set; }

    public  DmLoaiLuuHocSinh? IdLoaiLuuHocSinhNavigation { get; set; }

    public  DmNguonKinhPhiChoLuuHocSinh? IdNguonKinhPhiLuuHocSinhNavigation { get; set; }
}
