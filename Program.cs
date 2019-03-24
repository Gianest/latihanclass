using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanclass
{
    class Program
    {
        static void Main(string[] args)
        {
            mahasiswa saya = new mahasiswa();
            mahasiswa kamu = new mahasiswa();

            saya.Nim = "12345";
            saya.Nama = "joko";
            saya.Ipk = "4";

            kamu.Nim = "12346";
            kamu.Nama = "jono";
            kamu.Ipk = "3";

            saya.registrasi();
            saya.IsiKrs();

            kamu.registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
