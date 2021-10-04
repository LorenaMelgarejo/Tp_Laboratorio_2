using System;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            string operadores;
            operadores = ValidarOperador(operador);

            switch (operadores)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        private static char ValidarOperador(char operador)
        {
            while (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;

            }
            return '+';
        }
    }
}
