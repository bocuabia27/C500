using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbHopDong
{
    public int IdHopDong { get; set; }

    public int? IdCanBo { get; set; }

    public string? SoHopDong { get; set; }

    public int? IdLoaiHopDong { get; set; }

    public string? SoQuyetDinh { get; set; }

    public DateOnly? NgayQuyetDinh { get; set; }

    public DateOnly? CoGiaTriTu { get; set; }

    public DateOnly? CoGiaTriDen { get; set; }

    public int? IdTinhTrangHopDong { get; set; }

    public bool? LamViecToanThoiGian { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmLoaiHopDong? IdLoaiHopDongNavigation { get; set; }

    public  DmTinhTrangHopDong? IdTinhTrangHopDongNavigation { get; set; }
}
