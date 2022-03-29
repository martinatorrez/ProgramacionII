using System;

namespace LogicaNegocios
{
    public class Calculadora
    {
        public static float Calcular(float primerOperando, float segundoOperando, char operacion) 
        {
            float resultado = 0;
            switch(operacion)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Validar(segundoOperando)) 
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else 
                    {
                        Console.WriteLine("No es posible dividir por 0");
                    }
                   
                    break;
            
            }
            return resultado;
        }

        private static bool Validar(float segundoOperando) 
        {
            bool retornar = false;
            if (segundoOperando != 0) 
            {
                retornar = true;
            }
            return retornar;
        }
    }
}
/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/