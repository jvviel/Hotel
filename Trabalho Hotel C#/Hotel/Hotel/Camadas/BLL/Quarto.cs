using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Camadas.BLL
{
    public class Quarto
    {
        public List<Model.Quarto> Select()
        {
            DAL.Quarto dalQuarto = new DAL.Quarto();

            return dalQuarto.Select();
        }

        public List<Model.Quarto> SelectById(int id)
        {
            DAL.Quarto dalQuarto = new DAL.Quarto();

            return dalQuarto.SelectById(id);
        }

        public List<Model.Quarto> SelectByNome(string nome)
        {
            DAL.Quarto dalQuarto = new DAL.Quarto();

            return dalQuarto.SelectByNome(nome);
        }

        public void Insert(Model.Quarto quarto)
        {
            DAL.Quarto dalQuarto = new DAL.Quarto();

            dalQuarto.Insert(quarto);
        }

        public void Update(Model.Quarto quarto)
        {
            DAL.Quarto dalQuarto = new DAL.Quarto();

            dalQuarto.Update(quarto);
        }

        public void Delete(Model.Quarto quarto)
        {
            DAL.Quarto dalQuarto = new DAL.Quarto();

            dalQuarto.Delete(quarto);
        }

        }
}
