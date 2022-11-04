namespace TPFinal_Pucheta;
class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.A partir de dichos datos informar:

            //a.El mayor de los números pares.
            //b.La cantidad de números impares.
            //c.El menor de los números primos.

        //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int num, num_par;
            int mayor_par = 0;
            int contPar = 0;
            int cantImpares = 0;
            int contador = 1;
            int contador_primos = 0;
            int menor_primo = 0;
            int numero_primo = 0;
            int cont_primos = 0;

            Console.WriteLine("Ingresar un numero: ");
            num = int.Parse(Console.ReadLine());            
        

            while (num != 0)
            {
                bool booleano = primo(num);
                Console.WriteLine(booleano);
                
                if (num % 2 == 0)
                {
                    num_par = num;
                    contPar = contPar + 1;

                    if (contPar == 1)
                    {
                        mayor_par = num;
                    }
                    else if (num_par > mayor_par)
                    {
                        mayor_par = num_par;
                    }
                }
                else
                {
                    cantImpares++;
                }

                while (contador <= num)
                {
                    if (num % contador == 0)
                    {
                        contador_primos++;
                    }
                    contador++;
                }

                if (contador_primos == 2)
                {
                    numero_primo = num;
                    cont_primos++;

                    if (cont_primos == 1)
                    {
                        menor_primo = num;
                    }
                    else if (numero_primo < menor_primo)
                    {
                        menor_primo = numero_primo;
                    }
                }                
                
                contador_primos = 0;
                contador = 1;

                Console.WriteLine("Ingresar un numero: ");
                num = int.Parse(Console.ReadLine());
            }

        Console.WriteLine("El mayor par es: " + mayor_par);
        Console.WriteLine("La cantidad numeros impares son: " + cantImpares);   
        Console.WriteLine("El menor primo es: " + menor_primo);

    }

    static bool primo(int numero)
        {
            int contador = 1;
            int contar_primos = 0;

            while (contador <= numero)
            {
                if (numero % contador == 0)
                {
                    contar_primos++;
                }
                contador++;
            }
            if (contar_primos == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
}
