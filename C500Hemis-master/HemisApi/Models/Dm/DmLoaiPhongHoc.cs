﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiPhongHoc
{
    public int IdLoaiPhongHoc { get; set; }

    public string? LoaiPhongHoc { get; set; }

    public  ICollection<TbPhongHocGiangDuongHoiTruong> TbPhongHocGiangDuongHoiTruongs { get; set; } = new List<TbPhongHocGiangDuongHoiTruong>();
}
