using System;
using System.Text;

namespace knight_s_move
{
    class Program
    {
        public static string Pereresovka(string[][] matricha, int xnew, int ynew, int startx, int starty, string figura)
        {
            string newMatricha= ($" +----+----+----+----+----+----+----+----+\n8| {matricha[0][7]} | {matricha[1][7]} | {matricha[2][7]} | {matricha[3][7]} | {matricha[4][7]} | {matricha[5][7]} | {matricha[6][7]} | {matricha[7][7]} |\n +----+----+----+----+----+----+----+----+\n7| {matricha[0][6]} | {matricha[1][6]} | {matricha[2][6]} | {matricha[3][6]} | {matricha[4][6]} | {matricha[5][6]} | {matricha[6][6]} | {matricha[7][6]} |\n +----+----+----+----+----+----+----+----+\n6| {matricha[0][5]} | {matricha[1][5]} | {matricha[2][5]} | {matricha[3][5]} | {matricha[4][5]} | {matricha[5][5]} | {matricha[6][5]} | {matricha[7][5]} |\n +----+----+----+----+----+----+----+----+\n5| {matricha[0][4]} | {matricha[1][4]} | {matricha[2][4]} | {matricha[3][4]} | {matricha[4][4]} | {matricha[5][4]} | {matricha[6][4]} | {matricha[7][4]} |\n +----+----+----+----+----+----+----+----+\n4| {matricha[0][3]} | {matricha[1][3]} | {matricha[2][3]} | {matricha[3][3]} | {matricha[4][3]} | {matricha[5][3]} | {matricha[6][3]} | {matricha[7][3]} |\n +----+----+----+----+----+----+----+----+\n3| {matricha[0][2]} | {matricha[1][2]} | {matricha[2][2]} | {matricha[3][2]} | {matricha[4][2]} | {matricha[5][2]} | {matricha[6][2]} | {matricha[7][2]} |\n +----+----+----+----+----+----+----+----+\n2| {matricha[0][1]} | {matricha[1][1]} | {matricha[2][1]} | {matricha[3][1]} | {matricha[4][1]} | {matricha[5][1]} | {matricha[6][1]} | {matricha[7][1]} |\n +----+----+----+----+----+----+----+----+\n1| {matricha[0][0]} | {matricha[1][0]} | {matricha[2][0]} | {matricha[3][0]} | {matricha[4][0]} | {matricha[5][0]} | {matricha[6][0]} | {matricha[7][0]} |\n +----+----+----+----+----+----+----+----+\n    A    B    C    D    E    F    G    H");
     
            return newMatricha;
        }
        public static bool Rook(int xnew, int ynew, int startx, int starty, string[][]matricha)
        {
            bool mojnoshoditb=false;
            if (startx == xnew)
            {
                mojnoshoditb = true;

                if (starty > ynew)
                {
                    for (int o = starty - 1; o > ynew; o--)
                    {
                        if (matricha[startx][o] != "  ")
                            mojnoshoditb = false;
                    }
                }
                if (starty < ynew)
                {
                    for (int o = starty - 1; o > ynew; o--)
                    {
                        if (matricha[startx][o] != "  ")
                            mojnoshoditb = false;
                    }
                }
            }
            if (starty == ynew)
            {
                mojnoshoditb = true;
                if(startx > xnew)
                {
                    for (int o = startx - 1; o > xnew; o--)
                    {
                        if (matricha[o][starty] != "  ")
                            mojnoshoditb = false;
                    }
                }
                if(startx < xnew)
                {
                    for (int o = startx + 1; o < xnew; o++)
                    {
                        if (matricha[o][starty] != "  ")
                            mojnoshoditb = false;
                    }
                }
                

            }
            return mojnoshoditb;
        }
        public static bool Peshka(int xnew, int ynew,int startx,int starty,string figura)
        {
            bool mojnoshoditb = false;
            
            if ((startx == xnew && starty == 1 && startx == Convert.ToInt32(figura.Substring(1, 1)) - 1 && starty + 2 == ynew) || startx == xnew && starty + 1 == ynew)
            {
                mojnoshoditb = true;

            }
            return mojnoshoditb;
        }
        public static bool Horse(int xnew, int ynew, int startx, int starty)
        {
            bool mojnoshoditb = false;

            if ((starty + 2 == ynew && (startx + 1 == xnew || startx - 1 == xnew)) || (starty - 2 == ynew && (startx + 1 == xnew || startx - 1 == xnew)) || (startx + 2 == xnew && (starty + 1 == ynew || starty - 1 == ynew)) || (startx - 2 == xnew && (starty + 1 == ynew || starty - 1 == ynew)))
            {
                 mojnoshoditb = true;
            }
            return  mojnoshoditb ;
        }
        public static bool King(int xnew, int ynew, int startx, int starty)
        {
            bool mojnoshoditb = false;

            if ((xnew == startx + 1 && ynew == starty) || (xnew == startx - 1 && ynew == starty) || (ynew == starty + 1 && xnew == startx) || (ynew == starty - 1 && xnew == startx))
            {
                mojnoshoditb = true;
            }
            return mojnoshoditb;
        }
        public static bool Elephant(int xnew, int ynew, int startx, int starty,string[][] matricha)
        {
            bool mojnoshoditb = false;

            if (Math.Abs(xnew - startx) == Math.Abs(ynew - starty))
            {
                mojnoshoditb = true;
                int j = starty;
                if(xnew>startx)
                {
                    if(ynew > starty)
                        for (int i = startx+1; i < xnew; i++)
                        {
                            j++;

                            if (matricha[i][j] != "  ")
                                mojnoshoditb = false;
                        }
                    if (ynew < starty)
                        for (int i = startx + 1; i < xnew; i++)
                        {                            
                            j--;

                            if (matricha[i][j] != "  ")
                                mojnoshoditb = false;
                        }
                }
                if(xnew<startx)
                {
                    

                    if (ynew > starty)
                    {
                        
                        for (int i = startx - 1; i > xnew; i--)
                        {
                            j++;

                            if (matricha[i][j] != "  ")
                                mojnoshoditb = false;
                        }
                    }
                        
                    if (ynew < starty)
                        for (int i = startx - 1; i > xnew; i--)
                        {                            
                            j--;

                            if (matricha[i][j] != "  ")
                                mojnoshoditb = false;
                        }
                }
            }
            return mojnoshoditb;
        }
        public static bool Queen(int xnew, int ynew, int startx, int starty, string[][] matricha)
        {
            bool mojnoshoditb = false;
            if (xnew == startx || ynew == starty)
                mojnoshoditb = Rook(xnew, ynew, startx, starty, matricha);
            if (Math.Abs(xnew - startx) == Math.Abs(ynew - starty))
                mojnoshoditb = Elephant(xnew, ynew, startx, starty, matricha);
                return mojnoshoditb;
        }

