using System;
using System.Collections.Generic;
using C500Hemis.Models.DM;

namespace C500Hemis.Models;

public partial class TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai
{
    public int IdQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai { get; set; }

    public int? IdChuongTrinhDaoTao { get; set; }

    public int? IdLoaiQuyetDinh { get; set; }

    public string? SoQuyetDinh { get; set; }

    public DateOnly? NgayBanHanhQuyetDinh { get; set; }

    public int? IdHinhThucDaoTao { get; set; }

    public  TbChuongTrinhDaoTao? IdChuongTrinhDaoTaoNavigation { get; set; }

    public  DmHinhThucDaoTao? IdHinhThucDaoTaoNavigation { get; set; }

    public  DmLoaiQuyetDinh? IdLoaiQuyetDinhNavigation { get; set; }
}
