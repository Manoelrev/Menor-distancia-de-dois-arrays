
## Menor-distancia-de-dois-arrays
Desafio da array pela Intelitrader

 
Desafio proprosto pela Empreasa Intelitrader onde o desafio é achar a menor distância entre dois números de dois arrays;


### O processo de comparação é feita por essa função

```csharp
int[] calculoDistancia(int valorUm, int ValorDois)
{
var cal = Math.Abs((valorUm < 0 || ValorDois < 0) ? Math.Abs(valorUm) + Math.Abs   (ValorDois) : valorUm - ValorDois);
return  resultado = (resultado[0] > cal) ? [cal, valorUm, ValorDois] : resultado;
}
```

### E depois é feita a verificação em todas as combinações

```csharp
    
// Compara Duas Array diferentes
calculoDistancia(arrayUm[x],arraysDois[y]);

// Compara a Array UM
calculoDistancia(arrayUm[x],arrayUm[y]);

// Compara a Array Dois
calculoDistancia(arraysDois[x],arraysDois[y]);

```

Esse codigo foi feito de Maneira a facilitar o entendimento e compreensão do codigo e pode ser baixado ou testado atraves do site:

[Link para o programa](https://dotnetfiddle.net/Kxgx8x)

