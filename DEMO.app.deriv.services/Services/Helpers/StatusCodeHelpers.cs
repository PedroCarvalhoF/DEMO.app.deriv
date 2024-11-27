using RestSharp;
using System;

namespace DEMO.app.deriv.services.Services.Helpers
{
    public static class StatusCodeHelpers
    {
        public static string GetStatusCodeResponse(RestResponse response)
        {
            if (response.IsSuccessStatusCode)
                return response.Content;

            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.BadRequest:
                    return response.Content;

                case System.Net.HttpStatusCode.UnsupportedMediaType:
                    throw new ArgumentException("Não foi possível realizar tarefa. Para completar a requisição é necessário todas as propriedades requeridas.");

                case System.Net.HttpStatusCode.Unauthorized:
                    throw new ArgumentException("Sem permissão.");

                case System.Net.HttpStatusCode.NotFound:
                    throw new ArgumentException("Não foi possivel acessar a rota.");

                case System.Net.HttpStatusCode.MethodNotAllowed:
                    throw new ArgumentException("Não foi possivel acessar a rota.");

                case System.Net.HttpStatusCode.NotImplemented:
                    throw new ArgumentException("Método não implementado.");
                default:
                    throw new ArgumentException("Não foi possível realizar requisição.");
            }
        }
    }
}
