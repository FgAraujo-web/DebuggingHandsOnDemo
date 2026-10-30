
using System;

Console.WriteLine("HANDS-ON #02 | Debugging em C#");
Console.WriteLine("Ponto de Conhecimento Tecnológico");
Console.WriteLine("----------------------------------");

decimal precoUnitario = 50m;
int quantidade = 3;
decimal percentagemDesconto = 10m;

decimal subtotal = CalcularSubtotal(precoUnitario, quantidade);
    decimal desconto = CalcularDesconto(subtotal, percentagemDesconto);
decimal total = subtotal - desconto;

Console.WriteLine($"Subtotal: {subtotal:F2} €");
Console.WriteLine($"Desconto: {desconto:F2} €");
Console.WriteLine($"Total: {total:F2} €");

static decimal CalcularSubtotal(decimal preco, int quantidade)
{
    return preco * quantidade;
}

static decimal CalcularDesconto(decimal subtotal, decimal percentagem)  
{

    // Cálculo correto do desconto percentual
    return subtotal * percentagem / 100m;
}
