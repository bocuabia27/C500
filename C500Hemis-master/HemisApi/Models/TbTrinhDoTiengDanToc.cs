using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbTrinhDoTiengDanToc
{
    public int IdTrinhDoTiengDanToc { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdTiengDanToc { get; set; }

    public int? IdKhungNangLucNgoaiNgu { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmKhungNangLucNgoaiNgu? IdKhungNangLucNgoaiNguNavigation { get; set; }

    public  DmTiengDanToc? IdTiengDanTocNavigation { get; set; }
}
