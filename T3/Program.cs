using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            TVProgram huomentaSuomi = new TVProgram();
            TVProgram pikkuKakkonen = new TVProgram();
            TVProgram karpollaAsiaa = new TVProgram();

            huomentaSuomi.Name = "Huomenta Suomi!";
            huomentaSuomi.Channel = "YleTV 1";
            huomentaSuomi.Begins = "08:00";
            huomentaSuomi.Ends = "09:00";
            huomentaSuomi.Info = "Tuoreimmat aamun uutiset";

            pikkuKakkonen.Name = "Pikku Kakkonen";
            pikkuKakkonen.Channel = "YleTV 2";
            pikkuKakkonen.Begins = "07:00";
            pikkuKakkonen.Ends = "08:00";
            pikkuKakkonen.Info = "Lastenohjelma ohjelma";

            karpollaAsiaa.Name = "Karpolla on Asiaa";
            karpollaAsiaa.Channel = "YleTV 1";
            karpollaAsiaa.Begins = "09:00";
            karpollaAsiaa.Ends = "10:40";
            karpollaAsiaa.Info = "Karpo kertoo kuumottavista puheenaiheista";

            List<TVProgram> ohjelmat = new List<TVProgram>();
            ohjelmat.Add(huomentaSuomi);
            ohjelmat.Add(pikkuKakkonen);
            ohjelmat.Add(karpollaAsiaa);

            Stream writeMultipleStream = new FileStream(@"D:\H8872\Demo7\TVOhjelmat.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeMultipleStream, ohjelmat);
            writeMultipleStream.Close();

            Stream openStream = new FileStream(@"D:\H8872\Demo7\TVOhjelmat.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            List<TVProgram> readTVPrograms = (List<TVProgram>)formatter.Deserialize(openStream);
            openStream.Close();

            Console.WriteLine("Programs:");
            foreach(TVProgram p in readTVPrograms)
            {
                Console.WriteLine(p.ToString());
            }

        }
    }
}
