using LanguageExt;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BaseDAO<T> where T : class
    {
        public BaseDAO() {
            this._context = new FUCarRentingManagementContext<T>();
        }
        protected readonly FUCarRentingManagementContext<T> _context;
        public async Task<List<T>> GetAll()
        {
            List<T> listEntity = new List<T>();
            try
            {
                listEntity = await _context.Entity.ToListAsync();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listEntity;
        }
        public async Task<Option<T>> getEntityByID(int id)
        {
            try
            {
                T result = await _context.Entity.FindAsync(id);
                return result == null ? Option<T>.None : Option<T>.Some(result);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddEntity(T data)
        {
            try
            {
                _context.Entity.Add(data);
                _context.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteEntity(T data)
        {
            try
            {
                _context.Entity.Remove(data);
                _context.SaveChanges();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateEntity(T data)
        {
            try
            {
                _context.Entry(data).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
