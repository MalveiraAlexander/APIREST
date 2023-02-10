using APIRest.Models;
using APIRest.Requests;
using AutoMapper;

namespace APIRest.MappingServices
{
    public class AutoRequestMappingService : Profile
    {
        public AutoRequestMappingService()
        {

            #region Request
            CreateMap<AutoRequest, Auto>();
            #endregion

        }
    }
}
