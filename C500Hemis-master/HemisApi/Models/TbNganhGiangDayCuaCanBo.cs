using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbNganhGiangDayCuaCanBo
{
    public int IdNganhGiangDayCuaCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdTrinhDoDaoTao { get; set; }

    public int? IdNganh { get; set; }

    public bool? LaNganhChinh { get; set; }

    public string? DonViThinhGiang { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmNganhDaoTao? IdNganhNavigation { get; set; }

    public  DmTrinhDoDaoTao? IdTrinhDoDaoTaoNavigation { get; set; }
}
