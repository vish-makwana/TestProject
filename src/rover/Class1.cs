using System;

namespace rover
{
    public class Class1
    {

        public static string  movement(int x,int y,int px,int py,string dir,string cmd)
		{
           for (var i = 0; i < cmd.Length; i++)
            {
                if (cmd[i] == 'M')
                {
                    if (dir == "N")
                        py++;
                    if (dir == "S")
                        py--;
                    if (dir == "E")
                        px++;
                    if (dir == "W")
                        px--;
                }
                if (cmd[i] == 'L')
                {
                    if (dir == "N")
                        dir = "W";
                    else if (dir == "S")
                        dir = "E";
                    else if (dir == "E")
                        dir = "N";
                    else if (dir == "W")
                        dir = "S";
                }
                if (cmd[i] == 'R')
                {
                    if (dir == "N")
                        dir = "E";
                    else if (dir == "S")
                        dir = "W";
                    else if (dir == "E")
                        dir = "S";
                    else if (dir == "W")
                        dir = "N";
                }
            }
			return px+" "+py+" "+dir;
        }

        public static void Main(string[] args)
        {
            string cordinate = Console.ReadLine();
            int x = Convert.ToInt32(cordinate.Split(' ')[0]);
            int y = Convert.ToInt32(cordinate.Split(' ')[1]);

            string pos1 = Console.ReadLine();
            int p1x = Convert.ToInt32(pos1.Split(' ')[0]);
            int p1y = Convert.ToInt32(pos1.Split(' ')[1]);
            string dir1 = pos1.Split(' ')[2]+"";
            string cmd1 = Console.ReadLine();

            string pos2 = Console.ReadLine();
            int p2x = Convert.ToInt32(pos2.Split(' ')[0]);
            int p2y = Convert.ToInt32(pos2.Split(' ')[1]);
            string dir2 = pos2.Split(' ')[2]+"";
            string cmd2 = Console.ReadLine();
			
			Console.WriteLine(movement(x,y,p1x,p1y,dir1,cmd1));
			Console.WriteLine(movement(x,y,p2x,p2y,dir2,cmd2));
            
            Console.ReadKey();
        }
    }
}
