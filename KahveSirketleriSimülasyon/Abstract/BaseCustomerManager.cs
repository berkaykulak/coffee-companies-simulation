﻿using KahveSirketleriSimülasyon.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using KahveSirketleriSimülasyon.Abstract;
namespace KahveSirketleriSimülasyon.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db " + customer.FirstName);
        }
    }
}
