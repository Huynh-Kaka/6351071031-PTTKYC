    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BTL_WINFORM.Models.Entities
    {
        public class Voucher
        {
            public Guid Id { get; set; }
            public string MaVoucher { get; set; }
            public char LoaiGiamGia { get; set; }  // 'P' for Percentage, 'F' for Fixed Amount
            public decimal GiaTriGiam { get; set; }
            public DateTime NgayBatDau { get; set; }
            public DateTime NgayHetHan { get; set; }
            public int SoLanToiDaSuDung { get; set; }
            public int SoLanDaSuDung { get; set; }
            public decimal? GiaTriDonHangToiThieu { get; set; }
            public bool TrangThai { get; set; }  // True: Active, False: Inactive
        }

    }
