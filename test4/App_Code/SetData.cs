using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test4.App_Code
{
    public class SetData
    {
        public string Acat { get; set; }
        public string Atitle { get; set; }
        public string Adesc { get; set; }
        public string ASlot { get; set; }
        public string Aprior { get; set; }
        public byte[] AFDATA { get; set; }
        public string AFNAME { get; set; }

        public SetData(string d0,string d1,string d2,string d3,string d4,byte[] d5,string d6)
        {
            Acat=d0;
            Atitle = d1;
            Adesc = d2;
            try
            {
                switch(d3)
                {
                    case "1":
                        ASlot = "S1";
                        break;
                    case "2":
                        ASlot = "S2";
                        break;
                    case "3":
                        ASlot = "S3";
                        break;

                }
                switch (d4)
                {
                    case "1":
                        Aprior = "H";
                        break;
                    case "2":
                        Aprior = "M";
                        break;
                    case "3":
                        Aprior = "L";
                        break;

                }
                AFNAME = d6;
                AFDATA = d5;
            }
            catch(Exception ex)
            {
                //lout.ex.Message;
            }
        }

        public double Cost ()
        {
            switch(this.ASlot+this.Aprior)
            {
                case "S1H":
                    return (0.5 * 0.5);
                case "S1M":
                    return (0.5 * 0.3);
                case "S1L":
                    return (0.5 * 0.2);
                case "S2H":
                    return (0.4 * 0.5);
                case "S2M":
                    return (0.4 * 0.3);
                case "S2L":
                    return (0.4 * 0.2);
                case "S3H":
                    return (0.4 * 0.5);
                case "S3M":
                    return (0.4 * 0.3);
                case "S3L":
                    return (0.4 * 0.2);
            }
            return -1;
        }

        public int Weight()
        {
            switch (this.ASlot + this.Aprior)
            {
                case "S1H":
                    return (5);
                case "S1M":
                    return (4);
                case "S1L":
                    return (3);
                case "S2H":
                    return (5);
                case "S2M":
                    return (3);
                case "S2L":
                    return (2);
                case "S3H":
                    return (5);
                case "S3M":
                    return (3);
                case "S3L":
                    return (2);
            }
            return -1;
        }
    }
}