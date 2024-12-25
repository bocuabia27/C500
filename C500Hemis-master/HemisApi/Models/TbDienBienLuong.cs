using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDienBienLuong
{
    public int IdDienBienLuong { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdTrinhDoDaoTao { get; set; }

    public DateOnly? NgayThangNam { get; set; }

    public int? IdBacLuong { get; set; }

    public int? IdHeSoLuong { get; set; }

    public  DmBacLuong1? IdBacLuongNavigation { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmHeSoLuong? IdHeSoLuongNavigation { get; set; }

    public  DmTrinhDoDaoTao? IdTrinhDoDaoTaoNavigation { get; set; }
}
