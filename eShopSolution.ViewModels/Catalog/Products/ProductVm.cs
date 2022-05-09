using eShopSolution.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductVm
    {
        public int Id { set; get; }

        [Display(Name = "Giá bán")]
        public decimal Price { set; get; }

        [Display(Name = "Giá gốc")]
        public decimal OriginalPrice { set; get; }

        [Display(Name = "Tồn kho")]
        public int Stock { set; get; }

        [Display(Name = "Số lần xem")]
        public int ViewCount { set; get; }

        [Display(Name = "Ngày tạo")]
        public DateTime DateCreated { set; get; }

        [Display(Name = "Tên")]
        public string Name { set; get; }

        [Display(Name = "Miêu tả")]
        public string Description { set; get; }

        [Display(Name = "Chi tiết sản phẩm")]
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }

        public bool? IsFeatured { get; set; }

        [Display(Name = "Hình ảnh")]
        public string ThumbnailImage { get; set; }

        [Display(Name = "Danh mục")]
        public List<string> Categories { get; set; } = new List<string>();
    }
}