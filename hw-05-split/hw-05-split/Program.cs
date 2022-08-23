// See https://aka.ms/new-console-template for more information


uint cntIntItem = 0;
uint cntDoubletem = 0;
uint cntStringItem = 0;


foreach (var item in args)
{
	//Console.WriteLine(item);

	if (int.TryParse(item, out var valueI))
	{
		cntIntItem++;
		
	}
	else if (double.TryParse(item, out var valueD))
	{
		cntDoubletem++;
		
	}
	else
	{
		cntStringItem++;
		
	}
}


Console.WriteLine(cntIntItem);
Console.WriteLine(cntDoubletem);
Console.WriteLine(cntStringItem);