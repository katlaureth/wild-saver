﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.DAL;

namespace WebAppLayer.BusinessLogic
{
    public class NoticiaBL
    {
       private NoticiaDAL noticiaDAL;

        public NoticiaBL()
        {
            this.noticiaDAL = new NoticiaDAL();
        }
       public void AdicionarNoticia()
        {

        }
    }
}