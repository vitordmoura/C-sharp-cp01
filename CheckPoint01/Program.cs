namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("= CHECKPOINT 1 - FUNDAMENTOS C# - Turma 3ESPR ===\n");

        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica...");
        Console.WriteLine($"10 + 5 = {CalculadoraBasica(10, 5, '+')}");
        Console.WriteLine($"10 / 0 = {CalculadoraBasica(10, 0, '/')}");
        Console.WriteLine($"10 ? 5 = {CalculadoraBasica(10, 5, '?')}");

        Console.WriteLine("\n3. Testando ValidarIdade...");
        Console.WriteLine($"Idade 5: {ValidarIdade(5)}");
        Console.WriteLine($"Idade 15: {ValidarIdade(15)}");
        Console.WriteLine($"Idade 30: {ValidarIdade(30)}");
        Console.WriteLine($"Idade 70: {ValidarIdade(70)}");
        Console.WriteLine($"Idade -1: {ValidarIdade(-1)}");

        Console.WriteLine("\n4. Testando ConverterString...");
        Console.WriteLine(ConverterString("123", "int"));
        Console.WriteLine(ConverterString("3.14", "double"));
        Console.WriteLine(ConverterString("true", "bool"));
        Console.WriteLine(ConverterString("abc", "int"));

        Console.WriteLine("\n5. Testando ClassificarNota...");
        Console.WriteLine($"Nota 9.5: {ClassificarNota(9.5)}");
        Console.WriteLine($"Nota 8.0: {ClassificarNota(8.0)}");
        Console.WriteLine($"Nota 6.0: {ClassificarNota(6.0)}");
        Console.WriteLine($"Nota 3.0: {ClassificarNota(3.0)}");
        Console.WriteLine($"Nota 11.0: {ClassificarNota(11.0)}");

        Console.WriteLine("\n6. Testando GerarTabuada...");
        Console.WriteLine(GerarTabuada(5));
        Console.WriteLine(GerarTabuada(0));

        Console.WriteLine("\n7. Testando JogoAdivinhacao...");
        Console.WriteLine(JogoAdivinhacao(63, new int[] { 50, 75, 63 }));

        Console.WriteLine("\n8. Testando ValidarSenha...");
        Console.WriteLine(ValidarSenha("MinhaSenh@123"));
        Console.WriteLine(ValidarSenha("senha"));

        Console.WriteLine("\n9. Testando AnalisarNotas...");
        Console.WriteLine(AnalisarNotas(new double[] { 9.5, 8.0, 7.5, 6.0, 4.5 }));

        Console.WriteLine("\n10. Testando ProcessarVendas...");
        double[] vendas = { 1000, 500, 800 };
        string[] categorias = { "A", "B", "C" };
        double[] comissoes = { 0.10, 0.07, 0.05 };
        string[] nomesCategorias = { "A", "B", "C" };
        Console.WriteLine(ProcessarVendas(vendas, categorias, comissoes, nomesCategorias));

        Console.WriteLine("\n=== FIM DOS TESTES ===");
        Console.ReadKey();

    }
    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Complete o método para demonstrar diferentes tipos de dados
    /// - Declare uma variável de cada tipo primitivo (int, double, bool, char, string)
    /// - Use inferência de tipos (var) onde apropriado
    /// - Retorne uma string concatenando todos os valores
    /// </summary>
    private static string DemonstrarTiposDados()
    {
        int numeroInteiro = 42;
        var numeroDecimal = 3.14;
        var booleano = true;
        char caractere = 'A';
        var texto = "Olá";

        return $"Inteiro: {numeroInteiro}, Decimal: {numeroDecimal}, Booleano: {booleano}, Caractere: {caractere}, Texto: {texto}";
    }

    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Implemente uma calculadora básica usando SWITCH
    /// - Receba dois números e um operador (+, -, *, /)
    /// - Use SWITCH para selecionar a operação
    /// - Trate divisão por zero retornando 0
    /// - Para operadores inválidos, retorne -1
    /// </summary>
    /// 
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {

        switch (operador)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num2 != 0 ? num1 / num2 : 0;
            default: return -1;
        }
    }
    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================

    /// <summary>
    /// TODO: Valide se uma idade é válida para diferentes contextos usando IF/ELSE
    /// - Use IF/ELSE encadeados (não switch)
    /// - Retorna "Criança" se idade < 12
    /// - Retorna "Adolescente" se idade >= 12 e < 18  
    /// - Retorna "Adulto" se idade >= 18 e <= 65
    /// - Retorna "Idoso" se idade > 65
    /// - Retorna "Idade inválida" se idade < 0 ou > 120
    /// Use operadores relacionais e lógicos
    /// </summary>
    private static string ValidarIdade(int idade)
    {
        if (idade < 0 || idade > 120)
            return "Idade invalida";
        else if (idade < 12)
            return "Crianca";
        else if (idade < 18)
            return "Adolescente";
        else if (idade <= 65)
            return "Adulto";
        else
            return "Idoso";
    }
    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Converta uma string para diferentes tipos
    /// - Tente converter 'valor' para int, double e bool
    /// - Se a conversão for bem-sucedida, retorne "Tipo: Valor convertido"
    /// - Se falhar, retorne "Conversão impossível para [tipo]"
    /// - Use TryParse para conversões seguras
    /// </summary>
    private static string ConverterString(string valor, string tipoDesejado)
    {
        switch (tipoDesejado.ToLower())
        {
            case "int":
                if (int.TryParse(valor, out int resultadoInt))
                    return $"int: {resultadoInt}";
                else
                    return "Conversao impossivel para int";

            case "double":
                if (double.TryParse(valor, out double resultadoDouble))
                    return $"double: {resultadoDouble}";
                else
                    return "Conversao impossivel para double";

            case "bool":
                if (bool.TryParse(valor, out bool resultadoBool))
                    return $"bool: {resultadoBool}";
                else
                    return "Conversao impossivel para bool";

            default:
                return "Tipo desconhecido";
        }
    }
    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Classifique uma nota usando switch expression (C# 8+) ou switch tradicional
    /// - 9.0 a 10.0: "Excelente"
    /// - 7.0 a 8.9: "Bom" 
    /// - 5.0 a 6.9: "Regular"
    /// - 0.0 a 4.9: "Insuficiente"
    /// - Fora da faixa: "Nota inválida"
    /// </summary>
    private static string ClassificarNota(double nota)
    {
        switch (nota)
        {
            case >= 9.0 and <= 10.0:
                return "Excelente";
            case >= 7.0 and < 9.0:
                return "Bom";
            case >= 5.0 and < 7.0:
                return "Regular";
            case >= 0.0 and < 5.0:
                return "Insuficiente";
            default:
                return "Nota invalida";
        }
    }
    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOR
    /// Gere a tabuada de um número de 1 a 10
    /// - Use FOR para iterar de 1 a 10
    /// - Retorne string formatada: "2 x 1 = 2\n2 x 2 = 4\n..." 
    /// - Se número for <= 0, retorne "Número inválido"
    /// </summary>
    private static string GerarTabuada(int numero)
    {
        if (numero <= 0)
            return "Numero invalido";

        string resultado = "";
        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}\n";
        }
        return resultado.TrimEnd();
    }
    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR WHILE
    /// Simule um jogo de adivinhar número com tentativas limitadas
    /// - numeroSecreto: número a ser adivinhado (1-100)
    /// - tentativas: array com os palpites do jogador
    /// - Use WHILE para percorrer as tentativas
    /// - Para cada tentativa: "Tentativa X: muito alto/baixo/correto"
    /// - Pare no acerto ou quando acabar as tentativas
    /// - Retorne string com histórico completo
    /// </summary>
    private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
    {
        string resultado = "";
        int i = 0;
        while (i < tentativas.Length)
        {
            int tentativa = tentativas[i];
            string resposta;

            if (tentativa == numeroSecreto)
            {
                resposta = "correto!";
                resultado += $"Tentativa {i + 1}: {tentativa} - {resposta}\n";
                break;
            }
            else if (tentativa < numeroSecreto)
            {
                resposta = "muito baixo";
            }
            else
            {
                resposta = "muito alto";
            }

            resultado += $"Tentativa {i + 1}: {tentativa} - {resposta}\n";
            i++;
        }

        return resultado.TrimEnd();
    }
    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR DO-WHILE
    /// Valide uma senha seguindo critérios de segurança
    /// - A senha deve ter pelo menos 8 caracteres
    /// - Deve ter pelo menos 1 número
    /// - Deve ter pelo menos 1 letra maiúscula  
    /// - Deve ter pelo menos 1 caractere especial (!@#$%&*)
    /// - Use DO-WHILE para verificar cada critério
    /// - Retorne string explicando quais critérios não foram atendidos
    /// - Se senha válida, retorne "Senha válida"
    /// </summary>
    private static string ValidarSenha(string senha)
    {
        bool valido;
        string resultado = "";

        do
        {
            valido = true;
            if (senha.Length < 8)
            {
                resultado += "!!Mínimo de 8 caracteres\n";
                valido = false;
            }

            if (!senha.Any(char.IsDigit))
            {
                resultado += "!!Deve conter pelo menos 1 número\n";
                valido = false;
            }

            if (!senha.Any(char.IsUpper))
            {
                resultado += "!!Deve conter pelo menos 1 letra maiúscula\n";
                valido = false;
            }

            if (!senha.Any(c => "!@#$%&*".Contains(c)))
            {
                resultado += "Deve conter pelo menos 1 caractere especial (!@#$%&*)\n";
                valido = false;
            }

        } while (false);

        return valido ? "Senha válida" : resultado.TrimEnd();
    }
    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH
    /// Analise um array de notas de alunos
    /// - Use FOREACH para percorrer todas as notas
    /// - Calcule: média, quantidade de aprovados (>=7), maior nota, menor nota
    /// - Conte quantas notas estão em cada faixa: A(9-10), B(8-8.9), C(7-7.9), D(5-6.9), F(<5)
    /// - Retorne string formatada com todas as estatísticas
    /// - Se array vazio/null: "Nenhuma nota para analisar"
    /// </summary>
    private static string AnalisarNotas(double[] notas)
    {
        if (notas == null || notas.Length == 0)
            return "Nenhuma nota para analisar";

        double soma = 0, maior = double.MinValue, menor = double.MaxValue;
        int aprovados = 0, faixaA = 0, faixaB = 0, faixaC = 0, faixaD = 0, faixaF = 0;

        foreach (double nota in notas)
        {
            soma += nota;
            if (nota >= 7) aprovados++;
            if (nota > maior) maior = nota;
            if (nota < menor) menor = nota;

            if (nota >= 9) faixaA++;
            else if (nota >= 8) faixaB++;
            else if (nota >= 7) faixaC++;
            else if (nota >= 5) faixaD++;
            else faixaF++;
        }

        double media = soma / notas.Length;

        return $"Média: {media:F1}\nAprovados: {aprovados}\nMaior: {maior:F1}\nMenor: {menor:F1}\n" +
            $"A: {faixaA}, B: {faixaB}, C: {faixaC}, D: {faixaD}, F: {faixaF}";
    }
    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH (múltiplos)
    /// Processe vendas por categoria e calcule comissões
    /// - vendas: array com valores de vendas
    /// - categorias: array com categorias correspondentes ("A", "B", "C")
    /// - comissoes: array com percentuais de comissão por categoria (ex: A=10%, B=7%, C=5%)
    /// - Use FOREACH para percorrer vendas e categorias simultaneamente
    /// - Use FOREACH separado para encontrar a comissão da categoria
    /// - Calcule total de vendas e total de comissões por categoria
    /// - Retorne string com relatório detalhado
    /// </summary>
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        var totaisPorCategoria = new Dictionary<string, double>();
        var comissoesPorCategoria = new Dictionary<string, double>();

        for (int i = 0; i < vendas.Length; i++)
        {
            string categoria = categorias[i];
            double valorVenda = vendas[i];

            if (!totaisPorCategoria.ContainsKey(categoria))
                totaisPorCategoria[categoria] = 0;

            totaisPorCategoria[categoria] += valorVenda;
        }

        foreach (var categoria in totaisPorCategoria.Keys)
        {
            int index = Array.IndexOf(nomesCategorias, categoria);
            double percentual = index >= 0 ? comissoes[index] : 0;
            double totalVenda = totaisPorCategoria[categoria];
            double totalComissao = totalVenda * percentual;

            comissoesPorCategoria[categoria] = totalComissao;
        }

        string resultado = "";
        foreach (var categoria in totaisPorCategoria.Keys)
        {
            resultado += $"Categoria {categoria}: Vendas R$ {totaisPorCategoria[categoria]:F2}, Comissão R$ {comissoesPorCategoria[categoria]:F2}\n";
        }

        return resultado.TrimEnd();
    }
}
        


