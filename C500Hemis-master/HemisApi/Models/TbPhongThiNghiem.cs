﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbPhongThiNghiem
{
    public int IdPhongThiNghiem { get; set; }

    public int? IdCongTrinhCsvc { get; set; }

    public int? IdLoaiPhongThiNghiem { get; set; }

    public int? IdLinhVuc { get; set; }

    public string? MucDoDapUngNhuCauNckh { get; set; }

    public string? NamDuaVaoSuDung { get; set; }

    public  TbCongTrinhCoSoVatChat? IdCongTrinhCsvcNavigation { get; set; }

    public  DmLinhVucNghienCuu? IdLinhVucNavigation { get; set; }

    public  DmLoaiPhongThiNghiem? IdLoaiPhongThiNghiemNavigation { get; set; }
}
