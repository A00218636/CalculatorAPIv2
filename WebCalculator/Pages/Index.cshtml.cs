using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedCalculator;

namespace WebCalculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost([FromForm]double OperandFirst, [FromForm]double OperandSecond, [FromForm] string operation)
        {
            switch(operation)

            {
                case "Addition":
                    ViewData["result"] = SharedCalculator.Calculator.Add(OperandFirst, OperandSecond);
                    break;

                case "Subtraction":
                    ViewData["result"] = SharedCalculator.Calculator.Subtract(OperandFirst, OperandSecond);
                    break;

                case "Division":
                    ViewData["result"] = SharedCalculator.Calculator.Divide(OperandFirst, OperandSecond);
                    break;

                case "Multiplication":
                    ViewData["result"] = SharedCalculator.Calculator.Multiply(OperandFirst, OperandSecond);
                    break;
            }

           
        }
    }

}
