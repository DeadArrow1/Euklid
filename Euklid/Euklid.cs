public class EuklidAlgorithm
{
    public static int GCD(int a, int b)
    {

        int u = a;
        int w = b;
        int t;


        if (u < w)
        {
            t = u;

            u = w;
            w = t;
        }

        while (w != 0)
        {
            t = w;
            while (u - w >= 0)
            {
                u = u - w;
            }
            w = u;
            u = t;

        }
        return u;
    }

    public static int MultiplicativeInversion(int number, int module)
    {
        if (number <= 0 || module <= 0)
        {
            return 0; //input nejsou prirozena cisla      
        }

        if (number > module)
        {
            return 0; //number nemuze byt vetsi nez module
        }

        if (GCD(number, module) != 1)
        {
            return 0; //inverze neexistuje      
        }

        /*          
                               Pole CurrentState
                   
                    [0] [1]  [2]  [3]   [4]  [5]    [6]  [7]
                     a | b  | q  | r  | a2  | a1  | b2  | b1 
              
              Kde a,b jsou postupne redukovana cisla
              q je koeficient b pro rovnost
              r je zbytek potrebny pro rovnost
              a1,a2 jsou koeficienty pro a
              b1,b2 jsou koeficienty pro b
              b2 posledniho stavu je multiplikativni inverze pro b

        */

        int[] CurrentState = new int[] { module, number, 0, 0, 1, 0, 0, 1 };
        while (CurrentState[1] != 0)
        {
            int[] NewState = new int[8];
            
            int i = 1;
            
            while ((i + 1) * CurrentState[1] < CurrentState[0])
            {
                i++; //vypocet koeficientu q
            }

            NewState[2] = i; //dosazeni do q

            NewState[3] = CurrentState[0] - NewState[2] * CurrentState[1]; //vypocet noveho zbytku r

            NewState[4] = CurrentState[5]; //prenos hodnoty a2 do a1 noveho radku

            NewState[5] = CurrentState[4] - NewState[2] * CurrentState[5]; //vypocet hodnoty a1 noveho radku

            NewState[6] = CurrentState[7]; //prenos hodnoty b1 do b2 noveho radku

            NewState[7] = CurrentState[6] - NewState[2] * CurrentState[7]; // vypocet hodnoty b1 noveho radku

            NewState[0] = CurrentState[1]; //a noveho radku se rovna b naseho radku

            NewState[1] = NewState[3]; //b noveho radku se rovna r noveho radku

            CurrentState = NewState; //prejmeme novy radek za nas a postup opakujeme
        }
        if (CurrentState[6] < 0) CurrentState[6] += module;// pokud b2 vyjde v poslednim kroku zaporne, pricteme k nemu module
        
        return CurrentState[6]; // vracime multiplikativni inverzi

    }

}

