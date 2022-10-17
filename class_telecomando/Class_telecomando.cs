﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_telecomando
{


    internal class Class_telecomando
    {
        private string Produttore;
        private string Modello;
        private string Modalità;

        private int Canale;
        private int Volume;
        private Class_televisore televisore;


        public Class_telecomando(string ilproduttore, string ilmodello)
        {
            Produttore = ilproduttore;
            Modello = ilmodello;
        }

        public Class_telecomando(string prod, string mod, int funz, Class_televisore televisore)
        {
            Produttore = prod;
            Modello = mod;
            Volume = 0;
            Canale = 1;
        }


        public void accendi()
        {
            if (televisore != null && televisore.getStato() == false)
            {
                televisore.accendi();
            }

        }

        public void spegni()
        {
            if (televisore != null && televisore.getStato() == true)
            {
                televisore.spegni();
            }
        }

        public void AlzaVolume()
        {
            if (televisore != null) 
            {
                televisore.AlzaVol();
            }
          
        }

        public void AbbassaVolume()
        {
            televisore.AbbassaVol();
        }
        public void CambiaCanale(int Newcanale)
        {
            televisore.CambiaCanale(Newcanale);
        }
        public void setStato(bool statoNuovo)
        {
            if (televisore != null)
            {
                televisore.setStato(statoNuovo);
            }
        }

        public int getVolume()
        {
            return televisore.getVolume();
        }
        public string getProduttore()
        {
            return televisore.getProduttore();
        }

        public string getModello()
        {
            return Modello;
        }

        public int getCanale()
        {
            return Canale;
        }

        public void setTV(Class_televisore latv)
        {
            televisore = latv;
        }

        public Class_televisore getTV()
        {
            return televisore;
        }


    }
}

