namespace CalculatorLibrary;

//[Route("[controller]/[action]")]
   // [ApiController]
    public class Calculator //: ControllerBase
    {
       // [Route("{op1}/{op2}")]
        //[HttpGet]
        public string Add(decimal op1, decimal op2)
        {
            decimal op3 = op1 + op2;
            return string.Concat(op1.ToString()," + ",op2.ToString()," = ",op3.ToString());
        }

        //[Route("{op1}/{op2}")]
       // [HttpGet]
        public string Subtract(decimal op1, decimal op2)
        {
            decimal op3 = op1 - op2;
            return string.Concat(op1.ToString()," - ",op2.ToString()," = ",op3.ToString());
        }

        //[Route("{op1}/{op2}")]
        //[HttpGet]
        public string Multiply(decimal op1, decimal op2)
        {
            decimal op3 = op1 * op2;
            return string.Concat(op1.ToString()," X ",op2.ToString()," = ",op3.ToString());
        }

        //[Route("{numerator}/{denominator}")]
        //[HttpGet]
        public string Divide(decimal numerator , decimal denominator)
        {
            if(denominator == 0)
            {
                return string.Concat(numerator.ToString()," can not divide by ",denominator.ToString()+".")  ;  
            }
            else{
                decimal quotient = numerator / denominator;
                return string.Concat(numerator.ToString()," / ",denominator.ToString()," = ",quotient.ToString());
            }
        }

        //[Route("{numerator}/{denominator}")]
        //[HttpGet]
        public string Modulo(decimal numerator , decimal denominator)
        {
            if(denominator == 0)
            {
                return string.Concat("Can not calculate remainder as ",numerator.ToString()," can not be divided by ",denominator.ToString()+".")  ;  
            }
            else{
                decimal remainder = numerator % denominator;
                return string.Concat(numerator.ToString()," % ",denominator.ToString()," = ",remainder.ToString());
            }
        }

    }
