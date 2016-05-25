using System;

namespace Cajero
{
    class Program
    {
        static int deposito = 0;
        static int retiro = 0;
        static int saldo = 0;
        static int monedas = 0;
        static int option = 0;
        static int Billetes20 = 0;
        static int Billetes10 = 0;
        static int Billetes5 = 0;
        static int Billetes2 = 0;
        static double compra = 0;
        static double venta = 0;
        

        static char conf;
        static char dec;

        static int Monedas500 = 0;
        static int Monedas100 = 0;
        static int Monedas50 = 0;
        static int Monedas25 = 0;
        static int Monedas10 = 0;
        static int Monedas5 = 0;

        static int Residuo = 0;
        static int Resultado = 0;

        static void depositar_dinero()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("--------Deposito Bancario--------");
                Console.WriteLine("Cuanto desea depositar?");
                deposito = int.Parse(Console.ReadLine());
                saldo = saldo + deposito;
                Console.WriteLine("El total depositado fue: " + deposito);
                Console.WriteLine("El saldo de la cuenta es: " + saldo);
                //Console.ReadKey();
                Console.WriteLine("Desea realizar otro deposito??(s para continuar)");
                conf = char.Parse(Console.ReadLine());

            } while (conf == 's');

        }
      

        static void retirar_dinero()
        {
            if (saldo <= 0)
            { Console.WriteLine("Digite una tecla para continuar"); }
            else
            {
                Console.WriteLine("Fondos insuficientes, Digite otro monto: ");
                retiro = int.Parse(Console.ReadLine());
                if (retiro > saldo && saldo != 0)
                {
                    retirar_dinero();
                }
                else
                {
                    Console.WriteLine("Puede retirar su dinero");
                    saldo = saldo - retiro;

                    Billetes20 = retiro / 20000;
                    Residuo = retiro % 20000;

                    Billetes10 = Residuo / 10000;
                    Residuo = Residuo % 10000;

                    Billetes5 = Residuo / 5000;
                    Residuo = Residuo % 5000;

                    Billetes2 = Residuo / 2000;
                    Residuo = Residuo % 2000;

                    Resultado = Billetes20 + Billetes10 + Billetes5 + Billetes2;

                    Console.WriteLine("Dinero Solicitado    : {0}", retiro);
                    Console.WriteLine("Billetes de 20 000   : {0}", Billetes20);
                    Console.WriteLine("Billetes de 10 000   : {0}", Billetes10);
                    Console.WriteLine("Billetes de  5 000   : {0}", Billetes5);
                    Console.WriteLine("Billetes de  2 000   : {0}", Billetes2);

                    Console.WriteLine("La cantidad Mimima de Billetes es: " + Resultado);
        

                    Console.WriteLine("Su saldo es de :" + saldo);

                }
            }
        }


        static void recibir_monedas()
        {
            Console.Clear();
            Console.WriteLine("Cuanto desea depositar? ");
            monedas = int.Parse(Console.ReadLine());
            
            Monedas500  = monedas / 500;
            Residuo = monedas % 500;

            Monedas100 = Residuo / 100;
            Residuo = Residuo % 100;

            Monedas50 = Residuo / 50;
            Residuo = Residuo % 50;

            Monedas25 = Residuo / 25;
            Residuo = Residuo % 25;

            Monedas10 = Residuo / 10;
            Residuo = Residuo % 10;

            Monedas5 = Residuo / 5;
            Residuo = Residuo % 5;

            //Cantifad minima de monedas
            Resultado = Monedas500 + Monedas100 + Monedas50 + Monedas25 + Monedas10 + Monedas5;
            saldo = saldo + monedas;

            Console.WriteLine("Monedas de 500       : {0}", Monedas500);
            Console.WriteLine("Monedas de 100       : {0}", Monedas100);
            Console.WriteLine("Monedas de  50       : {0}", Monedas50);
            Console.WriteLine("Monedas de  25       : {0}", Monedas25);
            Console.WriteLine("Monedas de  10       : {0}", Monedas10);
            Console.WriteLine("Monedas de   5       : {0}", Monedas5);
            Console.WriteLine("La cantidad Mimima de monedas es:{0}", Resultado);
            Console.WriteLine("El saldo actual de su cuenta es:{0}", saldo);
            Console.ReadKey();
            
        }

        static void indicar_tipodecambio() {
            DateTime thisDay = DateTime.Today;

            Console.Clear();
            Console.WriteLine("Calculo de Tipo de Cambio ");
            Console.WriteLine("Compra: ¢534 // Venta: ¢546  ");
            Console.WriteLine("Digite C si desea comprar, V si desea vender:  ");
            dec = char.Parse(Console.ReadLine());
            if (dec == 'c')
            {
                Console.WriteLine("Digite el monto a comprar: ");
                compra = double.Parse(Console.ReadLine());

                compra = compra * 534;

                Console.WriteLine("El total en colones seria:  " + compra);

                Console.WriteLine("La fecha de hoy es: " + thisDay.ToString("D"));

            }
            else {

                Console.WriteLine("Calculo el monto a vender  ");
                venta = double.Parse(Console.ReadLine());

                venta = venta / 546;

                Console.WriteLine("El total en dolares son: " + venta);

                Console.WriteLine("La fecha de hoy es: "+ thisDay.ToString("D"));
            }
            Console.ReadKey();

        }

        static int Main() //void
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos al cajero Banco Estado");
                Console.WriteLine("1. Deposito de Dinero");
                Console.WriteLine("2. Retiro de Dinero");
                Console.WriteLine("3. Recibo de Monedas");
                Console.WriteLine("4. Consulta del Tipo de Cambio");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        //Salir
                        break;
                    case 1:
                        {
                            depositar_dinero();


                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Saldo actual: " + saldo);
                            if (saldo <= 0)
                            { Console.WriteLine("Lo siento, no puede realizar ningun retiro"); }

                            else if (saldo > 0)
                            {
                                Console.WriteLine("Cuanto desea Retirar");
                                retiro = int.Parse(Console.ReadLine());
                            }
                            if (retiro > saldo)
                            {
                                retirar_dinero();
                            }
                            else if (retiro <= saldo && saldo != 0)
                            {
                                Console.WriteLine("Puede retirar su dinero");
                                saldo = saldo - retiro;

                                Billetes20 = retiro / 20000;
                                Residuo = retiro % 20000;

                                Billetes10 = Residuo / 10000;
                                Residuo = Residuo % 10000;

                                Billetes5 = Residuo / 5000;
                                Residuo = Residuo % 5000;

                                Billetes2 = Residuo / 2000;
                                Residuo = Residuo % 2000;

                                Resultado = Billetes20 + Billetes10 + Billetes5 + Billetes2;

                                Console.WriteLine("Dinero Solicitado    : {0}", retiro);
                                Console.WriteLine("Billetes de 20 000   : {0}", Billetes20);
                                Console.WriteLine("Billetes de 10 000   : {0}", Billetes10);
                                Console.WriteLine("Billetes de  5 000   : {0}", Billetes5);
                                Console.WriteLine("Billetes de  2 000   : {0}", Billetes2);

                                Console.WriteLine("La cantidad Mimima de Billetes es: " + Resultado);

                                Console.WriteLine("Su saldo es de :" + saldo);
                            }

                            Console.ReadKey();

                            break;
                        }

                    case 3:
                       
                        {
                            recibir_monedas();
                            break;

                        }

                    case 4:
                        {
                            indicar_tipodecambio();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida..");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (option != 0);
            return 0;
        }
    }
}
