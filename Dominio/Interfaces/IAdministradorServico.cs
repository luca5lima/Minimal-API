using minimalApi.Dominio.Entidades;
using minimalApi.DTOs;

namespace minimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
}    
