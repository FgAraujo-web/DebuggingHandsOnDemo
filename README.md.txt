
# HANDS-ON #02 | Debugging em C# no Visual Studio 2026

**Ponto de Conhecimento Tecnológico**

Explorar · Experimentar · Aprender · Partilhar

## Objetivo

Demonstrar a utilização das ferramentas de debugging do Visual Studio 2026 numa aplicação Console em C# e .NET 10.

O exercício apresenta um erro lógico no cálculo de descontos e mostra como identificar a sua origem, acompanhar a execução e validar a correção.

## Tecnologias

- C#
- .NET 10
- Visual Studio 2026
- Git e GitHub

## Cenário prático

Uma aplicação calcula o valor final de uma encomenda:

- Preço unitário: 50 €
- Quantidade: 3
- Desconto: 10%

O resultado esperado é:

| Indicador | Valor |
|---|---:|
| Subtotal | 150,00 € |
| Desconto | 15,00 € |
| Total | 135,00 € |

## Erro lógico identificado

A implementação inicial utilizava:

```csharp
return subtotal * percentagem / 10m;
```

O código compilava normalmente, mas calculava um desconto de 150 €, produzindo um total de 0 €.

## Ferramentas de debugging utilizadas

| Ferramenta | Finalidade |
|---|---|
| Breakpoint | Suspender a execução numa instrução |
| Watch | Inspecionar variáveis e avaliar expressões |
| Locals | Consultar automaticamente as variáveis locais |
| Step Into (F11) | Entrar num método |
| Step Over (F10) | Executar a instrução atual sem entrar nos métodos chamados |
| Step Out (Shift + F11) | Executar até regressar ao método chamador |
| Call Stack | Consultar a sequência de chamadas de métodos |

## Correção

A expressão foi corrigida para:

```csharp
return subtotal * percentagem / 100m;
```

Resultado validado:

```text
Subtotal: 150,00 €
Desconto: 15,00 €
Total: 135,00 €
```

## Conclusão

O debugging permite investigar o comportamento de uma aplicação durante a execução, identificar a origem de erros lógicos e validar as correções.

Este exercício demonstra que uma aplicação pode compilar e executar sem exceções e, ainda assim, apresentar resultados funcionalmente incorretos.

---

**Ponto de Conhecimento Tecnológico**

HANDS-ON #02 — Debugging em C# no Visual Studio 2026
