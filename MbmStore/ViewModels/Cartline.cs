﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.ViewModels
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}