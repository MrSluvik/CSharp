using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Linq;

namespace Structure_Classes_Properties
{
    partial class Program
    {
        static void Main6()
        {
            int k = Ukraine.Kyiv.population;
            int t = Japan.Tokio.population;
            int w = USA.Washington.population;
            int[] pop = { k, t, w };
            if (pop.Max() == Ukraine.Kyiv.population)
            {
                WriteLine($"Найбільше населення має Київ {k} людей ");
            }
            else if (pop.Max() == Japan.Tokio.population)
            {
                WriteLine($"Найбільше населення має Токіо {t} людей ");
            }
            else
            {
                WriteLine($"Найбільше населення має Вашингтон {w} людей ");
            }

            if (pop.Min() == Ukraine.Kyiv.population)
            {
                WriteLine($"Найменше населення має Київ {k} людей ");
            }
            else if (pop.Min() == Japan.Tokio.population)
            {
                WriteLine($"Найменше населення має Токіо {t} людей ");
            }
            else
            {
                WriteLine($"Найменше  населення має Вашингтон {w} людей ");
            }

            if (pop.Min() != Ukraine.Kyiv.population && pop.Max() != Ukraine.Kyiv.population)
            {
                WriteLine($"Cереднє населення по кількості має Київ{k} людей ");
            }
            else if (pop.Min() != Japan.Tokio.population && pop.Max() != Japan.Tokio.population)
            {
                WriteLine($"Cереднє населення по кількості має Токіо{t} людей ");
            }
            else
            {
                WriteLine($"Cереднє населення по кількості має Вашингтон {w} людей ");
            }

        }
    }

