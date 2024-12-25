using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiLienKet
{
    public int IdLoaiLienKet { get; set; }

    public string? LoaiLienKet { get; set; }

    public  ICollection<TbDonViLienKetDaoTaoGiaoDuc> TbDonViLienKetDaoTaoGiaoDucs { get; set; } = new List<TbDonViLienKetDaoTaoGiaoDuc>();
}
