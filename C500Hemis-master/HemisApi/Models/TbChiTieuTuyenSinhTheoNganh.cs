﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbChiTieuTuyenSinhTheoNganh
{
    public int IdChiTieuTuyenSinhTheoNganh { get; set; }

    public int? IdLoaiHinhDaoTao { get; set; }

    public int? IdNganhDaoTao { get; set; }

    public string? Nam { get; set; }

    public int? ChiTieu { get; set; }

    public  DmLoaiHinhDaoTao? IdLoaiHinhDaoTaoNavigation { get; set; }

    public  DmNganhDaoTao? IdNganhDaoTaoNavigation { get; set; }
}
