namespace examen1NET
{
    class ControlRuleta
    {
        private int _dinero;
        //private int _apuesta;
        private List<int> _giros;
        private List<int> _rojos;
        private List<int> _negros;
        private List<int> _pares;
        private List<int> _impares;
        //private List<int> _nmas;
        //private List<int> _nmenos;
    
        public ControlRuleta(){
            _giros = new List<int>();
            _rojos = new List<int>();
            _negros = new List<int>();
            _pares = new List<int>();
            _impares = new List<int>();
            //_nmas = new List<int>();
            //_nmenos = new List<int>();
            _dinero = 300;
            //_apuesta = int.Parse(Console.ReadLine());
        }

        /*public void validaApuesta(){
            validaApuesta = apuesta%10;
            if (validaApuesta != 0)
            {
                
            }
        }*/
        public void showMenuApuesta()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("*Este es un simulador del juego de la ruleta*");
                Console.WriteLine("*********************************************");
                Console.WriteLine("Recuerda que incias con $300.00");
                Console.WriteLine("1. Apostar a un numero especifico");
                Console.WriteLine("2. Apostar al color rojo");
                Console.WriteLine("3. Apostar al color negro");
                Console.WriteLine("4. Apostar que es un numero par");
                Console.WriteLine("5. Apostar que es un numero impar");
                Console.WriteLine("6. Ver estadisticas");
                Console.WriteLine("7. Salir");
            } while (!validaMenu(4, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    apuestaNumero();
                    break;
                case 2:
                    apuestaColorRojo();
                    break;
                case 3:
                    apuestaColorNegro();
                    break;
                case 4: 
                    apuestaNumPar();
                    break;
                case 5:
                    apuestaNumImpar();
                    break;
                case 6:
                    showMenuEst();
                    break;
                case 7: break;

            }
        }

