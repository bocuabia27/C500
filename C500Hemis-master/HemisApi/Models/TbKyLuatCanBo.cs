using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbKyLuatCanBo
{
    public int IdKyLuatCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdLoaiKyLuat { get; set; }

    public string? LyDo { get; set; }

    public int? IdCapQuyetDinh { get; set; }

    public DateOnly? NgayThangNamQuyetDinh { get; set; }

    public string? SoQuyetDinh { get; set; }

    public DateOnly? NamBiKyLuat { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmCapKhenThuong? IdCapQuyetDinhNavigation { get; set; }

    public  DmLoaiKyLuat? IdLoaiKyLuatNavigation { get; set; }
}
