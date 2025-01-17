﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbToChucKiemDinh
{
    public int IdToChucKiemDinhCsdg { get; set; }

    public int? IdToChucKiemDinh { get; set; }

    public int? IdKetQua { get; set; }

    public string? SoQuyetDinhKiemDinh { get; set; }

    public DateOnly? NgayCapChungNhanKiemDinh { get; set; }

    public DateOnly? ThoiHanKiemDinh { get; set; }

    public  DmKetQuaKiemDinh? IdKetQuaNavigation { get; set; }

    public  DmToChucKiemDinh? IdToChucKiemDinhNavigation { get; set; }
}
