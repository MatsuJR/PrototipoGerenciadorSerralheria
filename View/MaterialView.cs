using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Controller;
using Microsoft.VisualBasic;
using InMemory.Model;

namespace InMemory.View
{
    public class MaterialView
    {
        public int inputMaterialID;
        public string? inputNameMaterial;
        public double inputPriceMaterial;
        public double inputWidth;
        public double inputHeight;
        public double inputLength;
        public double inputThickness;



        MaterialController controller = new MaterialController();

        private List<Material> materials = new List<Material>();


        public void OpcaoMaterial()
        {
            int op;
            do
            {
                var controller = new MaterialController();
                System.Console.WriteLine("escolha um opcao:");
                System.Console.WriteLine("0- sair");
                System.Console.WriteLine("1- criar");
                System.Console.WriteLine("2- excluir");
                System.Console.WriteLine("3- alterar");
                System.Console.WriteLine("4- pesquisar");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        RecebeDadosMaterial();
                        controller.CreateMaterial(inputMaterialID, inputNameMaterial, inputPriceMaterial, inputWidth, inputHeight, inputLength, inputThickness);
                        break;
                    case 2:
                        DadosExcluirMaterial();
                        controller.DeleteMaterial(inputMaterialID);
                        break;
                    case 3:
                        RecebeDadosMaterial();
                        controller.UpdateMaterial(inputMaterialID, inputNameMaterial, inputPriceMaterial, inputWidth, inputHeight, inputLength, inputThickness);
                        break;
                    case 4:
                        materials = controller.ListMaterial();
                        foreach (Material material in materials)
                        {
                            System.Console.WriteLine("ID do material " + material.MaterialID);
                            System.Console.WriteLine("nome do material " + material.NameMaterial);
                            System.Console.WriteLine("preço do material " + material.PriceMaterial);
                            System.Console.WriteLine("largura do material " + material.Width);
                            System.Console.WriteLine("altura do material " + material.Height);
                            System.Console.WriteLine("comprimento do material " + material.Length);
                            System.Console.WriteLine("espessura do material " + material.Thickness);
                        }
                        break;

                    default: Console.WriteLine("Opcao incorreta"); OpcaoMaterial(); break;
                }
            } while (op != 0);
            Program.Menu();
        }

        public void RecebeDadosMaterialSimples()
        {
            System.Console.WriteLine("digite o ID do material");
            inputMaterialID = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o nome do material");
            inputNameMaterial = Console.ReadLine();
            System.Console.WriteLine("digite o preço do material");
            inputPriceMaterial = double.Parse(Console.ReadLine());

        }

        public void RecebeDadosMaterial()
        {
            System.Console.WriteLine("digite o ID do material");
            inputMaterialID = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o nome do material");
            inputNameMaterial = Console.ReadLine();
            System.Console.WriteLine("digite o preço do material");
            inputPriceMaterial = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a largura do material (milimetros)");
            inputWidth = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a altura do material (milimetros)");
            inputHeight = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o comprimento do material (metros)");
            inputLength = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite espessura do material (milimetros)");
            inputThickness = double.Parse(Console.ReadLine());
        }



        public void DadosExcluirMaterial()
        {
            System.Console.WriteLine("digite o id do material que quer excluir:");
            inputMaterialID = int.Parse(Console.ReadLine());

        }


    }
}