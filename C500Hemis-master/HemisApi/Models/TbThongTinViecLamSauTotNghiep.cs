﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbThongTinViecLamSauTotNghiep
{
    public int IdThongTinViecLamSauTotNghiep { get; set; }

    public int? IdHocVien { get; set; }

    public string? TenDonViCapBang { get; set; }

    public string? DonViTuyenDung { get; set; }

    public int? IdHinhThucTuyenDung { get; set; }

    public DateOnly? ThoiGianTuyenDung { get; set; }

    public int? IdViTriViecLam { get; set; }

    public int? MucLuongKhoiDiem { get; set; }

    public  DmHinhThucTuyenDung? IdHinhThucTuyenDungNavigation { get; set; }

    public  TbHocVien? IdHocVienNavigation { get; set; }

    public  DmViTriViecLam? IdViTriViecLamNavigation { get; set; }
}
