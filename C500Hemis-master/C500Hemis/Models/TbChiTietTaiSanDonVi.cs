﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using C500Hemis.Models.DM;
using Microsoft.AspNetCore.Authorization;

namespace C500Hemis.Models;

[Authorize]
public partial class TbChiTietTaiSanDonVi
{
    public int IdChiTietTaiSanDonVi { get; set; }
    [DisplayName(displayName: "Tài Sản Đơn Vị")]

    public int? IdTaiSanDonVi { get; set; }
    [DisplayName(displayName: "Mã Tài Sản")]

    public string? MaTaiSan { get; set; }
    [DisplayName(displayName: "Tên Tài Sản")]

    public string? TenTaiSan { get; set; }
    [DisplayName(displayName: "Nguyên Giá")]

    public int? NguyenGia { get; set; }
    [DisplayName(displayName: "Tình Trạng Thiết Bị")]

    public int? IdTinhTrangThietBi { get; set; }
    [DisplayName(displayName: "Hình Thức Sở Hữu")]

    public int? IdChuSoHuu { get; set; }

    public  DmChuSoHuu? IdChuSoHuuNavigation { get; set; }

    public  TbTaiSanDonVi? IdTaiSanDonViNavigation { get; set; }

    public  DmTinhTrangThietBi? IdTinhTrangThietBiNavigation { get; set; }
}
