using AutoMapper;

namespace Api.Mapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(p =>
            {
                p.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
