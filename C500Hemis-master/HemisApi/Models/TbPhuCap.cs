﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbPhuCap
{
    public int IdPhuCap { get; set; }

    public int? IdCanBo { get; set; }

    public int? PhuCapThuHutNghe { get; set; }

    public int? PhuCapThamNien { get; set; }

    public int? PhuCapUuDaiNghe { get; set; }

    public int? PhuCapChucVu { get; set; }

    public int? PhuCapDocHai { get; set; }

    public int? PhuCapKhac { get; set; }

    public int? IdBacLuong { get; set; }

    public int? PhanTramVuotKhung { get; set; }

    public int? IdHeSoLuong { get; set; }

    public DateOnly? NgayThangNamHuongLuong { get; set; }

    public  DmBacLuong1? IdBacLuongNavigation { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmHeSoLuong? IdHeSoLuongNavigation { get; set; }
}
