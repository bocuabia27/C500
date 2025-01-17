﻿using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmLoaiDeAnChuongTrinh
{
    public int IdLoaiDeAnChuongTrinh { get; set; }

    public string? LoaiDeAnChuongTrinh { get; set; }

    public  ICollection<TbPhongHocGiangDuongHoiTruong> TbPhongHocGiangDuongHoiTruongs { get; set; } = new List<TbPhongHocGiangDuongHoiTruong>();

    public  ICollection<TbToChucHopTacDoanhNghiep> TbToChucHopTacDoanhNghieps { get; set; } = new List<TbToChucHopTacDoanhNghiep>();
}
