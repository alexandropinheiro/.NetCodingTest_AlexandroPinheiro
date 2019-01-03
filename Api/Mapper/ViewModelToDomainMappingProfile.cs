using Api.ViewModels;
using AutoMapper;
using Dominio.Employees;

namespace Api.Mapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EmployeeViewModel, Employee>()
                .ForMember(e => e.Id, evw => evw.Ignore());
        }
    }
}