        static void Main(string[] args)
        {           

            bool win = false, peredfiguroi = false;
            int xnew=0, ynew=0, startx = 0, starty = 0, numbFiguraX=0, numbFiguraY=0;
            string figura="", steep,visual;

            string[][] figuraLife = new string[2][];
            figuraLife[0] = new string[8];
            figuraLife[1] = new string[8];

            string[][] matricha = new string[8][];
            for (int z = 0; z < 8; z++)
            {
                matricha[z] = new string[8];
            }                                   
                      
            matricha[0][0] = $"R{1}";
            matricha[7][0] = $"R{2}";
            matricha[1][0] = $"H{1}";
            matricha[6][0] = $"H{2}";
            matricha[2][0] = $"E{1}";
            matricha[5][0] = $"E{2}";
            matricha[3][0] = "Ki";
            matricha[4][0] = "Qu";           
            
            for (int i=0; i<8;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    figuraLife[j][i] = $"{j},{i}";
                }
            }
            
            for (int i=0; i < 8; i++)
            {
                matricha[i][1] = $"P{i + 1}";
                
                for (int j = 2; j < 8; j++)
                {
                    if(j==6)
                        matricha[i][j] = "P ";
                    
                    else
                        matricha[i][j] = "  ";
                    if(j==7)
                    {
                        if (i == 0 || i == 7)
                            matricha[i][j] = "R ";
                        if (i == 1 || i == 6)
                            matricha[i][j] = "H ";
                        if (i == 2 || i == 5)
                            matricha[i][j] = "E ";
                        if (i == 3)
                            matricha[i][j] = "Q ";
                        if (i == 4)
                            matricha[i][j] = "K ";

                    }

                }
                    
            }
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Шахматы");
            Console.WriteLine("Хотите узнать правила? \n Нажмите 1 если хотите , любой другой символ если нет");
            ConsoleKeyInfo userinput = Console.ReadKey(true);
            sb.Append(userinput.KeyChar);
            if(Convert.ToString(sb)=="1")
            {
                Console.WriteLine("Конь ходит буквой Г\nФерзь ходит по вертекали , диагонали и горизонтали с любой длинной шага\nПешка ходит в первый ход макимум на 2 шага вперед в последующих на 1\nЛадья ходит по вертикали и горизонтали на любую длину шага\nКороль ходит по вертикали,диагонали и горизонтали на 1 шаг\nСлон ходит по диагонали на любую длину шагу\nИграть ведеться пока не будет срубленный вражеский король");
                Console.ReadKey();
            }
            
