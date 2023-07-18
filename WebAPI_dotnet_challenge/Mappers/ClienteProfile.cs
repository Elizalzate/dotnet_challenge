using AutoMapper;
using Core;
using GestionClientesAPI.DTO;

namespace GestionClientesAPI.Mappers;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<Cliente, CreateClientDTO>();
        CreateMap<CreateClientDTO, Cliente>();
    }
}