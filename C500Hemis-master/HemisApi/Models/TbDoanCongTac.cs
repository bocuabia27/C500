using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDoanCongTac
{
    public int IdDoanCongTac { get; set; }

    public string? MaDoanCongTac { get; set; }

    public int? IdPhanLoaiDoanRaDoanVao { get; set; }

    public string? TenDoanCongTac { get; set; }

    public string? SoQuyetDinh { get; set; }

    public DateOnly? NgayQuyetDinh { get; set; }

    public int? IdQuocGiaDoan { get; set; }

    public DateOnly? ThoiGianBatDau { get; set; }

    public DateOnly? ThoiGianketThuc { get; set; }

    public string? MucDichCongTac { get; set; }

    public string? KetQuaCongTac { get; set; }

    public  DmPhanLoaiDoanRaDoanVao? IdPhanLoaiDoanRaDoanVaoNavigation { get; set; }

    public  DmQuocTich? IdQuocGiaDoanNavigation { get; set; }

    public  ICollection<TbThanhPhanThamGiaDoanCongTac> TbThanhPhanThamGiaDoanCongTacs { get; set; } = new List<TbThanhPhanThamGiaDoanCongTac>();
}
