using System;

namespace SkyNetPatternSwitch
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                1 => "I'm fine, thank you!",
                break;
                2 => "Skynet",
                break;   
                3 => "Destroy mankind!";
                break;
                _ => "You got me, I'm not THAT smart!";
                return;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}