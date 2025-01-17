﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbKyLuatNguoiHoc
{
    public int IdKyLuatNguoiHoc { get; set; }

    public int? IdHocVien { get; set; }

    public int? IdLoaiKyLuat { get; set; }

    public string? LyDo { get; set; }

    public int? IdCapQuyetDinh { get; set; }

    public string? SoQuyetDinh { get; set; }

    public DateOnly? NgayQuyetDinh { get; set; }

    public string? NamBiKyLuat { get; set; }

    public  DmCapKhenThuong? IdCapQuyetDinhNavigation { get; set; }

    public  TbHocVien? IdHocVienNavigation { get; set; }

    public  DmLoaiKyLuat? IdLoaiKyLuatNavigation { get; set; }
}
