using System;


class TorrentPirate
{
    static void Main()
    {
        double downloadData = double.Parse(Console.ReadLine());
        double priceOfCinema = double.Parse(Console.ReadLine());
        double wifeSpending = double.Parse(Console.ReadLine());

        double downloadTime = downloadData / 2 / 60 / 60;
        double priceForDownload = downloadTime * wifeSpending;
        double numberOfMovies = downloadData / 1500;
        double cinemaPrice = numberOfMovies * priceOfCinema;

        if (priceForDownload <= cinemaPrice)
        {
            Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
        }
        else
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
    }
}

