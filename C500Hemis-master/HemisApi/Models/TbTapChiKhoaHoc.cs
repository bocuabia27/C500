﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbTapChiKhoaHoc
{
    public int IdTapChiKhoaHoc { get; set; }

    public string? MaTapChi { get; set; }

    public string? TenTapChiTiengViet { get; set; }

    public string? TenTapChiTiengAnh { get; set; }

    public string? MaChuanIssn { get; set; }

    public int? IdLinhVucXuatBan { get; set; }

    public int? IdXepLoaiTapChi { get; set; }

    public int? SoBaiBao1Nam { get; set; }

    public  DmLinhVucNghienCuu? IdLinhVucXuatBanNavigation { get; set; }

    public  DmTapChiTrongNuoc? IdXepLoaiTapChiNavigation { get; set; }
}
