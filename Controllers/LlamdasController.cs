using Microsoft.EntityFrameworkCore;
using SegundoParcialAplicada2.Data;
using SegundoParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SegundoParcialAplicada2.Controllers
{
    public class LlamdasController
    {

        public virtual void Guardar(Llamadas llamadas)
        {
            if(llamadas.LlamadaId==0)
            {
                Insertar(llamadas);
            }
            else
            {
                Modificar(llamadas);
            }
        }

        public static bool Insertar(Llamadas llamadas)
        {
            bool paso = false;
            Contexto Database = new Contexto();
            try
            {
                Database.Llamadas.Add(llamadas);
                paso = Database.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Modificar(Llamadas llamadas)
        {
            bool paso = false;
            Contexto Database = new Contexto();
            try
            {
                Database.Entry(llamadas).State = EntityState.Modified;
                paso = Database.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static Llamadas Buscar(int id)
        {
            Llamadas llamadas;
            Contexto DataBase = new Contexto();

            try
            {
                llamadas= DataBase.Llamadas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return llamadas;
        }

        public List<Llamadas> GetList(Expression<Func<Llamadas,bool>>expression)
        {
            Contexto DataBase = new Contexto();
            List<Llamadas> lista = new List<Llamadas>();
            try
            {
                lista = DataBase.Llamadas.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public static bool Eliminar(int Id)
        {
            Contexto DataBase = new Contexto();
            Llamadas llamada = new Llamadas();
            bool paso = false;
            try
            {
                llamada = DataBase.Llamadas.Find(Id);
                DataBase.Llamadas.Remove(llamada);
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
    }
}
