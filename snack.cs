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

//Oppure 
numInString.Sort((string s1, string s2) => -s1.CompareTo(s2));
foreach (string s in numInString)
    Console.WriteLine(s);

/*Esercizio Finale:
data una lista di coppie <string,int> stamparle ordinate rispetto alla stringa
una coppia si dichiara come Tuple<string, int> quindi una lista di coppie sarà */
List<Tuple<string, int>> lCoppie = new List<Tuple<string, int>>()
{
    new Tuple<string, int > ("uno", 1),
    new Tuple<string, int > ("due", 21),
    new Tuple<string, int > ("quattro", 41),
    new Tuple<string, int > ("sette", 71),
    new Tuple<string, int > ("diciannove", 191),
};

Console.WriteLine("\n\n\n\n\nLCOPPIE");
lCoppie.Sort();
lCoppie.ForEach(x => Console.WriteLine(x));

Console.WriteLine(string.Join("\t", lCoppie));

//Ok, allora ordiniamo per il secondo campo della tutpla (il numero intero)
lcoppie.Sort((t1, t2) => t1.Item2.CompareTo(t2.Item2));
Console.WriteLine(String.Join("\t", lcoppie));
lcoppie.Sort();
lcoppie.Sort((t1, t2) => t1.Item2 - t2.Item2);
Console.WriteLine(String.Join("\t", lcoppie));
List<Tuple<int, int, int>> lterne = new List<Tuple<int, int, int>>()
{
    new Tuple<int, int, int>(1, 2, 3),
    new Tuple<int, int, int>(5, 5, 2),
    new Tuple<int, int, int>(2, 4, 11),
    new Tuple<int, int, int>(12, 15, 21),
    new Tuple<int, int, int>(55, 45, 32),
    new Tuple<int, int, int>(1, 2, 4),
    new Tuple<int, int, int>(1, 3, 0),
    new Tuple<int, int, int>(5, 5, 1)
};
lterne.Sort();
Console.WriteLine(String.Join("\t", lterne));
//double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
//Console.WriteLine("microseconds: {0}", microseconds);
segno_spunta_bianco
occhi
mani_alzate





14:41
//Se volete verificare la velocità di una parte del codice
double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
Console.WriteLine("microseconds: {0}", microseconds);