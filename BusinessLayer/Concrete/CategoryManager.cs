﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService

    {
        ICategoryDal _categoryDal;

        public CategoryManager()
        {
            _categoryDal = _categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t); 
        }

        public Category TGetById(int id)
        {
           return  _categoryDal.GetById(id);   
        }

        public List<Category> TGetList()
        {
          return  _categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);

        }
    }
}
