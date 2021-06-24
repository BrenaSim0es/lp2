using  System ;

namespace  Aula10
{
 classe  pública Retângulo : Figura 
{
     
     Retangulo público ( )
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
