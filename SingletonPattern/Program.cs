﻿using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.getInstance();
        }
    }
}
