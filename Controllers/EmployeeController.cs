using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Model;
using PrimeiraApi.ViewModel;

namespace PrimeiraApi.Controllers;


    [ApiController]
[Route("api/v1/employee")]

public class EmployeeController : ControllerBase
  {
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
    }

    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeView)
    {
        var employee = new Employee (  employeeView.Name, employeeView.Age, null);

        _employeeRepository.Add(employee);

        return Ok();
    }
    [HttpGet]
    public IActionResult Get()
    {
        var employee = _employeeRepository.Get();
        return Ok(employee);
    }
  }


