using System.Collections.Generic;
using System.Web.Mvc;

namespace TranVanCuong.SachOnline.Controllers
{
    public class SachOnlineController : Controller
    {
        public ActionResult Index()
        {
            return View(); // Điều hướng tới Views/SachOnline/Index.cshtml
        }

        // Partial: Thanh điều hướng (Nav)
        public ActionResult NavPartial()
        {
            return PartialView(); // Nội dung tùy chỉnh trong NavPartial.cshtml
        }

        // Partial: Slider quảng cáo
        public ActionResult SliderPartial()
        {
            // Dữ liệu giả lập: danh sách đường dẫn ảnh
            var danhSachAnh = new List<string> { "slide1.jpg", "slide2.jpg", "slide3.jpg" };
            return PartialView(danhSachAnh);
        }

        // Partial: Chủ đề sách
        public ActionResult ChuDePartial()
        {
            // Dữ liệu giả lập: danh sách chủ đề sách
            var chuDe = new List<string> { "Văn học", "Kinh tế", "Công nghệ", "Giáo dục" };
            return PartialView(chuDe);
        }

        // Partial: Nhà xuất bản
        public ActionResult NhaXuatBanPartial()
        {
            // Dữ liệu giả lập: danh sách nhà xuất bản
            var nhaXuatBan = new List<string> { "NXB Giáo dục", "NXB Văn học", "NXB Khoa học" };
            return PartialView(nhaXuatBan);
        }

        // Partial: Sách bán nhiều
        public ActionResult SachBanNhieuPartial()
        {
            // Dữ liệu giả lập: danh sách sách bán nhiều với tên và ảnh minh họa
            var sachBanNhieu = new List<SachBanNhieu>
            {
                new SachBanNhieu { TenSach = "Sách 1", AnhBia = "book1.jpg" },
                new SachBanNhieu { TenSach = "Sách 2", AnhBia = "book2.jpg" },
                new SachBanNhieu { TenSach = "Sách 3", AnhBia = "book3.jpg" },
                new SachBanNhieu { TenSach = "Sách 4", AnhBia = "book4.jpg" },
                new SachBanNhieu { TenSach = "Sách 5", AnhBia = "book5.jpg" },
                new SachBanNhieu { TenSach = "Sách 6", AnhBia = "book6.jpg" }
            };
            return PartialView(sachBanNhieu);
        }

        // Partial: Footer
        public ActionResult FooterPartial()
        {
            return PartialView(); // Nội dung tĩnh trong FooterPartial.cshtml
        }
    }

    // Lớp model giả lập cho sách bán nhiều
    public class SachBanNhieu
    {
        public string TenSach { get; set; }
        public string AnhBia { get; set; }
    }
}
