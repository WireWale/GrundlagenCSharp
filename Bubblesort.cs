int x = 0;
int y = 1;
int sort = 0;
int[] alter = new int[5];
alter[0] = 20;
alter[1] = 50;
alter[2] = 40;
alter[3] = 10;
alter[4] = 30;

do
{
    x = 0;
    y = 1;
    sort = 0;
    for(int i = 0; i < 4; i++)
    {
        Console.WriteLine(alter[0] + " " + alter[1] + " " + alter[2] + " " + alter[3] + " " + alter[4]);
        if (alter[x] > alter[y])
        {
            int Zahl = alter[x];
            alter[x] = alter[y];
            alter[y] = Zahl;
            sort++;
        }
        x++;
        y++;
    }  
} while (sort > 0);