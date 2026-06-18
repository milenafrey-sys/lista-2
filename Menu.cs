public static class Menu
{
    public static void ExibirMenuPrincipal()
    {
        int opcao;
        do {
            Console.Clear();
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Verificação de idade para entrada em evento");
            Console.WriteLine("2 - Situação final do estudante");
            Console.WriteLine("3 - Classificação de temperatura ambiente");
            Console.WriteLine("4 - Cálculo de compra com desconto");
            

            opcao = int.Parse(Console.ReadLine()!);
            Console.Clear();

            if (opcao == 1) {
                AtividadesCondicionais.Atividade01();
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        } while (opcao != 0);
    }
}