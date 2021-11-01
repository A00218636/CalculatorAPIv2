using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedCalculator;

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // Calculator sc = new Calculator();

        [HttpGet]
        [Route("api/Calculator/add/{left}/{right}")]
        public double GetAddResult(double left, double right)
        {
            return Calculator.Add(left, right);

        }

        [HttpGet]
        [Route("api/Calculator/Sub/{left}/{right}")]
        public double GetSubResult(double left, double right)
        {
            return Calculator.Subtract(left, right);
        }

        [HttpGet]
        [Route("api/Calculator/Div/{left}/{right}")]
        public double GetDivResult(double left, double right)
        {
            return Calculator.Divide(left, right);
        }

        [HttpGet]
        [Route("api/Calculator/Mul/{left}/{right}")]
        public double GetMulResult(double left, double right)
        {
            return Calculator.Multiply(left, right);
        }
    }
}
