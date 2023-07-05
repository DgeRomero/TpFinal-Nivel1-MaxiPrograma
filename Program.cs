using System;

namespace TPFinal_Romero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números 
            //que corta cuando se ingresa un cero. A partir de dichos datos informar:
            //    a. El mayor de los números pares.
            //    b. La cantidad de números impares.
            //    c. El menor de los números primos.
            //Nota: evaluar el uso de una función que analice si un número dado es primo o no 
            //y que devuelva true o false según corresponda.

            int n, maxPar = 0, cantImpares = 0, minPrimo = 0;
            bool bPar = false, bPrimo = false;

            Console.WriteLine("Ingrese numero: ");
            n = int.Parse(Console.ReadLine());

            while ( n != 0){
                //DISCRIMINAR PAR DE IMPAR Y BUSCAR MAXIMO PAR
                if (par(n)){
                    if(!bPar){
                        maxPar = n;
                        bPar = true;
                    }else if( n > maxPar){
                        maxPar = n;
                    }
                //CONTAR IMPARES
                }else{
                    cantImpares++;
                }
                //BUSCAR PRIMO MENOR
                if(primo(n)){
                    if(!bPrimo){
                        minPrimo = n;
                        bPrimo = true;
                    }else if( n < minPrimo){
                        minPrimo = n;
                    }
                }
                
                Console.WriteLine("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());
            }
            //INFORMAR MAXIMO PAR
            if(bPar){
                Console.WriteLine("El maximo numero PAR ingresado fue: "+maxPar);
            }else{
                Console.WriteLine("No se ingresaron numeros pares.");
            }
            //INFORMAR CANTIDAD DE IMPARES
            if(cantImpares == 0){
                Console.WriteLine("No se ingresaron numeros IMPARES.");
            }else{
                Console.WriteLine("La cantidad de numeros IMPARES es: "+cantImpares);
            }
            //INFORMAR MENOR PRIMO
            if(bPrimo){
                Console.WriteLine("El menor numero primo es: "+minPrimo);
            }else{
                Console.WriteLine("No se ingresaron numeros primos.");
            }

        }

        //FUNCIONES
        
        static bool par(int n){
            if ( n % 2 == 0){
                return true;
            }else{
                return false;
            }
        }

        static bool primo(int n){
            int cont = 0;
            for(int i = 1; i <= n; i++){               
                    if (n % i == 0){
                        cont++;
                    }                
            }
            if (cont == 2){
                return true;
            }else{
                return false;
            }
        }
    }
}
