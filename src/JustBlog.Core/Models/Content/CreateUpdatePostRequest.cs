﻿using AutoMapper;
using JustBlog.Core.Domain.Content;
using System.ComponentModel.DataAnnotations;

namespace JustBlog.Core.Models.Content
{
    public class CreateUpdatePostRequest
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public string? Thumbnail { get; set; }
        public Guid CategoryId { get; set; }

        public string? Content { get; set; }

        public string? Source { get; set; }

        public string? Tags { get; set; }

        public string? SeoDescription { get; set; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<CreateUpdatePostRequest, Post>();
            }
        }
    }
}