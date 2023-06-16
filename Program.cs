using System;

class Program {
  public static void Main (string[] args) {
  
            
            Console.WriteLine("---- Exercício de Tabuada ----");
            PularLinha();
            

            int tabuada, contador = 0;

            Console.Write("Digite o número da tabuada..: ");
            tabuada = Convert.ToInt32(Console.ReadLine());
            PularLinha();

            Console.WriteLine($"Você escolheu a tabuada do {tabuada}");

            do
            {
                Console.Write($" {tabuada} x {contador} = ");
                Console.WriteLine(tabuada * contador);
                contador = contador + 1;
                
            }
            while(contador <=10);          
        }

        static void ResetarCor()
        {
            Console.ResetColor();
        }

        static void LimparTela()
        {
            Console.Clear();
        }

        static void PularLinha()
        {
            Console.WriteLine();
        }
}