using System;

namespace Aula10
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        Circulo circ1 = new Circulo(2.0);
        
        // acessando métodos get
        Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
        Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
        Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);

        // acessando método set
        // atualização automática
        // da área e perímetro
        circ1.Raio = 3.0;
        
        // acessando métodos get
        Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
        Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
        Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);

        // valor inválido no método set
        circ1.Raio = -3.0;
        
        // acessando métodos get
        Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
        Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
        Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);
    


        Retangulo  reta1  =  novo  Retângulo ( 2.0 );
        
        // acessando métodos get
        
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , reta1 . Área );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , reta1 . Perimetro );

        // acessando o conjunto de método
        // atualização automática
        // da área e perímetro
        
        
        // acessando métodos get
        
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , reta1 . Área );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , reta1 . Perimetro );

        // valor inválido sem conjunto de método
   
        
        // acessando métodos get
      
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , reta1 . Área );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , reta1 . Perimetro );
    }




       

}
}
