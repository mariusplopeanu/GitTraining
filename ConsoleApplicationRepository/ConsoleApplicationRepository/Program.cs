﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepository
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "Hello world";
      var repository = new Repository();
      repository.StringRepository = "Marius!";

      repository.IsEmpty = (String.IsNullOrEmpty(repository.StringRepository)) ? true : false;


      if (repository.IsEmpty == null || repository.IsEmpty == true)
        Console.WriteLine(str + repository.StringRepository);
      else
        Console.WriteLine(str);

      Console.ReadKey();
    }
  }
}
