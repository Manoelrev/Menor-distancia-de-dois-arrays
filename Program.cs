using System;
					
public class Program
{	
	static int[] MenorDistanciaArray(int[] arrayUm, int[] arraysDois)
	{
	  int[] resultado = [9999,0,0];

	  int[] calculoDistancia(int valorUm, int ValorDois)
	  {
		var cal = Math.Abs((valorUm < 0 || ValorDois < 0) ? Math.Abs(valorUm) + Math.Abs(ValorDois) : valorUm - ValorDois);
		return  resultado = (resultado[0] > cal) ? [cal, valorUm, ValorDois] : resultado;
	  }

	  for (int x = 0; x < arrayUm.Length; x++)
	  {
		for(int y = 0; y < arraysDois.Length; y++) 
		{
		  // Compara Duas Array diferentes
		  calculoDistancia(arrayUm[x],arraysDois[y]);
		  if(x != y)
		  {
			try
			{
			// Compara a Array UM
			calculoDistancia(arrayUm[x],arrayUm[y]);
			// Compara a Array Dois
			calculoDistancia(arraysDois[x],arraysDois[y]);
			}
			catch (Exception){}
		}}
	  }
		return [resultado[1], resultado[2]];
	}

	
	public static void Main()
	{
		int[] result = MenorDistanciaArray([-1, 5,7,56,89,8], [26, 6,16,78,45]);
		Console.WriteLine(result[0]+", "+result[1]);
	}
}