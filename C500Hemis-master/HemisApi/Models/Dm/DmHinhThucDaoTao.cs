using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmHinhThucDaoTao
{
    public int IdHinhThucDaoTao { get; set; }

    public string? HinhThucDaoTao { get; set; }

    public  ICollection<TbHinhThucDaoTaoCuaNganh> TbHinhThucDaoTaoCuaNganhs { get; set; } = new List<TbHinhThucDaoTaoCuaNganh>();

    public  ICollection<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai> TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoais { get; set; } = new List<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai>();
}
