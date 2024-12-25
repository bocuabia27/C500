using System;
using System.Collections.Generic;
using C500Hemis.Models.DM;

namespace C500Hemis.Models;

public partial class TbThongTinLinhVucDaoTao
{
    public int IdThongTinLinhVucDaoTao { get; set; }

    public int? IdKhoiNganh { get; set; }

    public int? IdLinhVucDaoTao { get; set; }

    public  TbKhoiNganhDaoTao? IdKhoiNganhNavigation { get; set; }

    public  DmLinhVucDaoTao? IdLinhVucDaoTaoNavigation { get; set; }
}
