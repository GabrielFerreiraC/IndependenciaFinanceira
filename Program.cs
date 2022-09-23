decimal gastosMensais, valorAInvestir;
double dividendo;


Console.WriteLine("---Vivendo de Dividendos---\n");


Console.WriteLine("Vivendo de Dividendos ---\n");


Console.WriteLine("Gastos Mensais (em R$)...: ");
gastosMensais = Convert.ToDecimal (Console.ReadLine());

Console.WriteLine(" Rendimentos Mensais (%)...:");
dividendo = Convert.ToDouble(Console.ReadLine());

valorAInvestir = gastosMensais / Convert.ToDecimal(dividendo/100);


Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimentos {dividendo:N1}% você precisa ter investido {valorAInvestir:C}.");