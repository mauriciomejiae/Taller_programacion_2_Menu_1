/* Nombre del Autor: Mauricio Mejia
 Fecha: 17 Noviembre del 2016
 Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi 
trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_programacion_2_Menu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black; /*Color de fondo*/
                Console.ForegroundColor = ConsoleColor.Green; /*Color de letra */

                Console.Clear();
                Console.WriteLine("*********************************** MENU 1. Taller de Programación N°2 ***********************************");
                Console.WriteLine();
                Console.WriteLine("[1]. Ejercicio 1: Instrucciones para preparar una pizza (6 Porciones)");
                Console.WriteLine();
                Console.WriteLine("[2]. Ejercicio 4: Programa que permite encontrar el área de una zona de paseo de un parque");
                Console.WriteLine();
                Console.WriteLine("[3]. Ejercicio 7: Programa que permite leer la fecha de nacimiento e indica su signo Zodiacal + acompañado del horóscopo");
                Console.WriteLine();
                Console.WriteLine("[4]. Ejercicio 10: Programa que permite leer de un menú operaciones  y realizar respectivos cálculos");
                Console.WriteLine();
                Console.WriteLine("[5]. Ejercicio 22: Programa que emula calculadora básica + funciones trigonométricas");
                Console.WriteLine();
                Console.WriteLine("[6]. Ejercicio 23: Programa que permite conocer un poco mas del estudiante");
                Console.WriteLine();
                Console.WriteLine("[0]. Salir");
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************************************");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción:");
                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                } while (opcion < '0' || opcion > '6');
                Console.WriteLine(opcion + "\n");

                switch (opcion)
                {
                    case '1':

                        Console.Clear();
                        Console.WriteLine("[1]. Ejercicio 1: Instrucciones para preparar una pizza (6 Porciones)");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("INGREDIENTES");
                        Console.WriteLine("Harina de Fuerza 570g, Levadura 42g, Agua 300ml, Leche 75ml, Sal 1 cucharada y media, Azúcar 3 cucharadas, Aceite de Oliva 3 cucharadas soperas, Queso de Tetilla 120g, Lacón asado 80g, Pimiento rojo asado 60g, Salsa de tomate casera 100g, Queso Rallado Para cubrir la base, Albahaca Al gusto, Orégano Al gusto, Pimienta Negra Molida, Sal, Aceite de Oliva.");
                        Console.WriteLine("PASOS PARA PREPARAR LA MASA");
                        Console.WriteLine("PASO #1");
                        Console.WriteLine("En una báscula de cocina pesamos la harina de fuerza y la levadura de panadería. A continuación, en el bol donde se va a hacer la mezcla y el primer amasado, echamos la harina de fuerza, el azúcar y la sal. Mezclamos estos ingredientes y hacemos un hueco en el centro del bol");
                        Console.WriteLine("PASO #2");
                        Console.WriteLine("A continuación, añadimos la leche. Si estuviese fría de la nevera es necesario calentarla primero. Si está a temperatura ambiente no es necesario.");
                        Console.WriteLine("PASO #3");
                        Console.WriteLine("El siguiente paso será diluir la levadura de panadería en un recipiente con el agua tibia. Removemos bien hasta que se disuelva completamente y a continuación incorporamos esta mezcla al bol y empezamos a remover con la ayuda de una cuchara de madera hasta que se mezclen todos los ingredientes.");
                        Console.WriteLine("PASO #4");
                        Console.WriteLine("Cuando la masa tenga un poco de consistencia es el momento de empezar a amasar con las manos. Enharinamos la encimera de la cocina y empezamos a amasar hasta obtener una masa compacta (2-4 minutos). Hacemos un hueco en el medio de la masa y añadimos el aceite de oliva y volvemos a amasar. Mezclamos bien y continuamos amasando hasta que nos quede una masa manejable y que no se nos quede pegada a las manos");
                        Console.WriteLine("PASO #5");
                        Console.WriteLine("Por último sólo faltaría que repose la masa hasta que doble su tamaño (1 hora aproximadamente). Para ello hay que untar un bol con un poco de aceite o harina y dejar reposar en él la masa, cubierta con un paño de cocina, y en un lugar templado y sin corrientes de aire");
                        Console.WriteLine("Pasada una hora, ya veremos como ha crecido la masa. Para darle forma de pizza, primero hay que aplastar la masa con el puño para quitarle todo el gas originado en la fermentación y a continuación ya estaría lista para darle forma.");
                        Console.WriteLine("");
                        Console.WriteLine("PASOS PARA ELABORAR LA PIZZA");
                        Console.WriteLine("Prepararemos Pizza a la Gallega");
                        Console.WriteLine("PASO #1");
                        Console.WriteLine("Una vez tenemos la masa preparada, precalentamos el horno a 220º C con calor en la parte superior e inferior. Estiramos la masa y cubrimos con la salsa de tomate y unas hojas de albahaca fresca.");
                        Console.WriteLine("PASO #2");
                        Console.WriteLine("Añadimos el queso rallado para cubrir la base.");
                        Console.WriteLine("PASO #3");
                        Console.WriteLine("Cortamos el queso de tetilla, los pimientos asados y el lacón y repartimos por la pizza.");
                        Console.WriteLine("PASO #4");
                        Console.WriteLine("Añadimos un poco de sal, pimienta molida, unas hojas de orégano fresco y aceite de oliva. Horneamos a 220º C entre 10 y 15 minutos y ya estará lista!");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("La consulta se ha realizado exitosamente! ");
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para volver al menú . . . ");
                        Console.ReadKey();
                        break;

                    case '2':

                        double area;
                        double pi;
                        double radio_fuente = 4;
                        double radio_parque;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("[2]. Ejercicio 4: Programa que permite encontrar el área de una zona de paseo de un parque");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("El radio de la fuente es " + radio_fuente, " Metros.");
                            Console.WriteLine("Ingrese el radio del parque en Metros [Mayor a 4]:");
                            radio_parque = Double.Parse(Console.ReadLine());
                            if (radio_parque > 4)
                            {
                                area = Math.PI * Math.Pow(radio_parque, 2);
                                Console.WriteLine("El area de la zona de paseo del parque es:");
                                Console.WriteLine(area + " Metros");
                            }
                            else
                            {
                                Console.WriteLine("Error!. El radio del área del parque debe ser mayor que el radio de la fuente.");
                            }

                        } while (radio_parque <= 4);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("La consulta se ha realizado exitosamente! ");
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para volver al menú . . . ");
                        Console.ReadKey();
                        break;

                    case '3':

                        int ano;
                        int dia;
                        int mes;
                        Console.Clear();
                        Console.WriteLine("[3]. Ejercicio 7: Programa que permite leer la fecha de nacimiento e indica su signo Zodiacal + acompañado del horóscopo");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el dia de nacimiento:");
                        dia = int.Parse(Console.ReadLine());
                        while (dia <= 0 || dia > 31)
                        {
                            Console.WriteLine("Error!.Ingrese un valor válido.");
                            dia = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Ingrese el mes de nacimiento:");
                        mes = int.Parse(Console.ReadLine());
                        while (mes <= 0 || mes > 12)
                        {
                            Console.WriteLine("Error!.Ingrese un valor válido.");
                            mes = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Ingrese el año de nacimiento:");
                        ano = int.Parse(Console.ReadLine());
                        while (ano <= 0 || ano > 2016)
                        {
                            Console.WriteLine("Error!.Ingrese un valor válido.");
                            ano = int.Parse(Console.ReadLine());
                        }
                        if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
                        {
                            Console.WriteLine("Su signo Zodiacal es CAPRICORNIO");
                            Console.WriteLine(" ");
                            Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                            Console.WriteLine("En el plano afectivo, oposiciones.En el resto se dedicará a negociar.Amor: Lo que suceda en los próximos días le enseñará mucho sobre relaciones humanas. Renuncie a lo superfluo; los suyos lo necesitan. Trabajo: Propuestas que debe analizar bien. Si trabaja con familiares o amigos la situación se le irá de las manos.Sorpresa: Planifique porque habrá mucha desorganización.");
                        }
                        else
                        {
                            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
                            {
                                Console.WriteLine("Su signo Zodiacal es ACUARIO");
                                Console.WriteLine(" ");
                                Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                Console.WriteLine("Laboralmente muy exitoso; en lo sentimental sin queja alguna. Amor: Gracias a Venus en Libra hallará cierto equilibrio. No discuta por pequeñeces. Si debe sincerarse, que sea con quien lo sepa entender. Trabajo: Cuenta con capital y puede avanzar aunque sobren complicaciones. Sea expeditivo y firme con quien no coopera.Sorpresa: Para tomar decisiones espere a que las condiciones estén dadas");
                            }
                            else
                            {
                                if ((dia >= 20 && mes == 2) || (dia <= 21 && mes == 3))
                                {
                                    Console.WriteLine("Su signo Zodiacal es PISCIS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                    Console.WriteLine("Irritable en casa con algo menos de energía para enfrentar el día a día.Amor: Un par de molestos conflictos familiares. Aunque poner límites no le guste, más le vale hacerlo. Se debilitan algunos lazos afectivos.Trabajo: Lo tendrán bajo la lupa. Busque un justo equilibrio entre el deber y el placer porque el estrés acecha.Sorpresa: No siga ni a los temerosos ni a los muy osados.");
                                }
                                else
                                {
                                    if ((dia >= 22 && mes == 3) || (dia <= 20 && mes == 4))
                                    {
                                        Console.WriteLine("Su signo Zodiacal es ARIES");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                        Console.WriteLine("Semana de mucha exigencia, aunque también de disfrutar a pleno. Amor: Nada de pensar, es tiempo de sentir. Venus en Libra genera peleas y gran atracción. A veces es mejor dejarse de ver unos días. Trabajo: Tiene chance de ganar en la medida en que insista. Ser paciente ayuda. No baje la guardia frente a sus competidores. Sorpresa: Revise sus recursos antes de darse por vencido.");
                                    }
                                    else
                                    {
                                        if ((dia >= 21 && mes == 4) || (dia <= 21 && mes == 5))
                                        {
                                            Console.WriteLine("Su signo Zodiacal es TAURO");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                            Console.WriteLine("Cuando haya problemas mejor resolverlos en conjunto. Cambios. Amor: Sus ganas de formar pareja lo mantendrán ocupado. Venus en Libra lo invita a soñar aunque pueda perderse una realidad impactante. Trabajo: Sea más precavido si pasan por sus manos grandes sumas o si tiene grupos a su cargo. Lucha constante.Sorpresa: A no insistir ante quien pone siempre distancia.");
                                        }
                                        else
                                        {
                                            if ((dia >= 22 && mes == 5) || (dia <= 21 && mes == 6))
                                            {
                                                Console.WriteLine("Su signo Zodiacal es GEMINIS");
                                                Console.WriteLine(" ");
                                                Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                                Console.WriteLine("Venus en Libra augura ternura y buen encuentro en la pareja. Amor: En armonía con el entorno en general y con la pareja en particular. Frente a situaciones familiares complicadas mejor corte por lo sano. Trabajo: Se cruzará -lamentablemente- con personas difíciles que no lo reconocen. La crisis no durará. Sorpresa: No dé el brazo a torcer si existe chantaje emocional.");
                                            }
                                            else
                                            {
                                                if ((dia >= 22 && mes == 6) || (dia <= 23 && mes == 7))
                                                {
                                                    Console.WriteLine("Su signo Zodiacal es CANCER");
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                                    Console.WriteLine("Cierta armonía general siempre que se proponga ser receptivo. Amor: Si se deja querer verá cómo cambia el vínculo. Venus en Libra lo facilita. Tal vez llegue a su vida quien despierte su pasión. Trabajo: Logrará captar a gente con poder. Le irá mejor si comercia con gente de la cual tenga buenas referencias. Cuidado. Sorpresa: No existe aprendizaje más valioso que escuchar al otro.");
                                                }
                                                else
                                                {
                                                    if ((dia >= 24 && mes == 7) || (dia <= 23 && mes == 8))
                                                    {
                                                        Console.WriteLine("Su signo Zodiacal es LEO");
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                                        Console.WriteLine("Fuerza, confianza y gran ayuda cósmica. Apego de su gente querida. Amor: Su pareja hará lo que usted desee sin grandes enfrentamientos. Con Venus en Libra las penas quedaron en el pasado. Llega un buen amigo. Trabajo: Tiene que sacar provecho de su buena racha, así que nada de postergarse. Hará que sus negocios rindan. Sorpresa: Una corazonada acertadísima le da gran rédito.");
                                                    }
                                                    else
                                                    {
                                                        if ((dia >= 24 && mes == 8) || (dia <= 23 && mes == 9))
                                                        {
                                                            Console.WriteLine("Su signo Zodiacal es VIRGO");
                                                            Console.WriteLine(" ");
                                                            Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                                            Console.WriteLine("Semana plagada de dudas personales e incertidumbre financiera. Amor: En un constante ir y venir por momentos creerá estar enamorado. y de inmediato dejará de interesarse. Venus en Libra lo confunde. Trabajo: Dependerá del apoyo ajeno. Acepte que no está en condiciones de cambiar su realidad por el momento. Sorpresa: Si el interés se opone al sentimiento atienda a la emoción.");
                                                        }
                                                        else
                                                        {
                                                            if ((dia >= 24 && mes == 9) || (dia <= 23 && mes == 10))
                                                            {
                                                                Console.WriteLine("Su signo Zodiacal es LIBRA");
                                                                Console.WriteLine(" ");
                                                                Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                                                Console.WriteLine("Mientras siga Venus en su signo todo en su vida marcha más que bien. Amor: Felices coincidencias lo llevan a replantearse el ancestral miedo al compromiso. Asumirá sus responsabilidades con alegría. Trabajo: Pese a las presiones, es posible que mejore en los negocios. Poner límites será vital para usted. Sorpresa: No elija el camino más corto. Haga el trayecto bien.");
                                                            }
                                                            else
                                                            {
                                                                if ((dia >= 24 && mes == 10) || (dia <= 22 && mes == 11))
                                                                {
                                                                    Console.WriteLine("Su signo Zodiacal es ESCORPION");
                                                                    Console.WriteLine(" ");
                                                                    Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                                                    Console.WriteLine("Aceptable perspectiva laboral aunque no resulte igual en lo afectivo. Amor: Ante las trampas del amor. Si no presta atención a su sexto sentido puede terminar unido a la persona equivocada. No tema a la soledad. Trabajo: Buenas opciones para asociarse o formar equipos. Resultará excelente como líder o consejero de un grupo. Sorpresa: La seducción es un juego que tiene consecuencias. Cuidado.");
                                                                }
                                                                else
                                                                {
                                                                    if ((dia >= 23 && mes == 11) || (dia <= 22 && mes == 12))
                                                                    {
                                                                        Console.WriteLine("Su signo Zodiacal es SAGITARIO");
                                                                        Console.WriteLine(" ");
                                                                        Console.WriteLine("Enterate de lo que te deparan los astros para ti: ");
                                                                        Console.WriteLine("Afectivamente protegido y en lo material ante un visible repunte. Amor: Mejora la relación con aquellos que lo rodean gracias al influjo de Venus en Libra. La competencia estimulará la mutua admiración. Trabajo: Las distracciones pueden ser fatales. Trate de tener los pies en la tierra y el resto se irá resolviendo. Sorpresa: Celar un poco preserva el amor, demasiado lo asfixia.");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para continuar . . . ");
                        Console.ReadKey();
                        break;

                    case '4':

                        double ladoa;
                        double ladob;
                        double bas;
                        double area_circulo;
                        double area_cuadrado;
                        double area_paralelogramo;
                        double area_rectangulo;
                        double area_triangulo;
                        double h;
                        double radio;
                        int opc;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("[4]. Ejercicio 10: Programa que permite leer de un menú operaciones  y realizar respectivos cálculos");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("1.- área de un triangulo");
                            Console.WriteLine("2.- área de un cuadrado");
                            Console.WriteLine("3.- área de un círculo");
                            Console.WriteLine("4.- área de un rectángulo");
                            Console.WriteLine("5.- área de un paralelogramo");
                            Console.WriteLine("0.- Salir");
                            Console.WriteLine(" ");
                            Console.WriteLine("Elija una opción [1-5]: ");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("El área de un triángulo es igual a base por altura dividido entre 2.");
                                    Console.WriteLine("Ingrese la base:");
                                    bas = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura:");
                                    h = Double.Parse(Console.ReadLine());
                                    area_triangulo = (bas * h) / 2;
                                    Console.WriteLine("El area es: " + area_triangulo);
                                    break;
                                case 2:
                                    Console.WriteLine("El área del cuadrado es igual a lado por lado.");
                                    Console.WriteLine("Ingrese lado a:");
                                    ladoa = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Lado b:");
                                    ladob = Double.Parse(Console.ReadLine());
                                    area_cuadrado = ladoa * ladob;
                                    Console.WriteLine("El area es: " + area_cuadrado);
                                    break;
                                case 3:
                                    Console.WriteLine("El área del círculo es igual a PI por el radio al cuadrado..");
                                    Console.WriteLine("Ingrese el radio:");
                                    radio = Double.Parse(Console.ReadLine());
                                    area_circulo = Math.PI * Math.Pow(radio, 2);
                                    Console.WriteLine("El area es: " + area_circulo);
                                    break;
                                case 4:
                                    Console.WriteLine("El área del rectángulo es igual a base por altura.");
                                    Console.WriteLine("Ingrese la base:");
                                    bas = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura:");
                                    h = Double.Parse(Console.ReadLine());
                                    area_rectangulo = bas * h;
                                    Console.WriteLine(" El area es: " + area_rectangulo);
                                    break;
                                case 5:
                                    Console.WriteLine("El área de un paralelogramo es igual al producto de la base por la altura relativa.");
                                    Console.WriteLine("Ingrese la altura relativa:");
                                    h = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la base:");
                                    bas = Double.Parse(Console.ReadLine());
                                    area_paralelogramo = bas * h;
                                    Console.WriteLine("El area es: " + area_paralelogramo);
                                    break;
                                case 0:
                                    Console.WriteLine("Salida exitosa.");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida, intente nuevamente.");
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para continuar... ");
                            Console.ReadKey();
                        } while (opc != 0);

                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para volver al menú. . . ");
                        Console.ReadKey();
                        break;



                    case '5':

                        double a;
                        double b;
                        double co;
                        double div;
                        double mult;
                        double ra;
                        double res;
                        double se;
                        double sum;
                        double ta;
                        int opcionmenu;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("[5]. Ejercicio 22: Programa que emula calculadora básica + funciones trigonométricas");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("1.Suma");
                            Console.WriteLine("2.Resta");
                            Console.WriteLine("3.Multiplicación");
                            Console.WriteLine("4.División");
                            Console.WriteLine("5.Seno");
                            Console.WriteLine("6.Coseno");
                            Console.WriteLine("7.Tangente");
                            Console.WriteLine("8.Raiz Cuadrada");
                            Console.WriteLine("9.Salir");
                            Console.WriteLine(" ");
                            Console.WriteLine("Elija una opción [1-9]: ");
                            opcionmenu = int.Parse(Console.ReadLine());
                            switch (opcionmenu)
                            {
                                case 1:

                                    Console.WriteLine("Ingrese el primer sumando:");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el otro sumando:");
                                    b = Double.Parse(Console.ReadLine());
                                    sum = a + b;
                                    Console.WriteLine("La suma es " + sum);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 2:

                                    Console.WriteLine("Ingrese el minuendo:");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el sustraendo:");
                                    b = Double.Parse(Console.ReadLine());
                                    res = a - b;
                                    Console.WriteLine("La resta o diferencia es: " + res);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 3:

                                    Console.WriteLine("Ingrese un factor :");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite otro factor:");
                                    b = Double.Parse(Console.ReadLine());
                                    mult = a * b;
                                    Console.WriteLine("La multiplicación es: " + mult);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 4:

                                    Console.WriteLine("Ingrese el dividendo:");
                                    a = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el divisor:");
                                    b = Double.Parse(Console.ReadLine());
                                    div = a / b;
                                    Console.WriteLine("El cociente es: " + div);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 5:

                                    Console.WriteLine("Ingresa el ángulo en radiantes:");
                                    a = Double.Parse(Console.ReadLine());
                                    se = Math.Sin(a);
                                    Console.WriteLine("El seno es " + se);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 6:

                                    Console.WriteLine("Ingresa en ángulo en radiantes:");
                                    a = Double.Parse(Console.ReadLine());
                                    co = Math.Cos(a);
                                    Console.WriteLine("El coseno es " + co);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 7:

                                    Console.WriteLine("Ingresa en ángulo en radiantes:");
                                    a = Double.Parse(Console.ReadLine());
                                    ta = Math.Tan(a);
                                    Console.WriteLine("La tangente es " + ta);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 8:

                                    Console.WriteLine("Ingresa un número:");
                                    a = Double.Parse(Console.ReadLine());
                                    ra = Math.Sqrt(a);
                                    Console.WriteLine("La raiz cuadrada es " + ra);
                                    Console.Write("\nPresione una tecla para continuar . . . ");
                                    Console.ReadKey();
                                    break;

                                case 9:

                                    Console.WriteLine("Salida exitosa");
                                    break;
                            }
                        } while (opcionmenu != 9);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para volver al menú . . . ");
                        Console.ReadKey();
                        break;


                    case '6':

                        int op;
                        Console.Clear();
                        Console.WriteLine("[6]. Ejercicio 23: Programa que permite conocer un poco mas del estudiante");
                        Console.WriteLine();
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("1. Nombres");
                            Console.WriteLine("2. Lugar residencia");
                            Console.WriteLine("3. Contacto celular");
                            Console.WriteLine("4. Libro preferido");
                            Console.WriteLine("5. Pelicula preferida");
                            Console.WriteLine("6. Deporte que practico");
                            Console.WriteLine("7. Otros aspectos");
                            Console.WriteLine("8. Despedida");
                            Console.WriteLine("9. Salir");
                            Console.WriteLine();
                            Console.WriteLine("Seleccione una opción:");

                            op = int.Parse(Console.ReadLine());
                            switch (op)

                            {
                                case 1:
                                    Console.WriteLine("Mauricio Mejia Estevez");
                                    break;
                                case 2:
                                    Console.WriteLine("Barrancabermeja,Santander");
                                    break;
                                case 3:
                                    Console.WriteLine("3178956150");
                                    break;
                                case 4:
                                    Console.WriteLine("La Biblia");
                                    break;
                                case 5:
                                    Console.WriteLine("Serie Mr. Robot");
                                    break;
                                case 6:
                                    Console.WriteLine("Fútbol");
                                    break;
                                case 7:
                                    Console.WriteLine("Me gusta escuchar música, leer, dormir, aprender, estudiar,entre otras.");
                                    break;
                                case 8:
                                    Console.WriteLine("Mijo, ud que es programador; programe la alarma a las 6 am...");
                                    break;
                                case 9:
                                    Console.WriteLine("Salida exitosa.");
                                    break;
                                default:
                                    Console.WriteLine("Error de validación");
                                    break;
                            }
                        } while (op != 9);
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para continuar . . . ");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != '0');
            Console.WriteLine();
            Console.Write("Salida exitosa del programa. . . . ");
            Console.Write("\nPresione una tecla para continuar . . . ");
            Console.ReadKey();
        }
    }
}
