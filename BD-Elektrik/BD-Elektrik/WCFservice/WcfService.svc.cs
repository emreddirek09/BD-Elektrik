﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BD_Elektrik.WCFservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WcfService.svc or WcfService.svc.cs at the Solution Explorer and start debugging.
    public class WcfService : IWcfService
    {
        public void DoWork()
        {
        }

        //işlemlerimizi burada yapyoruz. Fonksiyon ön adını interface yazmamız lazım.
        public string ADGetir(string parametre)
        {
            return parametre + "Direk";
        }
    }
}
