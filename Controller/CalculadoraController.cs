using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.DAO;
using InMemory.Model;
using InMemory.View;
using Microsoft.VisualBasic;


namespace InMemory.Controller
{
    public class CalculadoraController
    {
        private MaterialDAO materialDAO = MaterialDAO.GetMaterialDAO();

        public void Mesa(int idMaterialPes, int idMaterialSuperficie, double alturaMesa, double larguraSuperficieMesa, double larguraBaseMesa, double comprimentoMesa)
        {

            //material em metros que será utilizado para fazer os dois pes da mesa
            double materialTotalPes = 0;

            //material em barras que será utilizado para fazer os dois pes da mesa
            double materialTotalPesBarras = 0;

            //preco do material que será utilizado para fazer os dois pes da mesa
            double precoPes = 0;

            //material em metros que será utilizado para fazer a superficie da mesa
            double materialTotalSuperficie = 0;

            //material em barras que será utilizado para fazer a superficie da mesa
            double materialTotalSuperficieBarras = 0;

            //preco do material que será utilizado para fazer a superficie da mesa
            double precoSuperficie = 0;

            //preco dos materias da superficie somado com o preco dos materiais dos pes
            double precofinal = 0;

            if (larguraBaseMesa != 0)
            {
                //o programa entrará nesse if se a largura da base for diferente de 0, entao a largura da
                //superficie será diferente da largura da base, indicando que os pés da mesa formarão um trapézio,
                //entao é preciso usar o teorema de pitágoras para descobrir qual o tamanho dos pes, ja que sabemos
                //a altura e o tamanho da da largura da superficie. Entao a hipotenusa(tamanho do pes na diagonal)
                //ao quadrado será igual ao primeiro cateto(altura da mesa) ao quadrado + o segundo cateto
                //(largura da superficie da mesa menos a largura da base da mesa dividido por 2) ao quadrado


                //pega os dados do material que será utilizado para fazer os pes
                Material materialPes = materialDAO.GetMaterial(idMaterialPes);
                //pega os dados do material que será utilizado para fazer os pes
                Material materialSuperficie = materialDAO.GetMaterial(idMaterialSuperficie);


                //se nao houver materiais com os ids passados os materiais dos pes e superficies
                //serao igualados a null, entao vao o usuario será retornado ao menu da calcudora
                //em CalculadoraView
                if (materialPes == null || materialSuperficie == null)
                {
                    System.Console.WriteLine("nao há material com esse id");
                    return;
                }
                else
                {
                    //uso de pitagoras para saber o tamanho dos pes que ficarão na diagonal
                    double pesDiagonalAoQuadrado = (alturaMesa * alturaMesa) + ((larguraSuperficieMesa - larguraBaseMesa) / 2 * ((larguraSuperficieMesa - larguraBaseMesa) / 2));

                    //tirando a raiz quadrada para obter o tamanho dos pes
                    double pesDiagonal = Math.Sqrt(pesDiagonalAoQuadrado);

                    //cada pé da mesa terá 2 pes na diagonal, uma base e uma superficie,
                    //entao somando tudo obtemos a quantidade de material em metros de um pé
                    //entao multiplicaremos esse valor por dois para saber a quantidade dos dois pes
                    materialTotalPes = 2 * ((2 * pesDiagonal) + larguraBaseMesa + larguraSuperficieMesa);

                    //para saber quantas barras completas serão usadas dividimos o material dos dois pes 
                    //pelo tamanho de uma barra completa arredondamos para cima
                    materialTotalPesBarras = Math.Ceiling((double)(materialTotalPes / materialPes.Length));

                    //para saber o preco do material dos pes mutiplicamos as barras completas necessarias para
                    //fazer os pes com o preco de cada barra
                    precoPes = materialTotalPesBarras * materialPes.PriceMaterial;

                    //para saber o total de material da superficie em metros subtraimos do comprimento da mesa: 
                    //duas vezes a largura do material dos pes que será encaixado na superficie,  pois usaremos
                    //um pé em cada lateral. Entao multiplicamos o resultado por 2 para saber o material das 
                    //duas laterais em metros. A largura precisa ser dividida por 1000 pois está em milimetros
                    materialTotalSuperficie = (double)(2 * (comprimentoMesa - (materialPes.Width * 2 / 1000)));

                    //para saber quantas barras completas serão usadas dividimos o material da superficie
                    //pelo tamanho da barra e arredondamos para cima
                    materialTotalSuperficieBarras = Math.Ceiling((double)(materialTotalSuperficie / materialSuperficie.Length));

                    //para saber o preco da superficie da mesa multiplicamos a quantidade de barras que usaremos nela
                    //pelo preco de cada barra
                    precoSuperficie = materialTotalSuperficieBarras * materialSuperficie.PriceMaterial;

                    //o preco final é a soma do preco da superficie com os pes
                    precofinal = precoPes + precoSuperficie;
                }



            }
            else
            {
                //o programa entrará nesse else se a largura da base da mesa for igual a 0
                //indicando que a largura da base da mesa é igual a largura da superficie
                //indincando que os pes sao rentes ao chão. Entao essa parte do código segue
                //a mesma lógica da parte que faz os calculos da mesa em trapezio, mas
                //nao precisa fazer os calculo que envolvem pitagoras pois os pes nao sao
                //na diagonal

                //pega os dados do material que será utilizado para fazer os pes
                Material materialPes = materialDAO.GetMaterial(idMaterialPes);
                //pega os dados do material que será utilizado para fazer os pes
                Material materialSuperficie = materialDAO.GetMaterial(idMaterialSuperficie);
                if (materialPes == null || materialSuperficie == null)
                {
                    System.Console.WriteLine("nao há material com esse id");
                    return;
                }
                else
                {
                    materialTotalPes = 2 * ((2 * alturaMesa) + larguraSuperficieMesa);
                    materialTotalPesBarras = Math.Ceiling((double)(materialTotalPes / materialPes.Length));
                    precoPes = materialTotalPesBarras * materialPes.PriceMaterial;
                    materialTotalSuperficie = (double)(2 * (comprimentoMesa - (materialPes.Width * 2 / 1000)));
                    materialTotalSuperficieBarras = Math.Ceiling((double)(materialTotalSuperficie / materialSuperficie.Length));
                    precoSuperficie = materialTotalSuperficieBarras * materialSuperficie.PriceMaterial;
                    precofinal = precoPes + precoSuperficie;
                }

            }
            System.Console.WriteLine("material total dos pes em metros: " + materialTotalPes);
            System.Console.WriteLine("material total dos pes em barras: " + materialTotalPesBarras);
            System.Console.WriteLine("preco dos materiais dos pes: " + precoPes);
            System.Console.WriteLine("material total da superficie em metros: " + materialTotalSuperficie);
            System.Console.WriteLine("material total da superficie em barras: " + materialTotalSuperficieBarras);
            System.Console.WriteLine("preco dos materiais da superficie: " + precoSuperficie);
            System.Console.WriteLine("preco dos materiais: " + precofinal);
        }




