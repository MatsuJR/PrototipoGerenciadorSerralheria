using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.DAO;
using InMemory.Model;
using Microsoft.VisualBasic;


namespace InMemory.Controller
{
    public class CalculadoraController
    {
        private MaterialDAO materialDAO = MaterialDAO.GetMaterialDAO();


        public void Mesa(int idMaterialPes, int idMaterialSuperficie, double alturaMesa, double larguraSuperficieMesa, double larguraBaseMesa, double comprimentoMesa)
        {
            Material materialPes = materialDAO.GetMaterial(idMaterialPes);
            Material materialSuperficie = materialDAO.GetMaterial(idMaterialSuperficie);
            double materialTotalPes;
            double materialTotalPesBarras;
            double precoPes;
            double materialTotalSuperficie;
            double materialTotalSuperficieBarras;
            double precoSuperficie;
            double precofinal;
            if (larguraBaseMesa != 0)
            {
                System.Console.WriteLine("altura" + alturaMesa);
                System.Console.WriteLine("largura s" + larguraSuperficieMesa);
                System.Console.WriteLine("largura b" + larguraBaseMesa);
                System.Console.WriteLine("comprimento" + comprimentoMesa);
                System.Console.WriteLine("");
                System.Console.WriteLine("");

                double pesDiagonalAoQuadrado = (alturaMesa * alturaMesa) + ((larguraSuperficieMesa - larguraBaseMesa) / 2 * ((larguraSuperficieMesa - larguraBaseMesa) / 2));
                System.Console.WriteLine("diagonal quadrado: " + pesDiagonalAoQuadrado);

                double pesDiagonal = Math.Sqrt(pesDiagonalAoQuadrado);
                System.Console.WriteLine("diagonal: " + pesDiagonal);

                materialTotalPes = 2 * ((2 * pesDiagonal) + larguraBaseMesa + larguraSuperficieMesa);
                System.Console.WriteLine("material total dos pes em metros: " + materialTotalPes);

                materialTotalPesBarras = (double)(materialTotalPes / materialPes.Length);
                precoPes = materialTotalPesBarras * materialPes.PriceMaterial;
                materialTotalSuperficie = (double)(2 * (comprimentoMesa - (materialPes.Width * 2 / 1000)));
                materialTotalSuperficieBarras = (double)(materialTotalSuperficie / materialSuperficie.Length);
                precoSuperficie = materialTotalSuperficieBarras * materialSuperficie.PriceMaterial;
                precofinal = precoPes + precoSuperficie;
            }
            else
            {
                materialTotalPes = 2 * ((2 * alturaMesa) + larguraSuperficieMesa);
                materialTotalPesBarras = (double)(materialTotalPes / materialPes.Length);
                precoPes = materialTotalPesBarras * materialPes.PriceMaterial;
                materialTotalSuperficie = (double)(2 * (comprimentoMesa - (materialPes.Width * 2 / 1000)));
                materialTotalSuperficieBarras = (double)(materialTotalSuperficie / materialSuperficie.Length);
                precoSuperficie = materialTotalSuperficieBarras * materialSuperficie.PriceMaterial;
                precofinal = precoPes + precoSuperficie;
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
            double qtdgrade = 0;
            double materialVertical = 0;
            double materialHorizontal = 0;
            double materialTotal = 0;
            double precoFinal = 0;
            Material material = materialDAO.GetMaterial(id);
            System.Console.WriteLine("Vao ter materiais nas lateria ? (s ou n)");
            char materialLaterais = char.Parse(Console.ReadLine());
            if (materialLaterais == 's')
            {
                largura = largura - (double)(2 * (material.Width / 1000));
                //a grade sempre comeca com as laterais preenchidas ??
                //se sim nao precisa do if/ e fica so o conteudo dentro do if nao do else
                qtdgrade = largura / (double)(material.Width / 1000 + espaçamento / 100) + 2;
                materialVertical = qtdgrade * altura;
                materialHorizontal = largura * 2;
                materialTotal = materialVertical + materialHorizontal;
                precoFinal = materialTotal * material.PriceMaterial;

            }
            else if (materialLaterais == 'n')
            {
                qtdgrade = largura / (double)(material.Width / 1000 + espaçamento / 100);
                materialVertical = qtdgrade * altura;
                materialHorizontal = largura * 2;
                materialTotal = materialVertical + materialHorizontal;
                precoFinal = materialTotal * material.PriceMaterial;
            }
            System.Console.WriteLine("quantidade de grades:" + qtdgrade);
            System.Console.WriteLine("quantidade de material na vertical: " + materialVertical);
            System.Console.WriteLine("quantidade de material na horizontal: " + materialHorizontal);
            System.Console.WriteLine("material total: " + materialTotal);
            System.Console.WriteLine("preco final : " + precoFinal);
        }






    }
}