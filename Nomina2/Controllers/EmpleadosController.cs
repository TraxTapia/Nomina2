
using Api.Models.Nomina.Api.Response;
using Api.Models.Nomina.OperationResult;
using Aplics.Nominix.DTOS;
using Aplics.Nominix.DTOS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nomina.ClienteRest.ClienteCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Nomina2.Controllers
{
    public class EmpleadosController : Controller
    {
        public string UrlEndPoint = "https://localhost:44347/";
        public ActionResult Index()
        {
            // ComboGeneralResponseDTO _ListUbicaciones = new ComboGeneralResponseDTO();
            // _ListUbicaciones.List = new List<dto_ComboGral>()
            // { new dto_ComboGral() {
            //     Valor = "1",
            //     Descripcion ="Valor 1"

            //},new dto_ComboGral() {
            //     Valor = "2",
            //     Descripcion ="Valor 2"

            //},new dto_ComboGral() {
            //     Valor = "3",
            //     Descripcion ="Valor 3"

            //}, };
            // List<SelectListItem> items = _ListUbicaciones.List.ConvertAll(X =>
            // {

            //     return new SelectListItem()
            //     {

            //         Value = X.Valor,
            //         Text = X.Descripcion.ToString(),
            //         Selected = false

            //     };
            // });
            // ViewBag.Select = items;

            return View();
        }
        public ActionResult Empleados()
        {
            return View();
        }
        public ActionResult Ubicaciones()
        {


            return PartialView("_UbicacionVP");
        }
        public ActionResult FechasSueldos()
        {
            return PartialView("_FechasSueldosVP");
        }
        public ActionResult FiscalesPersonales()
        {
            return PartialView("_FiscalesPersonalesVP");
        }
        [HttpPost]
        public ActionResult GetEmpleados()
        {
            ServiceResponse<List<dto_Empleados>> _Response = new ServiceResponse<List<dto_Empleados>>();
            CallService _Serice = new CallService();
            try
            {
                _Response = _Serice.GetEmpleados();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error " + ex.Message);
            }
            return Json(new { data = _Response.ResponseData });
        }        
        [HttpPost]
        public JsonResult DeleteEmployeByCode(int Id)
        {
            ServiceResponse<string> _Response = new ServiceResponse<string>();
            CallService _Serice = new CallService();
            try
            {
                _Response = _Serice.DeleteEmployerById(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error " + ex.Message);
            }
            return Json(_Response);
        }
        [HttpPost]
        public JsonResult FiltroBusquedaEmpleados(int IdCompania, int IdLocalidad)
        {
            ServiceResponse<string> _Response = new ServiceResponse<string>();
            CallService _Serice = new CallService();
            try
            {
                _Response = _Serice.FiltroBusquedaEmpleados(IdCompania,IdLocalidad);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error " + ex.Message);
            }
            return Json(_Response);
        }
        [HttpPost]
        public JsonResult GetDataSelect()
        {
            ServiceResponse<List<dto_ComboGral>> _Response = new ServiceResponse<List<dto_ComboGral>>();
            CallService _Serice = new CallService();
            try
            {
                _Response = _Serice.GetSelectGral(UrlEndPoint);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error " + ex.Message);
            }
            return Json(new { data = _Response.ResponseData });
        }
        [HttpPost]
        public JsonResult AgregarEmpleado(string Name)
        {

            ServiceResponse<string> _Response = new ServiceResponse<string>();
            CallService _Serice = new CallService();
            try
            {
                _Response = _Serice.AgregarEmpleado(Name);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error " + ex.Message);
            }
            return Json(_Response);

        }

    }
}
