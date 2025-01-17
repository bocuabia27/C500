﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbHopDongThinhGiang
{
    public int IdHopDongThinhGiang { get; set; }

    public int? IdCanBo { get; set; }

    public string? MaHopDongThinhGiang { get; set; }

    public string? SoSoLaoDong { get; set; }

    public DateOnly? NgayCapSoLaoDong { get; set; }

    public string? NoiCapSoLaoDong { get; set; }

    public DateOnly? CoGiaTriTu { get; set; }

    public DateOnly? CoGiaTriDen { get; set; }

    public int? IdTrangThaiHopDong { get; set; }

    public int? TyLeThoiGianGiangDay { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmTrangThaiHopDong? IdTrangThaiHopDongNavigation { get; set; }
}
