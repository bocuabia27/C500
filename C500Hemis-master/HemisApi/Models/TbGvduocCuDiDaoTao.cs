using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbGvduocCuDiDaoTao
{
    public int IdGvduocCuDiDaoTao { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdHinhThucThamGiaGvduocCuDiDaoTao { get; set; }

    public int? IdQuocGiaDen { get; set; }

    public string? TenCoSoGiaoDucThamGiaOnn { get; set; }

    public DateOnly? ThoiGianBatDau { get; set; }

    public DateOnly? ThoiGianKetThuc { get; set; }

    public int? IdTinhTrangGvduocCuDiDaoTao { get; set; }

    public int? IdNguonKinhPhiCuaGv { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmHinhThucThamGiaGvduocCuDiDaoTao? IdHinhThucThamGiaGvduocCuDiDaoTaoNavigation { get; set; }

    public  DmNguonKinhPhiCuaGvduocCuDiDaoTao? IdNguonKinhPhiCuaGvNavigation { get; set; }

    public  DmQuocTich? IdQuocGiaDenNavigation { get; set; }

    public  DmTinhTrangGiangVienDuocCuDiDaoTao? IdTinhTrangGvduocCuDiDaoTaoNavigation { get; set; }
}
