using AutoMapper;
using JustBlog.Core.Domain.Content;

namespace JustBlog.Core.Models.Content
{
    public class PostCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { set; get; }
        public string Slug { set; get; }
        public Guid? ParentId { set; get; }
        public bool IsActive { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime? DateModified { set; get; }
        public string? SeoDescription { set; get; }
        public int SortOrder { set; get; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<PostCategory, PostCategoryDto>();
            }
        }
    }
}