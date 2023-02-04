using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList ListaNomes = new ArrayList();
        ArrayList ListaSenhas = new ArrayList();

        Console.WriteLine("Deseja fazer o pré cadastro (S ou N)?");
        var resposta = Console.ReadLine();
        if (resposta == "S")
        {
            var seguir = 1;
            var seguir2 = Cadastrar(seguir);
        }

            Console.Clear();
            Console.WriteLine("Insira o login:");
            var login = Console.ReadLine();
            if (ListaNomes.Contains(login))
            {
                var ListaNome = ListaNomes.ToArray();
                var index = Array.IndexOf(ListaNome, login);
                Console.WriteLine("Insira a senha:");
                var senha = Console.ReadLine();
                if (ListaSenhas.Contains(senha))
                {
                    Console.Clear();
                    Console.Write("LOGIN EFETUADO COM SUCESSO");
                }
            }

            else
                Console.Write("Usuário não cadastrado");
        

        int Cadastrar(int seguir)
        {

            Console.WriteLine("PRÉ CADASTRO");
            Console.WriteLine("Insira o nome do usuário:");
            var nome = Console.ReadLine();
            if (nome != null)
            {
                ListaNomes.Add(nome);
            }
            else
            {
                Console.WriteLine("Usuário não pode ter esse nome.");
                seguir = 0;
            }
            Console.WriteLine("Insira a senha do usuário (de 4 a 8 caracteres):");
            var senha = Console.ReadLine();
            if (senha != null || senha.Length > 4 || senha.Length < 8)
            {
                ListaSenhas.Add(nome);
                Console.WriteLine("Senha cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("A senha não pode ser cadastrada");
                seguir = 0;
            }
            return seguir;

        }
    }
}