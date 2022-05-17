var Accum = () =>
{
    long tot = 0;
    return (int n) =>
    {
        tot += n;
        return tot;
    };
};

var acc1 = Accum();
var acc2 = Accum();

Console.WriteLine("acc1(152): " + acc1(152));
Console.WriteLine("acc1(3): " + acc1(3));
Console.WriteLine("acc1(4): " + acc2(4));
Console.WriteLine("acc1(5): " + acc2(5));


// Data una lista di interi, restituirli tutti al quadrato

List<int> list = new List<int>() { 1, 2, 3, 4 };
List<int> listSquare = Squarer(list);
List<int> listCube = Cuber(list);

foreach (int n in listSquare)
    Console.WriteLine(n);


List<int> Squarer(List<int> list)
{
    List<int> listOutput = new List<int>();
    foreach (int i in list)
        listOutput.Add(i * i);

    return listOutput;
}


List<int> Cuber(List<int> list)
{
    List<int> listOutput = new List<int>();
    foreach (int i in list)
        listOutput.Add(i * i * i);

    return listOutput;
}

//Abbiamo in questo modo costruito una funzione "generale" per trasformare
//tutti gli elementi di una stringa da numero intero a numero intero => nuovo = f(vecchio);
//Purtroppo per come è stata costruita, questa funzione si applica esclusivamente alle lista di numeri interi 
//e torna una lista di numeri interi
//ordinare una lista di interi

list = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
list.Sort();
list.Reverse();  //se la volessi al contrario
foreach (int n in list)
    Console.WriteLine(n);
Console.WriteLine("\n\n\n\n");
list = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
list.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return -1;
    if (v1 == v2)
        return 0;
    else
        return 1;
});
foreach (int n in list)
    Console.WriteLine(n);
//crescente
Console.WriteLine("\n\n\n\n");
list = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
list.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return 1;
    if (v1 == v2)
        return 0;
    else
        return -1;
});
foreach (int n in list)
    Console.WriteLine(n);

//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "Sei"}
//ordinarla e stamparla in verso decrescente
List<string> listString = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "sei" };
listString.Sort();
listString.Reverse();
foreach (string n in listString)
    Console.WriteLine(n);