﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution.LSPBad
{
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }

        public abstract void TakePhoto();
    }

    public class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Fotograf");
        }
    }

    public class Nokia : BasePhone
    {
        public override void TakePhoto()
        {
            throw new Exception();
        }
    }

}
