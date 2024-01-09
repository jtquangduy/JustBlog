using AutoMapper;
using JustBlog.Core.Domain.Content;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustBlog.Core.Models.Content
{
    public class CreateUpdatePostCategoryRequest
    {
        [MaxLength(250)]
        public string Name { set; get; }

        [Column(TypeName = "varchar(250)")]
        public string Slug { set; get; }

        public Guid? ParentId { set; get; }
        public bool IsActive { set; get; }
        public string? SeoKeywords { set; get; }
        public string? SeoDescription { set; get; }
        public int SortOrder { set; get; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<CreateUpdatePostCategoryRequest, PostCategory>();
            }
        }
    }
}