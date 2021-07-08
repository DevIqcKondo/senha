using System;
using Figgle;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha="1234abcd";
            string senha2;

            Console.WriteLine("Temos uma mensagem para você! Para visualizá-la informe sua senha!");
            Console.Write("SENHA: ");
            senha2=Convert.ToString(Console.ReadLine());

            if(senha2 != senha ){
                Console.BackgroundColor=ConsoleColor.Red;
                Console.ForegroundColor=ConsoleColor.Black;
                Console.WriteLine("ACESSO NEGADO");
                Console.ResetColor();

            } else{
                string mensagem ="Você é incrível!";
                Console.BackgroundColor=ConsoleColor.Green;
                Console.ForegroundColor=ConsoleColor.Black;
                Console.WriteLine("ACESSO PERMITIDO!");
                Console.ResetColor();

                Console.WriteLine("Agora tecle ENTER para exibir a mensagem!");
                Console.ReadKey();
                Console.WriteLine(FiggleFonts.Standard.Render(mensagem));
            }



            

        }
    }
}
