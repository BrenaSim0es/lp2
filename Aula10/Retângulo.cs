using  System ;

namespace  Aula10
{
 classe  pública Retângulo : Figura 
{
     _raio duplo  privado ; // atributo
    público duplo Raio // propriedade
    {
        // leitura do atributo correspondente
        obter
        {
            return this._raio;
        }
        
        // escrita do atributo correspondente
        definir
        {
            if (valor <= 0)
            {
                Console.WriteLine ("Raio inválido");
            }
            senão
            {
                isso . _raio  =  valor ;
                isso . AtualizarArea ();
                isso . AtualizarPerimetro ();
            }
        }
    }
     Circulo público ( raio duplo  )
    {
        // escrita utilizando método set da propriedade
        isso . Raio  =  raio ;
    }
    private  void  AtualizarArea ()
    {
        isso . _area  =  matemática . PI  *  isso . _raio  *  isso . _raio ;
    }
    private  void  AtualizarPerimetro ()
    {
        isso . _perimetro  =  2  *  Matemática . PI  *  isso . _raio ;
    }
}
}
