﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDonViLienKetDaoTaoGiaoDuc
{
    public int IdDonViLienKetDaoTaoGiaoDuc { get; set; }

    public int? IdCoSoGiaoDuc { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public int? IdLoaiLienKet { get; set; }

    public  TbCoSoGiaoDuc? IdCoSoGiaoDucNavigation { get; set; }

    public  DmLoaiLienKet? IdLoaiLienKetNavigation { get; set; }
}
