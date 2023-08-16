using ExcAula16.CommandResult;
using ExcAula16.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection.Metadata;

namespace ExcAula16.Handlers
{
    public class CalculatorHandler
    {
        public IActionResult Calculation(Parameters parameter)
        {
            //Parameters Validation;
            
            try
            {
                double calculo;

                if (parameter.Operation == Enums.OperationType.Addtion)
                {
                    calculo = parameter.Value1 + parameter.Value2;
                    return new OkObjectResult(calculo);
                }
                else if (parameter.Operation == Enums.OperationType.Subtraction)
                {
                    calculo = parameter.Value1 - parameter.Value2;
                    return new OkObjectResult(calculo);
                }
                else if (parameter.Operation == Enums.OperationType.Multiplication)
                {
                    calculo = parameter.Value1 * parameter.Value2;
                    return new OkObjectResult(calculo);
                }
                else if(parameter.Operation == Enums.OperationType.Division)
                {
                    if (parameter.Value2 == 0) {
                        throw new DivideByZeroException(); }

                    calculo = parameter.Value1 / parameter.Value2;
                    return new OkObjectResult(calculo);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch(OverflowException)
            {
                return new ObjectResult("Ops você passou do limite") { StatusCode = 500 };
            }
            catch(DivideByZeroException)
            {
                return new DivideByZeroResult("Divisão Por Zero");
            }
            catch (ArithmeticException)
            {
                return new ObjectResult("Erro de calculo divisão por zero detectada!!") { StatusCode = 500 };
            }
            catch (ArgumentException)
            {
                return new ObjectResult("Operação não encontrada") { StatusCode = 500};
            }
            catch (Exception)
            {
                return new ObjectResult("Opa um calculo não correu bem!!") { StatusCode = 500 };
            }
           
        }
    }
}
