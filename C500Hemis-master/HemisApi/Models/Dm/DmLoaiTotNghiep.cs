﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiTotNghiep
{
    public int IdLoaiTotNghiep { get; set; }

    public string? LoaiTotNghiep { get; set; }

    public  ICollection<TbDanhSachVanBangChungChi> TbDanhSachVanBangChungChis { get; set; } = new List<TbDanhSachVanBangChungChi>();

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();
}
