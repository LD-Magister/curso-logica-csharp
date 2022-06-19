using System;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {

            string[] data, hora;
            int diaIn, horaIn, minIn, segIn,
                diaFin, horaFin, minFin, segFin,
                totalDiaIn, totalDiaFin, totalEvento,
                totalDia, totalHora, totalMin, totalSeg, totalResto;

            data = Console.ReadLine().Split(' ');
            diaIn = int.Parse(data[1]);

            hora = Console.ReadLine().Split(' ');
            horaIn = int.Parse(hora[0]);
            minIn = int.Parse(hora[2]);
            segIn = int.Parse(hora[4]);

            data = Console.ReadLine().Split(' ');
            diaFin = int.Parse(data[1]);

            hora = Console.ReadLine().Split(' ');
            horaFin = int.Parse(hora[0]);
            minFin = int.Parse(hora[2]);
            segFin = int.Parse(hora[4]);

            totalDiaIn = (horaIn * 3600) + (minIn * 60) + segIn;
            totalDiaFin = (horaFin * 3600) + (minFin * 60) + segFin;

            totalEvento = ((diaFin - diaIn) * 86400) - totalDiaIn + totalDiaFin;
            totalDia = totalEvento / 86400;
            Console.WriteLine(totalDia + " dia(s)");
            totalResto = totalEvento % 86400;

            totalHora = totalResto / 3600;
            Console.WriteLine(totalHora + " hora(s)");
            totalResto = totalResto % 3600;

            totalMin = totalResto / 60;
            Console.WriteLine(totalMin + " minuto(s)");
            totalResto = totalResto % 60;

            totalSeg = totalResto;
            Console.WriteLine(totalSeg + " segundo(s)");
        }
    }
}