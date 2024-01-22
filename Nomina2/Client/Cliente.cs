using Api.Models.Nomina.Api.Response;
using Api.Models.Nomina.ApiRequest;
using Api.Models.Nomina.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using static Api.Models.Nomina.OperationResult.OperationResult;

namespace Nomina.ClienteRest.Client
{
    public class Cliente
    {
        private string UrlEndPoint;
        public Cliente()
        {
            this.UrlEndPoint = string.Empty;
        }

        public bool ExisteEndPoint()
        {
            return !String.IsNullOrEmpty(this.UrlEndPoint);
        }
        public void SetEndPoint(string UrlEndPoint)
        {
            this.UrlEndPoint = UrlEndPoint;
        }

        //public OperationResult AgregarEstudioCatalogo(AgregarEstudioACatalgoRequestDTO Request)
        //{
        //    OperationResult _OperationResult = new OperationResult();
        //    if (!this.ExisteEndPoint())
        //    {
        //        _OperationResult.SetStatusCode(OperationResult.StatusCodesEnum.UNAUTHORIZED);
        //        _OperationResult.AddException(new Exception("Es necesario asignar una UrlEndPoint."));
        //        return _OperationResult;
        //    }
        //    else if (Request == null)
        //    {
        //        _OperationResult.SetStatusCode(OperationResult.StatusCodesEnum.BAD_REQUEST);
        //        _OperationResult.AddException(new Exception("Parámetro inválido."));
        //        return _OperationResult;
        //    }
        //    string _Payload = JsonSerializerData.Serialize(Request);
        //    Message _MessageFactory = new Message();
        //    var _Result = _MessageFactory.SendRequest<OperationResult>(this.UrlEndPoint, "/ECE/AgregarEstudioCatalogo", _Payload, HttpMethod.Post);
        //    _OperationResult = _Result;
        //    if (!(_Result != null && _Result != null))
        //    {
        //        _OperationResult.SetStatusCode(OperationResult.StatusCodesEnum.SERVICE_UNAVAILABLE);
        //        _OperationResult.AddException(new Exception("No se recibio respuesta de APISASE"));
        //        return _OperationResult;
        //    }
        //    return _Result;
        //}
        public ObtenerListEmpleadosResponseDTO GetAutorizaciones()
        {
            var Response = new ObtenerListEmpleadosResponseDTO();
            //if (!this.HasToken())
            //{
            //    Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.UNAUTHORIZED);
            //    Response.Result.AddException(new Exception("No se encontro el Token de Autorización."));
            //    return Response;
            //}
            //else 
            if (!this.ExisteEndPoint())
            {
                Response.Result.SetStatusCode(StatusCodesEnum.NOT_FOUND);
                Response.Result.AddException(new Exception("Es necesario asignar una UrlEndPoint."));
                return Response;
            }
            Message _MessageFactory = new Message();
            Response = _MessageFactory.SendRequest<ObtenerListEmpleadosResponseDTO>(this.UrlEndPoint, "/Empleados/Api/Empleados", string.Empty, HttpMethod.Post);
            return Response;
        }
    }
}
