﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution.LSPGood
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }
    }

    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
			Console.WriteLine("Foto");
		}
    }

    public class Nokia : BasePhone
    {
  
    }

}