            while(!win)
            {
                Console.Clear();
                visual = Pereresovka(matricha, xnew, ynew,startx,starty,figura);
                Console.WriteLine(visual);
                Console.WriteLine("\nВыберите фигуру");

                figura = Console.ReadLine().Trim().ToLower();

                if (figura != "r1" && figura != "r2" && figura != "h1" && figura != "h2" && figura != "e1" && figura != "e2" && figura != "ki" && figura != "qu" && figura != "p1" && figura != "p2" && figura != "p3" && figura != "p4" && figura != "p5" && figura != "p6" && figura != "p7" && figura != "p8")
                {
                    Console.WriteLine("Такой фигуры нету");
                    Console.ReadKey();
                }
                    
                
                else
                {
                    Console.WriteLine("Введите координаты хода ");

                    bool converti = false;
                    steep = Console.ReadLine().ToLower().Trim();

                    if (steep[0] >= 'a' && steep[0] <= 'h')
                        converti = true;
                    bool converti2 = Int32.TryParse(steep.Substring(1, 1), out ynew);
                    if (Convert.ToInt32(steep.Substring(1, 1)) >= 0 && Convert.ToInt32(steep.Substring(1, 1)) <= 7)
                        converti2 = true;
                    if (converti && converti2)
                    {
                        xnew = Convert.ToInt32( steep[0]-'a');
                        ynew = Convert.ToInt32(steep.Substring(1, 1))-1;
                        numbFiguraX = 0;
                        switch (figura)
                        { 
                            case "r1":
                            case "r2":

                                if (figura.Substring(1, 1) == "2")
                                    numbFiguraY = 7;
                                else
                                    numbFiguraY = 0;

                                startx = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(2, 1));
                                starty = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(0, 1));

                               peredfiguroi= Rook(xnew, ynew,startx,starty,matricha);
                                break;

                            case "h1": 
                            case "h2":

                                if (figura.Substring(1, 1) == "2")
                                    numbFiguraY = 6;
                                else
                                    numbFiguraY = 1;

                                startx = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(2, 1));
                                starty = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(0, 1));

                                peredfiguroi= Horse(xnew, ynew,startx,starty);
                                break;

                            case "e1": 
                            case "e2":

                                if (figura.Substring(1, 1) == "2")
                                    numbFiguraY = 5;
                                else
                                    numbFiguraY = 2;

                                startx = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(2, 1));
                                starty = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(0, 1));

                                peredfiguroi = Elephant(xnew, ynew, startx, starty, matricha);
                                break;

                            case "ki":

                                numbFiguraY = 3;

                                startx = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(2, 1));
                                starty = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(0, 1));

                                peredfiguroi = King(xnew, ynew,startx,starty);
                                break;

                            case "qu":

                                numbFiguraY = 4;

                                startx = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(2, 1));
                                starty = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(0, 1));

                                peredfiguroi = Queen(xnew, ynew, startx, starty, matricha);
                                break;
                            default:

                                numbFiguraX = 1;

                                numbFiguraY = Convert.ToInt32(figura.Substring(1, 1)) - 1;

                                startx = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(2, 1));
                                starty = Convert.ToInt32(figuraLife[numbFiguraX][numbFiguraY].Substring(0, 1));

                                peredfiguroi=Peshka(xnew, ynew,startx,starty,figura);
                                break;

                        }

                        if (peredfiguroi)
                        {
                            switch (matricha[xnew][ynew])
                            {
                                case "  ":
                                case "P ":
                                case "R ":
                                case "H ":
                                case "Q ":
                                case "E ":

                                    matricha[xnew][ynew] = figura.ToUpper();
                                    matricha[startx][starty] = "  ";
                                    figuraLife[numbFiguraX][numbFiguraY] = $"{ynew},{xnew}";
                                    break;
                                case "K ":

                                    Console.WriteLine("Мат\nВы победили");

                                    win = true;
                                    break;
                                default:

                                    Console.WriteLine("Такой ход невозможен+");
                                    Console.ReadKey();
                                    break;
                            }
                            peredfiguroi = false;
                        }
                        else
                        {
                            Console.WriteLine("Такой ход невозмоен!");
                            Console.ReadKey();
                        }
                           
                    }
                    else
                    {
                        Console.WriteLine("Таких координат нету");
                        Console.ReadKey();
                    }
                        

                }
  

            }

        }
    }
}
