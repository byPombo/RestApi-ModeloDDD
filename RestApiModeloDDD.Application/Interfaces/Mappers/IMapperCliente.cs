﻿using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityDto(Cliente cliente);
    }
}