        public void Grade(int id, double altura, double largura, double espaçamento)
        {

            //quantidade de barras na vertical que é possível fazer com uma barra completa (material.Length)
            double barrasVerticaisPorBarraCompleta = 0;

            //barras completas que serão usadas para fazer horizontal completa
            int barrasHorizontal = 0;

            //quantas barras serão necessarias para preencher a largura da grade
            double barrasVertical = 0;

            //quantidade em metros do material usado na vertical
            double materialVertical = 0;

            //quantidade em metros do material usado na horizontal
            double materialHorizontal = 0;

            //quantidade em metros do material usado na grade
            double materialTotal = 0;

            //preco do material usado na horizontal
            double precoHorizontal = 0;

            //preco do material usado na vertical
            double precoVertical = 0;

            //preco do material usado na grade completa
            double precoFinal = 0;

            //barras completas que serão usadas para fazer a vertical completa
            double barrasCompletasPVertical = 0;

            Material material = materialDAO.GetMaterial(id);


            System.Console.WriteLine("quantas barras horizontais serão usadas?");
            barrasHorizontal = int.Parse(Console.ReadLine());

            //para saber quantas barras horizontais serão feitas com uma barra completa (material.Length)
            //arredonda para baixo pois não poderá usar pedaços que sobrarão para fazer outras partes
            barrasVerticaisPorBarraCompleta = Math.Floor((double)material.Length / altura);

            //serão usados nas laterias 2 barras, entao a largura precisa ser reduzina por 2 vezes 
            //a largura do material que está sendo usado
            largura = largura - (double)(2 * (material.Width / 1000));

            //qtd grade arredonda pra cima ou pra baixo ?
            //para saber quantas grades serão necessarias é dividido a largura (já modificada) pela
            //largura do material transformada em metros + o espaçamento entra cada barra vertical tambem
            //transformada em metros + 2 barras (uma de cada lateral)
            barrasVertical = largura / (double)(material.Width / 1000 + espaçamento / 100) + 2;

            //para saber quantas barras completas (material.Length) serão necessarias para fazer todas as 
            //verticais é dividido a quantidade de verticais que precisam ser feitas para preecher a 
            //largura (já modificada)  pela quantidade de verticais que é possivel fazer com uma barra 
            //completa (material.Length)
            barrasCompletasPVertical = Math.Ceiling(barrasVertical / barrasVerticaisPorBarraCompleta);

            //para saber a quantidade de materias em metros necessaria para fazer toda a vertical da grade
            //é multiplicado a quantidade de barras verticais é possivel fazer com uma barra completa 
            //(material.Length) pelo tamanho em metros de cada barra completa (material.Length)
            materialVertical = (double)(barrasCompletasPVertical * material.Length);

            //para saber o preco dos materias para fazer toda a vertical da grade é multiplicado
            //a quantidade de barras que serão usadas pelo preco do material
            precoVertical = barrasCompletasPVertical * material.PriceMaterial;

            //para saber em metros a quantidade de material que será usado para fazer a horizontal
            //é multiplicado a quantidade de barras horizontais que serão necessárias com o 
            //tamanho de cada barra completa (material.Length). Cada barra horizontal vai usar
            //uma barra completa (material.Length)
            materialHorizontal = (double)(barrasHorizontal * material.Length);

            //para saber o preco do material usado para fazer a parte horizontal da grade é 
            //multiplicado a quantidade de barras horizontais pelo preco do material
            precoHorizontal = barrasHorizontal * material.PriceMaterial;

            //para saber o material que será gasto para fazer a grade é somado a quantidade
            //de barras completas para fazer a horizontal e a vertical
            materialTotal = barrasHorizontal + barrasCompletasPVertical;

            //para saber o preco final é somado o preco para fazer a horizontal e a vertical
            precoFinal = precoVertical + precoHorizontal;

            System.Console.WriteLine("quantidade de barras na horizontal que é possível fazer com uma barra completa: " + barrasVerticaisPorBarraCompleta);
            System.Console.WriteLine("quantidade de barras de " + material.Length + "necessárias para fazer a vertical: " + barrasCompletasPVertical);
            System.Console.WriteLine("barras serão necessarias para preencher a largura da grade: " + barrasVertical);
            System.Console.WriteLine("quantidade de material na vertical em metros: " + materialVertical);
            System.Console.WriteLine("preço do material para fazer a vertical: " + precoVertical);

            System.Console.WriteLine("\nquantidade de barras de " + material.Length + "necessárias para fazer a horizontal: " + barrasHorizontal);
            System.Console.WriteLine("quantidade de material na horizontal em metros: " + materialHorizontal);
            System.Console.WriteLine("preço do material para fazer a horizontal: " + precoHorizontal);

            System.Console.WriteLine("\nmaterial total: " + materialTotal);
            System.Console.WriteLine("preco final : " + precoFinal);
        }



    }
}