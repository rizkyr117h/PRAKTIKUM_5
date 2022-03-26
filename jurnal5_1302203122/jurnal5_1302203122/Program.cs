using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
/*            for (int i = 0; i < 10; i++)
            {
                video3.IncreasePLayCount(int.MaxValue);
            }*/
            SayaTubeVideo video5 = new SayaTubeVideo("Cars 5");
            SayaTubeVideo video6 = new SayaTubeVideo("Cars 6");
            SayaTubeVideo video7 = new SayaTubeVideo("Cars 7");
            SayaTubeVideo video8 = new SayaTubeVideo("Cars 8");
            SayaTubeVideo video9 = new SayaTubeVideo("Cars 9");
            SayaTubeVideo video10 = new SayaTubeVideo("Cars 10");

/*            SayaTubeUser profile2 = new SayaTubeUser(null);*/


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
            profile.addVideo(null);
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

            Debug.Assert(nama.Length < 101, "Max 100");
            Debug.Assert(nama != null, "Jangan Kosong");

            string testing;

            try
            {
                testing = checked(nama);
                Username = nama;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
            Debug.Assert(data != null, "Data Jangan Kosong");

            SayaTubeVideo testing;
            try
            {
                testing = checked(data);
                uploadedVideos.Add(data);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
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
            Debug.Assert(judul != null, "Jangan Kosong");
            Debug.Assert(judul.Length< 200, "Terlalu Panjang");

            string testing;
            try
            {
                testing = checked(judul);
                this.title = judul;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;

        }

        public void IncreasePLayCount(int angka)
        {
 
            Debug.Assert(angka <= 25000000, "Tidak Boleh Lebih Dari 25.000.000!!!");
            Debug.Assert(angka > 0, "Jangan Negative");
            Debug.Assert(angka < int.MaxValue, "Melebihi Batas MAX");
            int test;
            try
            {
                test = checked(this.playCount + angka);
                this.playCount += angka;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                playCount = playCount;
            }

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
