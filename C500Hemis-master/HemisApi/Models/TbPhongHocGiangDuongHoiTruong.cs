using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbPhongHocGiangDuongHoiTruong
{
    public int IdPhongHocGiangDuongHoiTruong { get; set; }

    public string? MaPhongHocGiangDuongHoiTruong { get; set; }

    public string? TenPhongHocGiangDuongHoiTruong { get; set; }

    public double? DienTich { get; set; }

    public int? IdHinhThucSoHuu { get; set; }

    public int? QuyMoChoNgoi { get; set; }

    public int? IdTinhTrangCoSoVatChat { get; set; }

    public int? IdPhanLoaiCsvc { get; set; }

    public int? IdLoaiPhongHoc { get; set; }

    public int? IdLoaiDeAn { get; set; }

    public string? NamDuaVaoSuDung { get; set; }

    public  DmHinhThucSoHuu? IdHinhThucSoHuuNavigation { get; set; }

    public  DmLoaiDeAnChuongTrinh? IdLoaiDeAnNavigation { get; set; }

    public  DmLoaiPhongHoc? IdLoaiPhongHocNavigation { get; set; }

    public  DmPhanLoaiCsvc? IdPhanLoaiCsvcNavigation { get; set; }

    public  DmTinhTrangCoSoVatChat? IdTinhTrangCoSoVatChatNavigation { get; set; }
}
