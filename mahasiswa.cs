﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanclass
{
    class mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Ipk { get; set; }

        public void registrasi()
        {
            Console.WriteLine("Nama:{0}", Nama);
            Console.WriteLine("NIM:{0}", Nim);
            Console.WriteLine("IPK:{0}", Ipk);
            Console.WriteLine("Telah melakukan registrasi");

        }
        public void IsiKrs()
        {
            Console.WriteLine("{0}sedang melakukan proses Krs\n", Nama);
        }
    }
}
