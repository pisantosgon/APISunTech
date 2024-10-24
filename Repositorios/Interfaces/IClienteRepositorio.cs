﻿using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> GetAll();

        Task<ClienteModel> GetById(int id);

        Task<ClienteModel> Login(string email, string password );

        Task<ClienteModel> InsertCliente(ClienteModel cliente);

        Task<ClienteModel> UpdateCliente(ClienteModel cliente, int id);

        Task<bool> DeleteCliente(int id);
    }
}
