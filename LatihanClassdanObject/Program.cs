using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //Mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.2310";
            saya.Nama = "Nurrofiqi Ankisqiantari";
            saya.Ipk = 3.83f;

            kamu.Nim = "18.11.2291";
            kamu.Nama = "Dewi";
            kamu.Ipk = 3.58f;

            //memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
