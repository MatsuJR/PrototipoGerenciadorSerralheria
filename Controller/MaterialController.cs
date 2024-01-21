using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.DAO;
using InMemory.Model;

namespace InMemory.Controller
{
    public class MaterialController
    {
        private MaterialDAO materialDAO = MaterialDAO.GetMaterialDAO();

        public void CreateMaterial(int materialID, string nameMaterial, double priceMaterial, double width, double height, double length, double thickness)
        {
            if (materialID == null || nameMaterial == null || priceMaterial == null)
            {
                System.Console.WriteLine("campos obrigatorios vazios");
            }
            else
            {
                var material = new Material(materialID, nameMaterial, priceMaterial, width, height, length, thickness);
                materialDAO.CreateMaterial(material);

                System.Console.WriteLine("ID do material " + material.MaterialID);
                System.Console.WriteLine("nome do material " + material.NameMaterial);
                System.Console.WriteLine("preço do material (por metro)" + material.PriceMaterial);
                System.Console.WriteLine("largura do material (milimetros)" + material.Width);
                System.Console.WriteLine("altura do material (milimetros)" + material.Height);
                System.Console.WriteLine("comprimento do material (metros)" + material.Length);
                System.Console.WriteLine("espessura do material (milimetros)" + material.Thickness);
            }
        }



        public void DeleteMaterial(int id)
        {
            if (id == null)
            {
                System.Console.WriteLine("nao pode ser vazio");
            }
            else
            {
                materialDAO.DeleteMaterial(id);
            }

        }


        public void UpdateMaterial(int materialID, string nameMaterial, double priceMaterial, double width, double height, double length, double thickness)
        {
            if (materialID == null || nameMaterial == null || priceMaterial == null)
            {
                System.Console.WriteLine("campos obrigatorios vazios");
            }
            else
            {
                var material = new Material(materialID, nameMaterial, priceMaterial, width, height, length, thickness);
                materialDAO.UpdateMaterial(material);
                System.Console.WriteLine("ID do material " + material.MaterialID);
                System.Console.WriteLine("nome do material " + material.NameMaterial);
                System.Console.WriteLine("preço do material " + material.PriceMaterial);
                System.Console.WriteLine("largura do material " + material.Width);
                System.Console.WriteLine("altura do material " + material.Height);
                System.Console.WriteLine("comprimento do material " + material.Length);
                System.Console.WriteLine("espessura do material " + material.Thickness);
            }
        }



        public List<Material> ListMaterial()
        {

            return materialDAO.ListarMaterials();
        }




    }
}