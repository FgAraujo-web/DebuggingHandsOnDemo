
# HANDS-ON #02 | Debugging em C# no Visual Studio 2026

**Ponto de Conhecimento Tecnológico (PCT)**  
*Explorar · Experimentar · Aprender · Partilhar*

## 📌 Objetivo

Demonstrar, através de um exemplo prático em C# e .NET 10, como utilizar as ferramentas de debugging do Visual Studio 2026 para identificar, analisar e corrigir erros lógicos numa aplicação.

O exercício simula um cálculo de descontos em que a aplicação compila e executa sem exceções, mas apresenta um resultado incorreto.

## 🛠️ Tecnologias utilizadas

- C#
- .NET 10
- Visual Studio 2026
- Git e GitHub

## 🧪 Cenário prático

Uma aplicação Console calcula o valor total de uma compra, considerando o preço unitário, a quantidade e uma percentagem de desconto.

| Parâmetro | Valor |
|---|---:|
| Preço unitário | 50,00 € |
| Quantidade | 3 |
| Desconto | 10% |
| Subtotal | 150,00 € |
| Desconto esperado | 15,00 € |
| Total esperado | 135,00 € |

## 🐞 Erro lógico identificado

Na implementação inicial, o método `CalcularDesconto` utilizava a seguinte expressão:

```csharp
return subtotal * percentagem / 10m;
```

Embora o código compilasse corretamente, o resultado obtido era:

```text
Subtotal: 150,00 €
Desconto: 150,00 €
Total: 0,00 €
```

O problema estava no divisor utilizado no cálculo percentual.

Este exemplo demonstra que **uma aplicação pode executar sem apresentar erros técnicos e, ainda assim, produzir resultados funcionalmente incorretos**.

## 🔍 Ferramentas de debugging exploradas

| Ferramenta | Finalidade |
|---|---|
| Breakpoint | Interromper a execução numa linha específica |
| Watch | Acompanhar variáveis e avaliar expressões |
| Locals | Inspecionar variáveis disponíveis no contexto atual |
| Step Into (F11) | Entrar na execução de um método |
| Step Over (F10) | Executar a instrução atual sem entrar nos métodos chamados |
| Step Out (Shift + F11) | Concluir a execução do método atual e regressar ao chamador |
| Call Stack | Analisar a sequência de chamadas de métodos |

Durante o exercício, foram observados os valores das variáveis e analisado o fluxo de execução até identificar a origem do resultado incorreto.

Também foi explorado o conceito de **âmbito das variáveis (scope)**, nomeadamente a indisponibilidade de determinadas expressões na janela Watch quando avaliadas fora do respetivo contexto.

## ✅ Correção implementada

O cálculo foi corrigido para:

```csharp
static decimal CalcularDesconto(decimal subtotal, decimal percentagem)
{
    return subtotal * percentagem / 100m;
}
```

Após a correção, a aplicação passou a apresentar:

```text
Subtotal: 150,00 €
Desconto: 15,00 €
Total: 135,00 €
```

O resultado foi validado através de uma nova execução da aplicação.

## 📘 Tutorial técnico ilustrado

O exercício foi documentado num tutorial técnico com capturas reais do Visual Studio 2026, explicações passo a passo e análise das ferramentas utilizadas.

**[Consultar o tutorial completo — HANDS-ON #02 (PDF)](DebuggingHandsOnDemo/docs/HANDS_ON_02_Debugging_CSharp_Visual_Studio_2026.pdf)**

O documento apresenta a identificação do erro, a investigação através do debugger, a correção e a validação final.

## 📂 Estrutura do projeto

```text
DebuggingHandsOnDemo/
├── DebuggingHandsOnDemo/
│   ├── Program.cs
│   ├── DebuggingHandsOnDemo.csproj
│   └── docs/
│       └── HANDS_ON_02_Debugging_CSharp_Visual_Studio_2026.pdf
└── README.md
```

A estrutura apresentada é uma representação simplificada dos principais ficheiros do projeto.

## ▶️ Como executar

1. Clonar ou descarregar o repositório.
2. Abrir a solução ou o projeto no Visual Studio 2026.
3. Confirmar que o SDK do .NET 10 está instalado.
4. Executar a aplicação com `Ctrl + F5`.
5. Para explorar o debugging, definir um breakpoint e iniciar a execução com `F5`.

**Nota:** o código disponibilizado no repositório contém a versão corrigida. Para reproduzir o erro original, substitua temporariamente `/ 100m` por `/ 10m` no método `CalcularDesconto`.

## 💡 Conclusão

O debugging não se limita à identificação de exceções ou falhas de execução.

É também uma ferramenta essencial para investigar comportamentos inesperados, compreender o fluxo de execução, verificar valores intermédios e validar regras de negócio.

Neste exercício, um pequeno erro numa fórmula produziu um resultado funcionalmente incorreto, apesar de a aplicação executar normalmente.

A utilização estruturada das ferramentas de debugging permitiu identificar a causa, corrigir a lógica e confirmar o resultado esperado.

---

**Ponto de Conhecimento Tecnológico**  
*Explorar · Experimentar · Aprender · Partilhar*

**Série:** HANDS-ON #02  
**Tema:** Debugging em C# no Visual Studio 2026
