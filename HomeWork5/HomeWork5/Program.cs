Japan.Tokio tokio = new Japan.Tokio(304512154);
Sweden.Stockholm stockholm = new Sweden.Stockholm(26541203);
Latvia.Riga riga = new Latvia.Riga(415665542);


Console.WriteLine("Choose first capital: \n1.Tokio\n2.Stockholm\n3.Riga");
int tmp1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose second capital: \n1.Tokio\n2.Stockholm\n3.Riga");
int tmp2 = Convert.ToInt32(Console.ReadLine());

if (tmp1 == 1)
{
    if (tmp2 == 1)
    {
        Console.WriteLine("You can't compare Tokyo to Tokyo.");
    }
    else if (tmp2 == 2)
    {
        if (tokio.tokioPopulation < stockholm.stockholmPopulation)
        {
            Console.WriteLine("The population of Tokyo is smaller than the population of Stockholm.");
        }
        else if (tokio.tokioPopulation > stockholm.stockholmPopulation)
        {
            Console.WriteLine("The population of Tokyo is larger than the population of Stockholm.");
        }
    }
    else if (tmp2 == 3)
    {
        if (tokio.tokioPopulation < riga.rigaPopulation)
        {
            Console.WriteLine("The population of Tokyo is smaller than the population of Riga.");
        }
        else if (tokio.tokioPopulation > riga.rigaPopulation)
        {
            Console.WriteLine("The population of Tokyo is larger than the population of Riga.");
        }
    }
}
else if (tmp1 == 2)
{
    if (tmp2 == 1)
    {
        if (tokio.tokioPopulation > stockholm.stockholmPopulation)
        {
            Console.WriteLine("The population of Stockholm is smaller than the population of Tokyo.");
        }
        else if (tokio.tokioPopulation < stockholm.stockholmPopulation)
        {
            Console.WriteLine("The population of Stockholm is larger than the population of Tokyo.");
        }
    }
    else if (tmp2 == 2)
    {
        Console.WriteLine("You can't compare Stockholm to Stockholm.");
    }
    else if (tmp2 == 3)
    {
        if (stockholm.stockholmPopulation < riga.rigaPopulation)
        {
            Console.WriteLine("The population of Stockholm is smaller than the population of Riga.");
        }
        else if (stockholm.stockholmPopulation > riga.rigaPopulation)
        {
            Console.WriteLine("The population of Stockholm is larger than the population of Riga.");
        }
    }
}
else if (tmp1 == 3)
{
    if (tmp2 == 1)
    {
        if (tokio.tokioPopulation > riga.rigaPopulation)
        {
            Console.WriteLine("The population of Riga is smaller than the population of Tokyo.");
        }
        else if (tokio.tokioPopulation < riga.rigaPopulation)
        {
            Console.WriteLine("The population of Riga is larger than the population of Tokyo.");
        }
    }
    else if (tmp2 == 2)
    {
        if (stockholm.stockholmPopulation > riga.rigaPopulation)
        {
            Console.WriteLine("The population of Riga is smaller than the population of Stockholm.");
        }
        else if (stockholm.stockholmPopulation < riga.rigaPopulation)
        {
            Console.WriteLine("The population of Riga is larger than the population of Stockholm.");
        }
    }
    else if (tmp2 == 3)
    {
        Console.WriteLine("You can't compare Riga to Riga.");

    }
}