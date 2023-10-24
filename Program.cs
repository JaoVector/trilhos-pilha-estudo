using System;

class Program
{
    
    public static void Main(string[] args)
    {
        StreamWriter txt = new StreamWriter(@"C:\Users\T3637283\Documents\Linux_Material\ProjetosC#\1062_Trilhos\saida.txt");
        void Estacao(string line, int vagqtd)
        {
            int flagA = 1;
            int flagB = 1;
            int aux = 0;

            line = line.Replace(" ", String.Empty);
            int[] trem = new int[vagqtd];

            for(int i = 0; i < trem.Length; i++)
            {
                trem[i] = Convert.ToInt32(line[i]);
            }

            for(int i = 0; i < trem.Length; i++)
            {     
                if(i == 0)
                {
                    aux = trem[i];
                    
                } else 
                {
                    aux = trem[i - 1];
                    if(aux < trem[i])
                    {
                        flagA++;
                    } else 
                    {
                        flagB++;
                    }
                }
                
            }
            
            if(flagA == line.Length || flagB == line.Length)
            {
                txt.WriteLine("Yes");
            } else 
            {
                txt.WriteLine("No");
            }

        }
        
        int vagoes = 0;

        using var arquivo = new StreamReader(@"C:\Users\T3637283\Documents\Linux_Material\ProjetosC#\1062_Trilhos\entrada.txt");
        string? line;

        while((line = arquivo.ReadLine()) != null)
            if(line.ToString().Length == 1 && line != "0")
            {
                vagoes = Convert.ToInt32(line.ToString());
            } else if(line == "0") {
                txt.WriteLine("");
            }
            else {
                Estacao(line, vagoes);
            }

        arquivo.Close();
        txt.Close();

    }
}
