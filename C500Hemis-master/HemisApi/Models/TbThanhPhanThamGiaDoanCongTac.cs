using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbThanhPhanThamGiaDoanCongTac
{
    public int IdThanhPhanThamGiaDoanCongTac { get; set; }

    public int? IdDoanCongTac { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdVaiTroThamGia { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  TbDoanCongTac? IdDoanCongTacNavigation { get; set; }

    public  DmVaiTroThamGium? IdVaiTroThamGiaNavigation { get; set; }
}
