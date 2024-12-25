using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmKhoiNganhLinhVucDaoTao
{
    public int IdKhoiNganhLinhVucNghienCuu { get; set; }

    public int? IdKhoiNganh { get; set; }

    public int? IdLinhVucDaoTao { get; set; }

    public  TbKhoiNganhDaoTao? IdKhoiNganhNavigation { get; set; }

    public  DmLinhVucDaoTao? IdLinhVucDaoTaoNavigation { get; set; }
}
