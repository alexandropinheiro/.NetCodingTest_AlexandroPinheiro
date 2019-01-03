using AutoMapper;
using Dominio;
using Dominio.Employees;
using Microsoft.AspNetCore.Mvc;
using Api.ViewModels;
using System;
using System.Linq;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;


        public EmployeeController(IEmployeeRepository employeeRepository,
                               IUnitOfWork uow,
                               IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _uow = uow;
            _mapper = mapper;
        }

        // GET api/employee
        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                return Ok(_employeeRepository.ObterTodos());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/employee
        [HttpPost]
        public IActionResult Gravar([FromBody]EmployeeViewModel employeeViewModel)
        {
            try
            {
                var employee = _mapper.Map<Employee>(employeeViewModel);

                _employeeRepository.Gravar(employee);
                _uow.Commit();

                var employeeSaved = _employeeRepository.Obter(e => e.Name == employee.Name
                                                                && e.Email == employee.Email
                                                                && e.Department == employee.Department).FirstOrDefault();

                return Ok(employeeSaved);

            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/employee/{id}
        [HttpPut("{id:int}")]
        public IActionResult Atualizar(int id, [FromBody]EmployeeViewModel employeeViewModel)
        {
            try
            {
                var employee = _employeeRepository.ObterPorId(id);

                if (employee == null)
                    return BadRequest("Employee not found!");

                employee.Name = employeeViewModel.Name;
                employee.Email = employeeViewModel.Email;
                employee.Department = employeeViewModel.Department;

                _employeeRepository.Atualizar(employee);
                _uow.Commit();

                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/employee/{id}
        [HttpDelete("{id:int}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                var employee = _employeeRepository.ObterPorId(id);

                if (employee == null)
                    return BadRequest("Employee not found!");

                _employeeRepository.Excluir(employee);
                _uow.Commit();

                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}