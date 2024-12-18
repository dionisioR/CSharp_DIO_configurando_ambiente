using System;

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 1;
arrayInteiros[1] = 21;
arrayInteiros[2] = 321;


Console.WriteLine("------------------------");
Console.WriteLine(" Redimensionando o tamnho do array");
Console.WriteLine("------------------------");
// Redimensionando o tamanho do array
// Array.Resize(ref NomeDoArray, NovoTamanho);

// Dobrando o tamanho do array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine(arrayInteiros[0]);
Console.WriteLine(arrayInteiros[1]);
Console.WriteLine(arrayInteiros[2]);
Console.WriteLine("------------------------");
Console.WriteLine(" FOR");
Console.WriteLine("------------------------");


for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição nº {i} Valor: {arrayInteiros[i]}");
}

Console.WriteLine("------------------------");
Console.WriteLine("FOREACH");
Console.WriteLine("------------------------");
foreach (int valor in arrayInteiros){
    Console.WriteLine($"Valor: {valor}");
}

Console.WriteLine("------------------------");
int contadorForech = 0;
foreach (int valor in arrayInteiros){
       Console.WriteLine($"Posição nº {contadorForech} Valor: {valor}");
         contadorForech++;
}



Console.WriteLine("------------------------");
Console.WriteLine(" Copiando os dados de um array para outro");
Console.WriteLine("------------------------");

// Criando o array de destino
int[] arrayInteirosDestino = new int[arrayInteiros.Length * 2];
// Copiando os dados do array de origem para o array de destino
// Array.Copy(Origem, Destino, QuantidadeDeElementosACopiar);

// Copiando TODOS os dados do array de origem para o array de destino
Array.Copy(arrayInteiros, arrayInteirosDestino, arrayInteiros.Length);
foreach (var valor in arrayInteirosDestino)
{
    Console.WriteLine($"Valor: {valor}");
}


//--------------------------------------------------------------------------------
//--------------------------------------------------------------------------------
// LISTAS

Console.WriteLine("------------------------");
Console.WriteLine("CRIANDO UMA LISTA DE STRING");
Console.WriteLine("------------------------");

List<string> listaString = new List<string>();

// Adicionando elementos na lista
listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");
listaString.Add("ES");
listaString.Add("BA");
listaString.Add("TESTE");

// Tamanho da lista
Console.WriteLine($"Tamanho da lista: {listaString.Count}");

// Acessando um elemento da lista
Console.WriteLine(listaString[0]);
Console.WriteLine(listaString[1]);
Console.WriteLine(listaString[2]);
Console.WriteLine("------------------------");
// Percorrendo a lista
foreach (var valor in listaString)
{
    Console.WriteLine($"Valor: {valor}");
}

// REMOVENDO ELEMENTOS DA LISTA
listaString.Remove("TESTE");
Console.WriteLine("------------------------");
for (var i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição nº {i} Valor: {listaString[i]}"); 
}