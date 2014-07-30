﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Singleton
{
    private static Singleton instance;

    public MainWindow mainWindow;

    private Singleton() 
    {
        ;
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
                
            }
            return instance;
        }
    }
}
