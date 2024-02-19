// See https://aka.ms/new-console-template for more information



using System;
using System.Drawing;

class Program

    //Se definen todas las variable a utilizar en el programa 
{
    static int[] numeroPago = new int[10];
    static DateTime[] fechaHora = new DateTime[10];//se coloca un 
    static int[] cedula = new int[10];
    static string[] nombre = new string[10];
    static string[] apellido1 = new string[10];
    static string[] apellido2 = new string[10];
    static int[] numeroCaja = new int[10];
    static int[] tipoServicio = new int[10];
    static int[] numeroFactura = new int[10];
    static double[] montoPagar = new double[10];
    static double[] montoComisionado = new double[10];
    static double[] montoDeducido = new double[10];
    static double[] montoPagaCliente = new double[10];
    static double[] vuelto = new double[10];

    static int cantidadPagos = 0;



    //se declara la clase MAIN
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;

        Console.Clear();

        int opcion;
        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan ; // Cambiar el color del texto del Menu principal
            Console.WriteLine("*********************************************************");
            Console.WriteLine( "              All-in-One Market. S.A");
            Console.WriteLine("         Sistema de Pagos de Servicios OnLine");
            Console.WriteLine("*********************************************************");
            Console.ForegroundColor = ConsoleColor.Red; // Cambiar el color del texto del Menu principal
            Console.WriteLine("Menú Principal");
            Console.ForegroundColor = ConsoleColor.Green; // Cambiar el color del texto del Menu principal
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Inicializar Vectores");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("2. Realizar Pagos");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("3. Consultar Pagos");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("4. Modificar Pagos");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("5. Eliminar Pagos");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("6. Submenú Reportes");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("7. Salir");
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ingrese la opcion deseada: ");
            opcion = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White; // Cambiar el color del texto a blanco para ver las respuestas de la consulta



            // Se llaman los metodos configurados al menu principal
            switch (opcion)
            {
                
                case 1:
                    InicializarVectores();
                    break;
                case 2:
                    RealizarPagos();
                    break;
                case 3:
                    ConsultarPagos();
                    break;
                case 4:
                    ModificarPagos();
                    break;
                case 5:
                    EliminarPagos();
                    break;
                case 6:
                    SubmenuReportes();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("¡Gracias por utilizar nuestro App de pagos Online!");
                    Console.WriteLine("*********************************************************");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                    break;
            }
        } while (opcion != 7);
    }


    // Configuracion del Metodo Inicializar Vectores 
    //Al ejecutarlo colaca los valores en 0 de las variables 
    static void InicializarVectores()
    {
        for (int i = 0; i < 10; i++)
        {
            numeroPago[i] = 0;
            fechaHora[i] = DateTime.MinValue;
            cedula[i] = 0;
            nombre[i] = "";
            apellido1[i] = "";
            apellido2[i] = "";
            numeroCaja[i] = 0;
            tipoServicio[i] = 0;
            numeroFactura[i] = 0;
            montoPagar[i] = 0.0;
            montoComisionado[i] = 0.0;
            montoDeducido[i] = 0.0;
            montoPagaCliente[i] = 0.0;
            vuelto[i] = 0.0;
        }
        cantidadPagos = 0;
        Console.WriteLine("Vectores inicializados correctamente.");
    }

    // Programacion del Metodo Realizar Pagos

    static void RealizarPagos()
    {
        if (cantidadPagos >= 10) //se compruba que los vectores no esten llenos

        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Vector Lleno, por favor ejecute la Opcion (1) del menú principal para liberar los vectores ");
            Console.WriteLine("*********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        Console.WriteLine("Ingrese los datos del pago:");

        // Incremento automatico del numero de pago (comienza en 1 hacia arriba)

        numeroPago[cantidadPagos] = cantidadPagos + 1; 

        fechaHora[cantidadPagos] = DateTime.Now;
       
        Console.Write("Cédula: ");
        cedula[cantidadPagos] = int.Parse(Console.ReadLine());
       
        Console.Write("Nombre: ");
        nombre[cantidadPagos] = Console.ReadLine();
       
        Console.Write("Apellido1: ");
        apellido1[cantidadPagos] = Console.ReadLine();
       
        Console.Write("Apellido2: ");
        apellido2[cantidadPagos] = Console.ReadLine();

        // Se realiza el Random de 1 a 3 entre las cajas 
        numeroCaja[cantidadPagos] = new Random().Next(1, 4); 
       
        Console.Write("Tipo de Servicio (1= Recibo de Luz, 2= Recibo de Teléfono, 3= Recibo de Agua): ");
        tipoServicio[cantidadPagos] = int.Parse(Console.ReadLine());
       
        Console.Write("Número de Factura: ");
        numeroFactura[cantidadPagos] = int.Parse(Console.ReadLine());
       
        Console.Write("Monto a Pagar:¢ ");
        montoPagar[cantidadPagos] = double.Parse(Console.ReadLine());


        // Cálculo de comisión y el monto deducido

        switch (tipoServicio[cantidadPagos])
        {
            case 1:
                montoComisionado[cantidadPagos] = montoPagar[cantidadPagos] * 0.04;
                break;
            case 2:
                montoComisionado[cantidadPagos] = montoPagar[cantidadPagos] * 0.055;
                break;
            case 3:
                montoComisionado[cantidadPagos] = montoPagar[cantidadPagos] * 0.065;
                break;
        }
        montoDeducido[cantidadPagos] = montoPagar[cantidadPagos] - montoComisionado[cantidadPagos];

        Console.Write("Monto Paga Cliente:¢ ");
        montoPagaCliente[cantidadPagos] = double.Parse(Console.ReadLine());

        //comprobacion del monto correcto a pagar por parte del cliente

        if (montoPagaCliente[cantidadPagos] < montoPagar[cantidadPagos])
        {
            Console.WriteLine("El monto pagado es menor que el monto a pagar. Por favor, revise.");
            return;
        }

        vuelto[cantidadPagos] = montoPagaCliente[cantidadPagos] - montoPagar[cantidadPagos];
        cantidadPagos++;
    }

    // Programacion del Metodo consultar pago
    static void ConsultarPagos()
    {
        // Se solicita que el usuario digite el numero de pago que desea consultar 

        Console.Write("Ingrese el número de pago que desea consultar: ");
        int numero = int.Parse(Console.ReadLine());
        int indice = Array.IndexOf(numeroPago, numero);
        if (indice != -1)
        {
            Console.WriteLine("Datos del pago:");
            Console.WriteLine($"Fecha/Hora: {fechaHora[indice]}");
            Console.WriteLine($"Cédula: {cedula[indice]}");
            Console.WriteLine($"Nombre: {nombre[indice]}");
            Console.WriteLine($"Apellido1: {apellido1[indice]}");
            Console.WriteLine($"Apellido2: {apellido2[indice]}");
            Console.WriteLine($"Número de Caja: {numeroCaja[indice]}");
            Console.WriteLine($"Tipo de Servicio: {tipoServicio[indice]}");
            Console.WriteLine($"Número de Factura: {numeroFactura[indice]}");
            Console.WriteLine($"Monto a Pagar: {montoPagar[indice]}");
            Console.WriteLine($"Monto Comisionado: {montoComisionado[indice]}");
            Console.WriteLine($"Monto Deducido: {montoDeducido[indice]}");
            Console.WriteLine($"Monto Paga Cliente: {montoPagaCliente[indice]}");
            Console.WriteLine($"Vuelto: {vuelto[indice]}");
        }
        else
        {
            Console.WriteLine("Pago no se encuentra Registrado");
        }
    }


    // Programacion del Metodo Modificar Pagos 

    static void ModificarPagos()
    {


        // Se solicita que el usuario digite el numero de pago que desea consultar

        Console.Write("Ingrese el número de pago que desea modificar: ");
        int numero = int.Parse(Console.ReadLine());
        int indice = Array.IndexOf(numeroPago, numero);
        if (indice != -1)
        {
            //Menu de datos de a modificar 

            Console.WriteLine("Datos del pago:");
            Console.WriteLine($"1. Fecha/Hora: {fechaHora[indice]}");
            Console.WriteLine($"2. Cédula: {cedula[indice]}");
            Console.WriteLine($"3. Nombre: {nombre[indice]}");
            Console.WriteLine($"4. Apellido1: {apellido1[indice]}");
            Console.WriteLine($"5. Apellido2: {apellido2[indice]}");
            Console.WriteLine($"6. Número de Caja: {numeroCaja[indice]}");
            Console.WriteLine($"7. Tipo de Servicio: {tipoServicio[indice]}");
            Console.WriteLine($"8. Número de Factura: {numeroFactura[indice]}");
            Console.WriteLine($"9. Monto a Pagar: {montoPagar[indice]}");
            Console.WriteLine($"10. Monto Paga Cliente: {montoPagaCliente[indice]}");

            Console.Write("Ingrese el número del dato que desea modificar: ");
            int opcion = int.Parse(Console.ReadLine());

            //Cada Case modifica y guarada el dato que se selecciones segun la opcion del menu

            switch (opcion)
            {
                case 1:
                    Console.Write("Nueva Fecha/Hora: ");
                    fechaHora[indice] = DateTime.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Nueva Cédula: ");
                    cedula[indice] = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Nuevo Nombre: ");
                    nombre[indice] = Console.ReadLine();
                    break;
                case 4:
                    Console.Write("Nuevo Apellido1: ");
                    apellido1[indice] = Console.ReadLine();
                    break;
                case 5:
                    Console.Write("Nuevo Apellido2: ");
                    apellido2[indice] = Console.ReadLine();
                    break;
                case 6:
                    Console.Write("Nuevo Número de Caja: ");
                    numeroCaja[indice] = int.Parse(Console.ReadLine());
                    break;
                case 7:
                    Console.Write("Nuevo Tipo de Servicio (1= Recibo de Luz, 2= Recibo de Teléfono, 3= Recibo de Agua): ");
                    tipoServicio[indice] = int.Parse(Console.ReadLine());
                    break;
                case 8:
                    Console.Write("Nuevo Número de Factura: ");
                    numeroFactura[indice] = int.Parse(Console.ReadLine());
                    break;
                case 9:
                    Console.Write("Nuevo Monto a Pagar:¢ ");
                    montoPagar[indice] = double.Parse(Console.ReadLine());
                    break;
                case 10:
                    Console.Write("Nuevo Monto Paga Cliente:¢ ");
                    montoPagaCliente[indice] = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Pago no se encuentra Registrado");
        }
    }




    // Programacion del Metodo Eliminar Pagos

    static void EliminarPagos()
    {
        Console.Write("Ingrese el número de pago que desea eliminar: ");
        int numero = int.Parse(Console.ReadLine());
        int indice = Array.IndexOf(numeroPago, numero);
        if (indice != -1)
        {
            Console.WriteLine("Datos del pago a eliminar:");
            Console.WriteLine($"Fecha/Hora: {fechaHora[indice]}");
            Console.WriteLine($"Cédula: {cedula[indice]}");
            Console.WriteLine($"Nombre: {nombre[indice]}");
            Console.WriteLine($"Apellido1: {apellido1[indice]}");
            Console.WriteLine($"Apellido2: {apellido2[indice]}");
            Console.WriteLine($"Número de Caja: {numeroCaja[indice]}");
            Console.WriteLine($"Tipo de Servicio: {tipoServicio[indice]}");
            Console.WriteLine($"Número de Factura: {numeroFactura[indice]}");
            Console.WriteLine($"Monto a Pagar: {montoPagar[indice]}");
            Console.WriteLine($"Monto Comisionado: {montoComisionado[indice]}");
            Console.WriteLine($"Monto Deducido: {montoDeducido[indice]}");
            Console.WriteLine($"Monto Paga Cliente: {montoPagaCliente[indice]}");
            Console.WriteLine($"Vuelto: {vuelto[indice]}");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("¿Está seguro de eliminar el dato (S/N)? ");
            string respuesta = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            if (respuesta.ToUpper() == "S")
            {
                // Eliminar el dato
                numeroPago[indice] = 0;
                fechaHora[indice] = DateTime.MinValue;
                cedula[indice] = 0;
                nombre[indice] = "";
                apellido1[indice] = "";
                apellido2[indice] = "";
                numeroCaja[indice] = 0;
                tipoServicio[indice] = 0;
                numeroFactura[indice] = 0;
                montoPagar[indice] = 0.0;
                montoComisionado[indice] = 0.0;
                montoDeducido[indice] = 0.0;
                montoPagaCliente[indice] = 0.0;
                vuelto[indice] = 0.0;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("La información ya fue eliminada.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("La información no fue eliminada.");

                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        else
        {
            Console.WriteLine("Pago no se encuentra Registrado");
        }
    }

    //Configuracion del Submenu Reportes, menu de opciones para el usuario, 

    static void SubmenuReportes()
    {
        int opcion;
        do
        {
            

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*********************************************************");
            Console.WriteLine(" Reportes Financieros");
            Console.WriteLine("*********************************************************");

            Console.ForegroundColor = ConsoleColor.DarkCyan; // Cambiar el color del texto del submenu 
            Console.WriteLine("1. Ver reporte de todos los Pagos");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("2. Ver reporte de Pagos por tipo de Servicio");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("3. Ver reporte de Pagos por código de caja");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("4. Ver reporte de Dinero Comisionado por servicios");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("5. Regresar Menú Principal");
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ingrese la opcion deseada: ");
            opcion = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White; // Cambiar el color del texto a blanco en las respuestas de la consulta

            switch (opcion)
            {
                case 1:
                    ReporteTodosLosPagos();
                    break;
                case 2:
                    ReportePagosPorTipoServicio();
                    break;
                case 3:
                    ReportePagosPorCodigoCaja();
                    break;
                case 4:
                    ReporteDineroComisionado();
                    break;
                case 5:
                    Console.WriteLine("Regresando al Menú Principal...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                    break;
            }
        } while (opcion != 5);
    }
    // Programacion del Metodo Reporte de todos los pagos 
    static void ReporteTodosLosPagos()
    {
        Console.WriteLine("Reporte de todos los Pagos:");
        for (int i = 0; i < cantidadPagos; i++)
        {
            Console.WriteLine($"Pago {numeroPago[i]} - Fecha: {fechaHora[i]}, Monto:¢ {montoPagar[i]}");
        }
    }

    // Programacion del Metodo Reporte pagos por tipo de servicio

    static void ReportePagosPorTipoServicio()
    {
        Console.Write("Ingrese el tipo de servicio (1=Recibo de Luz, 2=Recibo Teléfono, 3=Recibo de Agua): ");
        int tipo = int.Parse(Console.ReadLine());
        Console.WriteLine($"Reporte de Pagos para el Tipo de Servicio {tipo}:");
        for (int i = 0; i < cantidadPagos; i++)
        {
            if (tipoServicio[i] == tipo)
            {
                Console.WriteLine($"Pago {numeroPago[i]} - Fecha: {fechaHora[i]}, Monto:¢ {montoPagar[i]}");
            }
        }
    }

    // Programacion del Metodo Reporte pagos por codigo de caja

    static void ReportePagosPorCodigoCaja()
    {
        Console.Write("Ingrese el código de caja (1, 2 o 3): ");
        int codigo = int.Parse(Console.ReadLine());
        Console.WriteLine($"Reporte de Pagos para el Código de Caja {codigo}:");
        for (int i = 0; i < cantidadPagos; i++)
        {
            if (numeroCaja[i] == codigo)
            {
                Console.WriteLine($"Pago {numeroPago[i]} - Fecha: {fechaHora[i]}, Monto:¢ {montoPagar[i]}");
            }
        }
    }

    //Cálculos de comision por Servicio y reporte comision

    static void ReporteDineroComisionado()
    {
        double comisionElectricidad = 0;
        double comisionTelefono = 0;
        double comisionAgua = 0;
        int countElectricidad = 0;
        int countTelefono = 0;
        int countAgua = 0;

        for (int i = 0; i < cantidadPagos; i++)
        {
            switch (tipoServicio[i])
            {
                case 1:
                    comisionElectricidad += montoComisionado[i];
                    countElectricidad++;
                    break;
                case 2:
                    comisionTelefono += montoComisionado[i];
                    countTelefono++;
                    break;
                case 3:
                    comisionAgua += montoComisionado[i];
                    countAgua++;
                    break;
            }
        }

        //Impresion de la informacion deseada segun se escogio en el servicio deseado

        Console.WriteLine("Reporte de Dinero Comisionado por Servicios:");
        Console.WriteLine($"Comisión Recibo de Luz: {comisionElectricidad}, Transacciones: {countElectricidad}");
        Console.WriteLine($"Comisión Recibo Telefónico: {comisionTelefono}, Transacciones: {countTelefono}");
        Console.WriteLine($"Comisión Recibo de Agua: {comisionAgua}, Transacciones: {countAgua}");
    }
}

