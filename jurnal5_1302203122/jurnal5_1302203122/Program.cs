using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_1302203122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Cars 1");
            video1.IncreasePLayCount(10);
            SayaTubeVideo video2 = new SayaTubeVideo("Cars 2");
            video2.IncreasePLayCount(20);
            SayaTubeVideo video3 = new SayaTubeVideo("Cars 3");
            video3.IncreasePLayCount(30);
            SayaTubeVideo video4 = new SayaTubeVideo("Cars 4");
            SayaTubeVideo video5 = new SayaTubeVideo("Cars 5");
            SayaTubeVideo video6 = new SayaTubeVideo("Cars 6");
            SayaTubeVideo video7 = new SayaTubeVideo("Cars 7");
            SayaTubeVideo video8 = new SayaTubeVideo("Cars 8");
            SayaTubeVideo video9 = new SayaTubeVideo("Cars 9");
            SayaTubeVideo video10 = new SayaTubeVideo("Cars 10");


            SayaTubeUser profile = new SayaTubeUser("Rizky");
            profile.addVideo(video1);
            profile.addVideo(video2);
            profile.addVideo(video3);
            profile.addVideo(video4);
            profile.addVideo(video5);
            profile.addVideo(video6);
            profile.addVideo(video7);
            profile.addVideo(video8);
            profile.addVideo(video9);
            profile.addVideo(video10);
            profile.PrintAllVideoPlayCount();

            
            
        }
    }

    class SayaTubeUser
    {
        int id;
        List<SayaTubeVideo> uploadedVideos;
        string Username;

        public SayaTubeUser(string nama)

        {
            Username = nama;
            uploadedVideos = new List<SayaTubeVideo>();

            Random generate = new Random();
            this.id = generate.Next(0, 100000);


        }

        public void GetTotalVideoPlayCount()
        {

            int dataPlayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                dataPlayCount = dataPlayCount + video.returnPlayCount();
            }
        }

        public void addVideo(SayaTubeVideo data)
        {
            uploadedVideos.Add(data);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("Username :" + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video" + (i + 1) + " :" + uploadedVideos[i].returnTitle());
            }
        }

    }

    class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo(string judul)
        {
            title = judul;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;

        }

        public void IncreasePLayCount(int angka)
        {
            playCount = playCount + angka;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("playCount :" + playCount);
        }

        public int returnPlayCount()
        {
            return playCount;
        }
        public string returnTitle()
        {
            return title;
        }
    }
}
