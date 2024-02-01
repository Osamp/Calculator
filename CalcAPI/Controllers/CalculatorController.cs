using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]

public class CalculatorController : ControllerBase
{
        [HttpGet]
    public IActionResult Divide(decimal numerator, decimal denominator)
    {
        if(denominator == 0)
        {
            // Console.WriteLine("Error: Division by zero");
            return BadRequest("Error: Division by zero");
        }
        else
        {   decimal result= numerator / denominator;
            return Ok(result);
        }
    }

    [HttpGet]

    public IActionResult Multiply(decimal numerator, decimal denominator)
    {       
        decimal result= numerator*denominator;
        return Ok(result);
    }


    [HttpGet]

    public IActionResult Add(decimal numerator, decimal denominator)
    {       
        decimal result= numerator+denominator;
        return Ok(result);
    }
    

    [HttpGet]


 public IActionResult Subtract(decimal numerator, decimal denominator)
    {       
        decimal result= numerator-denominator;
        return Ok(result);
    }
   


    [HttpGet]

    public IActionResult Modulus(decimal numerator, decimal denominator)
    {
        if(denominator == 0)
        {
            return BadRequest("Error: Division by zero");
        }
        else
        {
            decimal result=numerator%denominator;
            return Ok(result);
            
        }
    }
}

   
