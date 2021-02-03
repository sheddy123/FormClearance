using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FormClearance.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormClearance.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormClearanceController : ControllerBase
    {
        private IFormClearanceRepository _fcRepo;
        private readonly IMapper _mapper;
        public FormClearanceController(IFormClearanceRepository fcRepo, IMapper mapper)
        {
            _fcRepo = fcRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllForms(string userType)
        {
            var objList = _fcRepo.GetForms(userType);
            return Ok(objList);
        }

       

        #region End point to get form archives
        /// <summary>
        /// End point to get form archives
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpGet("Archives")]
        public IActionResult Archives(string userType)
        {
            var objList = _fcRepo.GetArchive(userType);
            return Ok(objList);
        }
        #endregion

        #region End point to get form archives
        /// <summary>
        /// End point to get form archives
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpGet("DeleteResponse/{Id}")]
        public IActionResult DeleteResponse(int Id)
        {
            var createForm = _fcRepo.GetForms(Id);
            var objList = _fcRepo.DeleteForm(createForm);
            return Ok(objList);
        }
        #endregion

        #region End point to get form archives
        /// <summary>
        /// End point to get form archives
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpGet("AdminResponse/{userType}")]
        public IActionResult AdminResponse(string userType)
        {
            var objList = _fcRepo.GetArchive(userType);
            return Ok(objList);
        }
        #endregion

        #region End point to create a new form
        /// <summary>
        /// End point to create a new form
        /// </summary>
        /// <param name="formClearance"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpPost("CreateForm")]
        public IActionResult CreateForm(FormClearance.Models.FormClearance formClearance)
        {
            var createForm = _fcRepo.CreateForm(formClearance);
            return Ok(createForm);
        }
        #endregion

        #region End point to get form details
        /// <summary>
        /// End point to get form details
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpGet("ProcessForm/{Id}")]
        public IActionResult ProcessForm(int Id)
        {
            var createForm = _fcRepo.GetForms(Id);
            if (createForm != null)
            {
                return StatusCode(200, createForm);
            }
            return StatusCode(500, "Error processing request");
        }
        #endregion

        #region End point to get form details
        /// <summary>
        /// End point to get form details
        /// </summary>
        /// <param name="formClearance"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpPost("UpdateForm")]
        public IActionResult UpdateForm(FormClearance.Models.FormClearance formClearance)
        {
            var updateForm = _fcRepo.UpdateForm(formClearance);
            if (updateForm != false)
            {
                return StatusCode(200, updateForm);
            }
            return StatusCode(500, "Error processing request");
        }
        #endregion
    }
}