using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DuBaoThoiTietController : ApiController
    {
        DBTTEntities db = new DBTTEntities();

        [HttpGet]
        [Route("ThongTinThoiTiet")]
        public List<ThoiTietTrongNgay> ThongTinThoiTiet()
        {
            return db.ThoiTietTrongNgays.ToList();
        }

        [HttpPost]
        [Route("Them")]
        public bool Them(System.DateTime gio, string maKhuVuc, decimal nhietDo, decimal doAm)
        {
            ThoiTietTrongNgay checkEx = db.ThoiTietTrongNgays.FirstOrDefault(x => x.Gio == gio && x.MaKhuVuc == maKhuVuc);
            if (checkEx == null)
            {
                ThoiTietTrongNgay tt = new ThoiTietTrongNgay();
                tt.Gio = gio;
                tt.DoAm = doAm;
                tt.MaKhuVuc = maKhuVuc;
                tt.NhietDo = nhietDo;
                db.ThoiTietTrongNgays.Add(tt);
                db.SaveChanges();
                return true;
            }
            return false;
        }


        [HttpDelete]
        [Route("Xoa")]
        public bool Xoa(System.DateTime gio, string maKhuVuc)
        {
            ThoiTietTrongNgay checkEx = db.ThoiTietTrongNgays.FirstOrDefault(x => x.Gio == gio && x.MaKhuVuc == maKhuVuc);
            if (checkEx != null)
            {
                db.ThoiTietTrongNgays.Remove(checkEx);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        [Route("Sua")]
        public bool Sua(System.DateTime gio, string maKhuVuc, decimal nhietDo, decimal doAm)
        {
            // Kiểm tra xem bản ghi có tồn tại không
            ThoiTietTrongNgay checkEx = db.ThoiTietTrongNgays.FirstOrDefault(x => x.Gio == gio && x.MaKhuVuc == maKhuVuc);

            if (checkEx != null)
            {
                // Cập nhật thông tin bản ghi
                checkEx.NhietDo = nhietDo;
                checkEx.DoAm = doAm;

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();
                return true;
            }

            return false;
        }
        [HttpGet]
        [Route("TimKiem")]
        public List<ThoiTietTrongNgay> TimKiem(System.DateTime gio, string maKhuVuc)
        {
            // Tìm kiếm bản ghi theo gio và maKhuVuc
            var result = db.ThoiTietTrongNgays
                           .Where(x => x.Gio == gio && x.MaKhuVuc == maKhuVuc)
                           .ToList();

            return result;
        }

    }
}
