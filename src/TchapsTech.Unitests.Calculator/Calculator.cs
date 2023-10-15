﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TchapsTech.Unitests.Calculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            var result = x + y;
            return result;
        }

        public int Substract(int x, int y)
        {
            var result = x - y;
            return result;
        }

        public CalculatorResponse Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return new CalculatorResponse
                {
                    IsSuccess = false,
                    Error = "DivideByZero"
                };
            }
            var result = dividend / divisor;

            return new CalculatorResponse
            {
                IsSuccess = true,
                Result = result.ToString()
            };
        }

        public decimal DivideWithException(decimal x, 
            decimal y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            var result = x / y;

            return result;
        }


    }
}
