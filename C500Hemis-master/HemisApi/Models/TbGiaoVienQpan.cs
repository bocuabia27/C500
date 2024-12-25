using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbGiaoVienQpan
{
    public int IdGiaoVienQpan { get; set; }

    public int? IdCanBo { get; set; }

    public DateOnly? NamBatDauBietPhai { get; set; }

    public DateOnly? SoNamBietPhai { get; set; }

    public int? IdLoaiGiangVienQp { get; set; }

    public string? DaoTaoGdqpan { get; set; }

    public int? IdQuanHam { get; set; }

    public string? SoTruongCongTac { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmLoaiGiangVienQuocPhong? IdLoaiGiangVienQpNavigation { get; set; }

    public  DmQuanHam? IdQuanHamNavigation { get; set; }
}
