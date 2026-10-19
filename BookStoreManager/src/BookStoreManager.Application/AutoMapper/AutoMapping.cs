using AutoMapper;
using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;
using BookStoreManager.Domain.Entities;

namespace BookStoreManager.Application.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToEntity();
            EntityToResponse();
        }

        private void RequestToEntity()
        {
            CreateMap<RequestRegisterBookJson, Book>().ForMember(dest => dest.Id, config => config.Ignore());
            CreateMap<RequestUpdateBookJson, Book>().ForMember(dest => dest.Id, opt => opt.Ignore());
        }

        private void EntityToResponse()
        {
            CreateMap<Book, ResponseRegisterBookJson>();
            CreateMap<Book, ResponseShortGetAllBookJson>();            
        }
    }
}