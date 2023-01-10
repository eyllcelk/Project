using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TariffSelectionApi.Interfaces;
using TariffSelectionApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TariffSelectionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariffProviderController : ControllerBase
    {
        private readonly ITariffProvider _tariffProvider;
        public TariffProviderController(ITariffProvider tariffProvider)
        {
            _tariffProvider = tariffProvider;
        }


        /// <summary>
        /// Get all tariff provider from json file
        /// </summary>
        //GET: api/<TariffProviderController>
        [Route("Get")]
        [HttpGet, ActionName("GetAllTarifProviders")]
        public ActionResult<List<BaseProduct>> GetAllTarifProviders()
        {
            return Ok(_tariffProvider.GetListOfTariffProviders());

        }

        /// <summary>
        /// Get all tariff provider with calculation of CostOfYear
        /// </summary>
        //GET: api/<TariffProviderController>
        [Route("GetAllTarifProvidersWithCons")]
        [HttpGet, ActionName("GetAllTarifProvidersWithCons")]
        public ActionResult<List<BaseProduct>> GetAllTarifProvidersWithCons(int cons)
        {
            if (cons == 0)
            {
                return BadRequest();
            }
            return Ok(_tariffProvider.GetListOfTariffProvidersWithCons(cons));
        }

    }
}
