using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiPhongThiNghiem
{
    public int IdLoaiPhongThiNghiem { get; set; }

    public string? LoaiPhongThiNghiem { get; set; }

    public  ICollection<TbPhongThiNghiem> TbPhongThiNghiems { get; set; } = new List<TbPhongThiNghiem>();
}
