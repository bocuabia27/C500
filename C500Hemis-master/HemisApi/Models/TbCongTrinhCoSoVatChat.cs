using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbCongTrinhCoSoVatChat
{
    public int IdCongTrinhCoSoVatChat { get; set; }

    public string? MaCongTrinh { get; set; }

    public string? TenCongTrinh { get; set; }

    public int? IdLoaiCongTrinh { get; set; }

    public int? IdMucDichSuDung { get; set; }

    public string? DoiTuongSuDung { get; set; }

    public double? DienTichSanXayDung { get; set; }

    public double? VonBanDau { get; set; }

    public double? VonDauTu { get; set; }

    public int? IdTinhTrangCsvc { get; set; }

    public int? IdHinhThucSoHuu { get; set; }

    public int? CongTrinhCsvctrongNha { get; set; }

    public int? SoPhongOcongVu { get; set; }

    public int? SoChoOchoCanBoGiangDay { get; set; }

    public string? NamDuaVaoSuDung { get; set; }

    public  DmTuyChon? CongTrinhCsvctrongNhaNavigation { get; set; }

    public  DmHinhThucSoHuu? IdHinhThucSoHuuNavigation { get; set; }

    public  DmLoaiCongTrinhCoSoVatChat? IdLoaiCongTrinhNavigation { get; set; }

    public  DmMucDichSuDungCsvc? IdMucDichSuDungNavigation { get; set; }

    public  DmTinhTrangCoSoVatChat? IdTinhTrangCsvcNavigation { get; set; }

    public  ICollection<TbPhongThiNghiem> TbPhongThiNghiems { get; set; } = new List<TbPhongThiNghiem>();

    public  ICollection<TbPhongThucHanh> TbPhongThucHanhs { get; set; } = new List<TbPhongThucHanh>();

    public  ICollection<TbThietBiPtnThtren500Tr> TbThietBiPtnThtren500Trs { get; set; } = new List<TbThietBiPtnThtren500Tr>();
}
