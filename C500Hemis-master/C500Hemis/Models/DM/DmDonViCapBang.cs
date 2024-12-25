using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmDonViCapBang
{
    public int IdDonViCapBang { get; set; }

    public string? DonViCapBang { get; set; }

    public  ICollection<TbChuongTrinhDaoTao> TbChuongTrinhDaoTaos { get; set; } = new List<TbChuongTrinhDaoTao>();
}
