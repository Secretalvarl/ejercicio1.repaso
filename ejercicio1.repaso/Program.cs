namespace ejercicio1.repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero de minutos trabajados en un mes:");
            int numeroMinutos = Convert.ToInt32(Console.ReadLine());

            int horasDiaTrabajo = 8;

            int dia = numeroMinutos / (horasDiaTrabajo * 60);
            int horas = numeroMinutos % (horasDiaTrabajo * 60) / 60;
            int minutos = numeroMinutos % 60;

            int dias;
            int minuto;
            int hora;

            if (dia > 0)
            {
                Console.WriteLine(dia + "días");
            }
            if (horas > 0)
            {
                Console.WriteLine(horas + "horas");
            }
            if (minutos > 0)
            {
                Console.WriteLine(minutos + "minutos");
            }
            
            Console.WriteLine(dia + " " + "días" + " " + horas + " " + "horas" + " " + minutos + " " + "minutos");

            
        }
    }
}