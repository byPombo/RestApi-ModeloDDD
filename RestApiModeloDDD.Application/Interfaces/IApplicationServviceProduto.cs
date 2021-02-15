using RestApiModeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServviceProduto
    {
        void Add(ProdutoDto clienteDto);

        void Update(ProdutoDto clienteDto);

        void Remove(ProdutoDto clienteDto);

        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetById(int id);
    }
}
