using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMhs
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek Mhs
        static List<Mhs> daftarMhs = new List<Mhs>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMhs();
                        break;

                    case 2:
                        HapusMhs();
                        break;

                    case 3:
                        TampilMhs();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMhs()
        {
            Console.Clear();

            Mhs Mhs = new Mhs();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();
            Console.Write("NIM: ");
            Mhs.NIM = Console.ReadLine();
            Console.Write("Nama: ");
            Mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P]: ");
            Mhs.JenisKelamin = Console.ReadLine();
            Console.Write("IPK: ");
            Mhs.IPK = int.Parse(Console.ReadLine());

            daftarMhs.Add(Mhs);
            Console.WriteLine();

            // PERINTAH: lengkapi kode untuk menambahkan objek Mhs ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMhs()
        {
            Console.Clear();

            int nomor = -1, hapus = -1;
            Console.Write("Hapus Data Mahasiswa: ");
            Console.Write("NIM: ");
            string code = Console.ReadLine();
            foreach (Mhs in daftarMhs)
            {
                nomor++;
                if (Mhs.NIM == code)
                {
                    hapus = nomor;
                }
            }

            if (hapus != -1)
            {
                daftarMhs.RemoveAt(hapus);
                Console.WriteLine("\nData Mahasiswa dapat dihapus");
            }

            else
            {
                Console.WriteLine("\nKode Mahasiswa tidak dapat ditemukan");
            }
            // PERINTAH: lengkapi kode untuk menghapus objek Mhs dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMhs()
        {
            Console.Clear();

            int Urut = 0;
            Console.WriteLine("Data Mahasiswa");
            foreach (Mhs in daftarMhs)
            {

                Console.WriteLine("{0}. NIM: {1}, Nama: {2}, Jenis Kelamin[L/P]: {3}, IPK: {4}", Urut, Mhs.NIM, Mhs.Nama, Mhs.JenisKelamin, Mhs.IPK);
                Urut++;
            }
            if (Urut < 1)
            {
                Console.WriteLine("Data Mahasiswa Kosong");
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar Mhs yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}