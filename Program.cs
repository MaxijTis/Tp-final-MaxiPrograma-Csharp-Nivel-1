using System;

namespace TPFinal_Tis
{
    class Program
    {
        static void Main(string[] args)
        {
        //Hacer un programa que permita ingresar una lista de números que corta 
        //cuando se ingresa un cero. A partir de dichos datos informar:

        // a. El mayor de los números pares.
        // b. La cantidad de números impares.
        // c. El menor de los números primos.

        // Nota: evaluar el uso de una función que analice 
        //si un número dado es primo o no y que devuelva true o false según corresponda.
        
            int num1, mayorPar = 0;
            int cantidadImpar = 0, menorPrimo = 0;
            int bandera = 0;

            Console.WriteLine("Por favor ingresa el primer numero ");
            num1 = int.Parse(Console.ReadLine());
            
            while (num1 != 0)
            {
                if(num1 % 2 == 0)
                {
                   if (mayorPar == 0)
                   {
                    mayorPar = num1;
                   }
                   else if(mayorPar < num1)
                   {
                   mayorPar = num1; 
                   }
                }else{
                    cantidadImpar++;
                }

                
                if(bandera == 0)
                {
                        menorPrimo = num1;
                        bandera = 1;
                }else 
                    menorPrimo = num1;
                    
                    
                    
                Console.WriteLine("Ingrese otro numero ");
                num1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El Mayor numero par fue: " + mayorPar);
            Console.WriteLine("La cantidad de numeros impares fue: " + cantidadImpar);
            Console.WriteLine("El menor numero primo fue: " + menorPrimo);
        }

       


            static bool primo(int a)
            {
                int contador = 0;
                int aux = 1;
            
                while(aux <= a)
                {
                    if(a % aux == 0)
                    {
                    contador++;
                    }
                    aux++;
                }
                    if(contador == 2)
                    {
                        return true;
                    }else{
                        return false;
                    }
            } 

    }                     
}       
