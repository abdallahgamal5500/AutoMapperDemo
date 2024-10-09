using AutoMapper;
using System.Net;

namespace AutoMapperDemo
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model2, Model1>()
                .AfterMap((src, dest) =>
                {
                    dest.Name = src.FullName;
                    dest.Description = src.Desc;
                });
        }
    }
}
