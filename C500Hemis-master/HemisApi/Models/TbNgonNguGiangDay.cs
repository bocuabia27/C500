using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbNgonNguGiangDay
{
    public int IdNgonNguGiangDay { get; set; }

    public int? IdChuongTrinhDaoTao { get; set; }

    public int? IdNgonNgu { get; set; }

    public int? IdTrinhDoNgonNguDauVao { get; set; }

    public  TbChuongTrinhDaoTao? IdChuongTrinhDaoTaoNavigation { get; set; }

    public  DmNgoaiNgu? IdNgonNguNavigation { get; set; }

    public  DmKhungNangLucNgoaiNgu? IdTrinhDoNgonNguDauVaoNavigation { get; set; }
}
