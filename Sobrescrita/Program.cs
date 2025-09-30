
using System.Globalization;

Console.WriteLine("Hello, Word!");

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Cartao cartaobase = new Cartao();
cartaobase.Debitar(100);

Console.WriteLine("-- Cartao de debito --");

Cartao cartaoDebito = new CartaoDebito();
cartaoDebito.Debitar(100);
