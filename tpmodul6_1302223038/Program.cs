using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Arga Adolf Lumunon");
        video.IncreasePlayCount(69); 
        video.PrintVideoDetails();
    }
}
