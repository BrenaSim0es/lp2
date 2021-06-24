using System;
using System.Collections.Generic;
using Aula14;

namespace Aula14
{
public class Compra
{
    private Dictionary<Produto, int> _itens;

    public Dictionary<Produto, int> Itens
    {
        get { return this._itens; }
    }

    public double Total
    {
        get
        {
            double somatorio = 0;
            // somatorio de valor total de cada item multiplicado pela quantidade de itens no carrinho
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
                somatorio += parOrdenado.Key.CalculaValorTotal() * parOrdenado.Value;

            return somatorio;
        }
    }

    public Compra()
    {
        this._itens = new Dictionary<Produto, int>();
    }
    
        public void ImprimirCompra()
    {
        Console.WriteLine("======== COMPRA ========");
        foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
        {
            parOrdenado.Key.Imprimir();
            Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
            Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalculaValorTotal());
            Console.WriteLine("==========================");
        }
        Console.WriteLine("Total do compra:\tR$ {0:0.00}", this.Total);
        Console.WriteLine("==========================");
    }
}
}
