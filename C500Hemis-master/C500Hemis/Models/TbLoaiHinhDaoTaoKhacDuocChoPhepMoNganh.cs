﻿using System;
using System.Collections.Generic;
using C500Hemis.Models.DM;

namespace C500Hemis.Models;

public partial class TbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh
{
    public int IdLoaiHinhDaoTaoKhacDuocChoPhepMoNganh { get; set; }

    public int? IdNganhDaoTao { get; set; }

    public int? IdLoaiHinhDaoTao { get; set; }

    public string? SoQuyetDinhChoPhep { get; set; }

    public DateOnly? NgayBanHanhQuyetDinhChoPhep { get; set; }

    public  DmLoaiHinhDaoTao? IdLoaiHinhDaoTaoNavigation { get; set; }

    public  DmNganhDaoTao? IdNganhDaoTaoNavigation { get; set; }
}