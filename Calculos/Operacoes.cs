using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos;

public static class Operacoes
{
    public static Double Somar(Double numero1, double numero2)
    {
        return (numero1 + numero2);
    }

    public static Double Subtrair(Double numero1, double numero2)
    {
        return (numero1 - numero2);
    }

    public static Double Multiplicar(Double numero1, double numero2)
    {
        return (numero1 * numero2);
    }

    public static Double Dividir(Double numero1, double numero2)
    {
        return (numero1 / numero2);
    }

    public static bool eNumeroPar(int numero)
    {
        return numero % 2 == 0;
    }
}
