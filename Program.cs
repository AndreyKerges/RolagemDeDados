// Declaração das variáveis faces e rol
int faces, rol;

// Define a cor do texto para ciano e exibe a mensagem "ROLAGEM DE DADOS" na tela
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("---ROLAGEM DE DADOS---");
Console.ResetColor(); // Restaura a cor padrão do texto

// Define a cor do texto para azul escuro e exibe a mensagem "Quantas Faces?" na tela
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Quantas Faces? ");
Console.ResetColor(); // Restaura a cor padrão do texto

// Define a cor do texto para verde e lê o número de faces informado pelo usuário
faces = Convert.ToInt32(Console.ReadLine());
Console.ResetColor(); // Restaura a cor padrão do texto

// Cria uma instância da classe Random e gera um número aleatório entre 1 e o número de faces
Random rand = new Random();
rol = rand.Next(1, faces + 1);

// Define a cor do texto para amarelo e exibe o resultado da rolagem na tela
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Rolagem {rol}");
Console.ResetColor(); // Restaura a cor padrão do texto
