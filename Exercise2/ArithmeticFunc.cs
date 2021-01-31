using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    delegate double Operation(double operand1, double operand2);
    class ArithmeticFunc
    {
        // Я бы всё таки вынес не в свойство AllOPeration, а в метод, который возвращает делегат операции. 
        public static Dictionary<char, Operation> AllOperations
        {
            get
            {
                return new Dictionary<char, Operation>()
                {
                    { '+', (double o1, double o2) => o1 + o2 },
                    { '-', (double o1, double o2) => o1 - o2 },
                    { '*', (double o1, double o2) => o1 * o2 },
                    // Интересно что ошибки не будет при делении на ноль :)
                    // https://docs.microsoft.com/ru-ru/dotnet/api/system.double.nan?view=net-5.0
                    { '/', (double o1, double o2) => { return o2 != 0 ? o1 / o2 : throw new DivideByZeroException(); } }
                };
            }
        }
    }
}
