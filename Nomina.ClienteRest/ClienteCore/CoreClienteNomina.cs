using Api.Models.Nomina.Api.Response;
using Aplics.Nominix.DTOS;
using Nomina.ClienteRest.Client;
using System;
using System.Collections.Generic;
using System.Text;
//using static Api.Models.Nomina.OperationResult.OperationResult;

namespace Nomina.ClienteRest.ClienteCore
{
    public class CoreClienteNomina
    {
        public CoreClienteNomina()
        {

        }
        //public OperationResult AgregarEstudioCatalogo(AgregarEstudioACatalgoRequestDTO _Request, string EndPoint, ClaimsIdentity Claims)
        //{
        //    OperationResult _OperationResult = new OperationResult();
        //    try
        //    {
        //        Cliente _Client = new Cliente();
        //        _Client.SetEndPoint(EndPoint);
        //        if (!(_OperationResult = _Client.SetToken(Claims)).IsOK())
        //            return _OperationResult;
        //        _OperationResult = _Client.AgregarEstudioCatalogo(_Request);
        //    }
        //    catch (Exception ex)
        //    {
        //        this._Logger.LogError(ex);
        //        _OperationResult.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
        //        _OperationResult.AddException(ex);
        //    }
        //    return _OperationResult;
        //}

        public ObtenerListEmpleadosResponseDTO GetEmpleados(string EndPoint)
        {
            ObtenerListEmpleadosResponseDTO Response = new ObtenerListEmpleadosResponseDTO();
            try
            {
                Cliente _Client = new Cliente();
                _Client.SetEndPoint(EndPoint);
                //if (!(Response.Result = _Client.SetToken(Claims)).IsOK())
                //    return Response;
                Response = _Client.GetAutorizaciones();
            }
            catch (Exception ex)
            {
                //this._Logger.LogError(ex);
                Response.Result.SetStatusCode(Api.Models.Nomina.OperationResult.OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                Response.Result.AddException(ex);
            }
            return Response;
        }
        public SelctGeneralResponseDTO GetCategoria(string EndPoint,string _RouteApi)
        {
            SelctGeneralResponseDTO Response = new SelctGeneralResponseDTO();
            try
            {
                Cliente _Client = new Cliente();
                _Client.SetEndPoint(EndPoint);
                //if (!(Response.Result = _Client.SetToken(Claims)).IsOK())
                //    return Response;
                Response = _Client.GetCategoria(_RouteApi);
            }
            catch (Exception ex)
            {
                //this._Logger.LogError(ex);
                Response.Result.SetStatusCode(Api.Models.Nomina.OperationResult.OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                Response.Result.AddException(ex);
            }
            return Response;
        }
        public GetListCompaniasResponseDTO GetListCompanias(string EndPoint, string _RouteApi)
        {
            GetListCompaniasResponseDTO Response = new GetListCompaniasResponseDTO();
            try
            {
                Cliente _Client = new Cliente();
                _Client.SetEndPoint(EndPoint);
                //if (!(Response.Result = _Client.SetToken(Claims)).IsOK())
                //    return Response;
                Response = _Client.GetSelectCompanias(_RouteApi);
            }
            catch (Exception ex)
            {
                //this._Logger.LogError(ex);
                Response.Result.SetStatusCode(Api.Models.Nomina.OperationResult.OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                Response.Result.AddException(ex);
            }
            return Response;
        }
        public SelctGeneralResponseDTO SelectGral(string EndPoint, string _RouteApi)
        {
            SelctGeneralResponseDTO Response = new SelctGeneralResponseDTO();
            try
            {
                Cliente _Client = new Cliente();
                _Client.SetEndPoint(EndPoint);
                //if (!(Response.Result = _Client.SetToken(Claims)).IsOK())
                //    return Response;
                Response = _Client.GetSelectGral(_RouteApi);
            }
            catch (Exception ex)
            {
                //this._Logger.LogError(ex);
                Response.Result.SetStatusCode(Api.Models.Nomina.OperationResult.OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                Response.Result.AddException(ex);
            }
            return Response;
        }


     


    }
}
