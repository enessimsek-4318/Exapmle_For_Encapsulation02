using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tc_No_alma__kapsülleme_
{
    class personel
    {
        private string tc;
        public string TC 
        {
            get
            {
                return tc.Substring(0, 5)+"******";
            }
            set
            {
                
                if (value.Length==11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi =char.IsNumber(value[i]);
                        if (sayimi)
                        {
                            tc = value;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz Karakter!!");
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine("Girmiş Olduğunuz Tc Kimlik No 11 Haneli Değildir.");
                }
            } 
        
        
        
        }

    }
}
