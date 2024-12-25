using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbHinhThucDaoTaoCuaNganh
{
    public int IdHinhThucDaoTaoCuaNganh { get; set; }

    public int? IdNganhDaoTao { get; set; }

    public int? IdHinhThucDaoTao { get; set; }

    public int? SoNamDaoTao { get; set; }

    public  DmHinhThucDaoTao? IdHinhThucDaoTaoNavigation { get; set; }

    public  DmNganhDaoTao? IdNganhDaoTaoNavigation { get; set; }
}