        private void apuestaNumero()
        {
            Console.WriteLine("El numero por el que apostaras es... ");
            int numeroApostado = int.Parse(Console.ReadLine());
            Console.WriteLine("Dinero a apostar");
            int apuesta = int.Parse(Console.ReadLine());
            Random Generar = new Random();
            int aleatorio = Generar. Next(0, 37);
            if(numeroApostado == aleatorio)
            {
            Console.WriteLine();
            Console.WriteLine("¡Enhorabuena, ha caído tu número!");
            _dinero = +apuesta * 10;
            _giros.Add(apuesta);
            }
            else
            {
            Console.WriteLine();
            Console.WriteLine("Lo siento a caido el número "+ aleatorio);
            _giros.Add(apuesta);
            }
        }
            //caso 2
        private void apuestaColorRojo()
        {
            Console.WriteLine("Dinero a apostar");
            int apuesta = int.Parse(Console.ReadLine());
            Random Generar = new Random();
            int aleatorio = Generar. Next(0, 37);
            if (aleatorio==1 || aleatorio==3 || aleatorio==5 || aleatorio==7 || aleatorio==9 || aleatorio==12 || aleatorio==14 || aleatorio==16 || 
            aleatorio==18|| aleatorio==19 || aleatorio==21 || aleatorio==23 || aleatorio==25 || aleatorio==27 || aleatorio==30 || aleatorio==32 || 
            aleatorio==34 || aleatorio==36)
            {
            Console.WriteLine();
            Console.WriteLine("¡Enhorabuena, ha caído tu número!");
            _dinero = +apuesta * 5; 
            _rojos.Add(apuesta);
            _giros.Add(apuesta);
            }
            else
            {
            Console.WriteLine();
            Console.WriteLine("Lo siento a caido el número "+ aleatorio);
            _giros.Add(apuesta);
            }
        }
        // caso 3 
        private void apuestaColorNegro()
        {
            Console.WriteLine("Dinero a apostar");
            int apuesta = int.Parse(Console.ReadLine());
            Random Generar = new Random();
            int aleatorio = Generar. Next(0, 37);
            if (aleatorio==2 || aleatorio==4 || aleatorio==6 || aleatorio==8 || aleatorio==10 || aleatorio==11 || aleatorio==13 || aleatorio==15 || 
            aleatorio==17|| aleatorio==20 || aleatorio==22 || aleatorio==24 || aleatorio==26 || aleatorio==28 || aleatorio==29 || aleatorio==31 || 
            aleatorio==33 || aleatorio==35)
            {
            Console.WriteLine();
            Console.WriteLine("¡Enhorabuena, ha caído tu número!");
            _dinero = +apuesta * 5; 
            _negros.Add(apuesta);
            _giros.Add(apuesta);
            }
            else
            {
            Console.WriteLine();
            Console.WriteLine("Lo siento a caido el número "+ aleatorio);
            _giros.Add(apuesta);
            }
        }
        // caso 4
        private void apuestaNumPar()
        {
            Console.WriteLine("Dinero a apostar");
            int apuesta = int.Parse(Console.ReadLine());
            Random Generar = new Random();
            int aleatorio = Generar. Next(0, 37);
            if (aleatorio==2 || aleatorio==4 || aleatorio==6 || aleatorio==8 || aleatorio==10 || aleatorio==12 || aleatorio==14 || aleatorio==16 || 
            aleatorio==18|| aleatorio==20 || aleatorio==22 || aleatorio==24 || aleatorio==26 || aleatorio==28 || aleatorio==30 || aleatorio==32 || 
            aleatorio==34 || aleatorio==36)
            {
            Console.WriteLine();
            Console.WriteLine("¡Enhorabuena, ha caído tu número!");
            _dinero = +apuesta * 2; 
            _pares.Add(apuesta);
            _giros.Add(apuesta);
            }
            else
            {
            Console.WriteLine();
            Console.WriteLine("Lo siento a caido el número "+ aleatorio);
            _giros.Add(apuesta);
            }
        }
        //caso 5
        private void apuestaNumImpar()
        {
            Console.WriteLine("Dinero a apostar");
            int apuesta = int.Parse(Console.ReadLine());
            Random Generar = new Random();
            int aleatorio = Generar. Next(0, 37);
            if (aleatorio==1 || aleatorio==3 || aleatorio==5 || aleatorio==7 || aleatorio==9 || aleatorio==11 || aleatorio==13 || aleatorio==15 || 
            aleatorio==17|| aleatorio==19 || aleatorio==21 || aleatorio==23 || aleatorio==25 || aleatorio==27 || aleatorio==29 || aleatorio==31 || 
            aleatorio==33 || aleatorio==35)
            {
            Console.WriteLine();
            Console.WriteLine("¡Enhorabuena, ha caído tu número!");
            _dinero = +apuesta * 2; 
            _impares.Add(apuesta);
            _giros.Add(apuesta);
            }
            else
            {
            Console.WriteLine();
            Console.WriteLine("Lo siento a caido el número "+ aleatorio);
            _giros.Add(apuesta);
            }
        }

        // caso 6
        public void showMenuEst()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Selecciona la opcion correcta");
                Console.WriteLine("1.- Balance");
                Console.WriteLine("2.- Giros");
                Console.WriteLine("3.- Resultados rojos");
                Console.WriteLine("5.- Resultados negros");
                Console.WriteLine("6.- Resultados pares");
                Console.WriteLine("7.- Resultados impares");
                Console.WriteLine("8.- Salir");
            } while (!validaMenu(4, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {

                case 1:
                    Console.WriteLine(_dinero);
                    break;
                case 2:
                    foreach (int i in _giros)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:
                    foreach (int i in _rojos)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 4:
                    foreach (int i in _negros)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 5:
                    foreach (int i in _pares)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 6:
                    foreach (int i in _impares)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 7: break;
            }
        }
        // Validar Menu
        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido, debes ingresar un número.");
                return false;
            }
        }

    }
}