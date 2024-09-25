using AutoMapper;
using E_Learning.Dtos.Category;
using E_Learning.Dtos.Review;
using E_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Application.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<ReviewDTO, Review>().ReverseMap();
        }
    }
}
