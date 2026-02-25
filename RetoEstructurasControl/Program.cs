using System;

class Program
{
    static void Main()
    {
        // ==============================
        // SECCIÓN 1 — FOR Y FOREACH
        // ==============================

        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

        // For ascendente
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // For descendente
        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // Foreach para suma y promedio
        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");

        int suma = 0;

        foreach (int nota in calificaciones)
        {
            suma += nota;
        }

        double promedio = (double)suma / calificaciones.Length;

        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio}");

        // For con incremento de 2
        Console.WriteLine("\n=== POSICIONES PARES ===");

        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }

        // ==============================
        // SECCIÓN 2 — WHILE Y DO-WHILE
        // ==============================

        Console.WriteLine("\n=== CONTROL DE ACCESO ===");

        int intentos = 0;
        string claveCorrecta = "sena2025";
        string claveIngresada = "";

        while (claveIngresada != claveCorrecta && intentos < 3)
        {
            Console.Write("Ingresa la clave: ");
            claveIngresada = Console.ReadLine();
            intentos++;

            if (claveIngresada != claveCorrecta && intentos < 3)
            {
                Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
            }
        }

        if (claveIngresada == claveCorrecta)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Acceso bloqueado.");
        }

        // MENÚ DO-WHILE
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Promedio del grupo: {promedio}");
                    break;

                case 2:
                    int mayor = calificaciones[0];

                    foreach (int nota in calificaciones)
                    {
                        if (nota > mayor)
                        {
                            mayor = nota;
                        }
                    }

                    Console.WriteLine($"Calificación más alta: {mayor}");
                    break;

                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);

        // ==============================
        // SECCIÓN 3 — BREAK Y CONTINUE
        // ==============================

        Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine($"Encontrada en posición {i + 1}: {calificaciones[i]}");
                break;
            }
        }

        Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");

        int contadorAprobados = 0;

        foreach (int nota in calificaciones)
        {
            if (nota < 60)
            {
                continue;
            }

            Console.WriteLine($"Aprobado: {nota}");
            contadorAprobados++;
        }

        Console.WriteLine($"Total aprobados: {contadorAprobados}");

        Console.WriteLine("\n=== FILTRO COMBINADO ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 70)
            {
                continue;
            }

            if (calificaciones[i] >= 95)
            {
                Console.WriteLine($"Búsqueda detenida al encontrar: {calificaciones[i]}");
                break;
            }

            Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
        }
    }
}