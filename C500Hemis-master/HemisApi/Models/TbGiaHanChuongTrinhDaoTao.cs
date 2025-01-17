﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbGiaHanChuongTrinhDaoTao
{
    public int IdGiaHanChuongTrinhDaoTao { get; set; }

    public int? IdChuongTrinhDaoTao { get; set; }

    public string? SoQuyetDinhGiaHan { get; set; }

    public DateOnly? NgayBanHanhVanBanGiaHan { get; set; }

    public int? GiaHanLanThu { get; set; }

    public  TbChuongTrinhDaoTao? IdChuongTrinhDaoTaoNavigation { get; set; }
}
