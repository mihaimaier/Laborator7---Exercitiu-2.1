using System;

namespace Laborator7___Exercitiu_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 7 - Exercitiu 2.1 Contul de Investii

            // Contul de investiții este un cont bancar care se comportă precum un cont de economii:

            // - Cu mențiunea că nu vor putea fi extrași bani decât în situația în care termenul extragerii a fost atins.

            // - Dacă se incearcă extragerea banilor înainte de termen, contul va afișa un mesaj corespunzător iar suma extrasă va fi 0.

            // - Contul de investiții va pune la dispoziție o modalitate prin care se va putea specifica dacă termenul de extragere a fost sau nu atins. 

            // - Creeați clasele, adăugați câteva instanțe in Main, testați și rulați programul.

            // Exemplu 1 - Termenul Nu a Fost Atins

            ContInvestii cont1 = new ContInvestii(1000, 2, 3);
            cont1.Print();
            cont1.Withdraw(200, 2, 3);

            Console.WriteLine();

            // Exemplu 2 - Termenul A Fost Atins

            ContInvestii cont2 = new ContInvestii(2500, 4, 2);
            cont2.Print();
            cont2.Withdraw(1000, 4, 2);

            Console.WriteLine();

            // Exemplus 3 - Termenul Este Egal

            ContInvestii cont3 = new ContInvestii(1000, 5, 5);
            cont3.Print();
            cont3.Withdraw(1000, 5, 5);



        }
    }
}
