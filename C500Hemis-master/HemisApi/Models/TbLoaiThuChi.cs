﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbLoaiThuChi
{
    public int IdLoaiThuChi { get; set; }

    public string? MaLoaiThuChi { get; set; }

    public int? IdPhanLoaiThuChi { get; set; }

    public string? TenLoaiThuChi { get; set; }

    public string? MoTa { get; set; }

    public  DmPhanLoaiThuChi? IdPhanLoaiThuChiNavigation { get; set; }

    public  ICollection<TbChiTietThuChi> TbChiTietThuChis { get; set; } = new List<TbChiTietThuChi>();
}
