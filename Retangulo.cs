using System;
using System.Globalization;

namespace segundoDesafio{

class retangulo{

        public double altura;
        public double largura;

        public double Area(){
            return largura * altura;
        }
        public double Perimetro (){
            return 2*( altura + largura);

        }
        public double Diagonal(){
            return Math.Sqrt(largura*largura+altura*altura);

        }
    } 


}
